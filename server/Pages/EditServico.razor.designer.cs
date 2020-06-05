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
    public partial class EditServicoComponent : ComponentBase
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

        [Parameter]
        public dynamic id_servico { get; set; }

        C4G.Models.C4G.Servico _servico;
        protected C4G.Models.C4G.Servico servico
        {
            get
            {
                return _servico;
            }
            set
            {
                if(!object.Equals(_servico, value))
                {
                    _servico = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<C4G.Models.C4G.Pessoa> _getPessoasResult;
        protected IEnumerable<C4G.Models.C4G.Pessoa> getPessoasResult
        {
            get
            {
                return _getPessoasResult;
            }
            set
            {
                if(!object.Equals(_getPessoasResult, value))
                {
                    _getPessoasResult = value;
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
            var c4GGetServicoByidServicoResult = await C4G.GetServicoByidServico(id_servico);
            servico = c4GGetServicoByidServicoResult;

            var c4GGetPessoasResult = await C4G.GetPessoas();
            getPessoasResult = c4GGetPessoasResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(C4G.Models.C4G.Servico args)
        {
            try
            {
                var c4GUpdateServicoResult = await C4G.UpdateServico(id_servico, servico);
                DialogService.Close(servico);
            }
            catch (Exception c4GUpdateServicoException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update Servico");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
