using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using C4G.Models.C4G;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using C4G.Models;

namespace C4G.Pages
{
    public partial class AddPessoaComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected SecurityService Security { get; set; }


        [Inject]
        protected C4GService C4G { get; set; }

        IEnumerable<C4G.Models.C4G.Instituico> _getInstituicosResult;
        protected IEnumerable<C4G.Models.C4G.Instituico> getInstituicosResult
        {
            get
            {
                return _getInstituicosResult;
            }
            set
            {
                if(!object.Equals(_getInstituicosResult, value))
                {
                    _getInstituicosResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        C4G.Models.C4G.Pessoa _pessoa;
        protected C4G.Models.C4G.Pessoa pessoa
        {
            get
            {
                return _pessoa;
            }
            set
            {
                if(!object.Equals(_pessoa, value))
                {
                    _pessoa = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }
        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            if (!Security.IsAuthenticated())
            {
                UriHelper.NavigateTo("Login", true);
            }
            else
            {
                await Load();
            }

        }
        protected async System.Threading.Tasks.Task Load()
        {
            var c4GGetInstituicosResult = await C4G.GetInstituicos();
            getInstituicosResult = c4GGetInstituicosResult;

            pessoa = new C4G.Models.C4G.Pessoa(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(C4G.Models.C4G.Pessoa args)
        {
            try
            {
                var c4GCreatePessoaResult = await C4G.CreatePessoa(pessoa);
                DialogService.Close(pessoa);
            }
            catch (Exception c4GCreatePessoaException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new Pessoa!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
