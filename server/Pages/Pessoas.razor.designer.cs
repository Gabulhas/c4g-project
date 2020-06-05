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
    public partial class PessoasComponent : ComponentBase
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

        protected RadzenGrid<C4G.Models.C4G.Pessoa> grid0;

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
            var c4GGetPessoasResult = await C4G.GetPessoas();
            getPessoasResult = c4GGetPessoasResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddPessoa>("Add Pessoa", null);
            grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(C4G.Models.C4G.Pessoa args)
        {
            var dialogResult = await DialogService.OpenAsync<EditPessoa>("Edit Pessoa", new Dictionary<string, object>() { {"id_pessoa", args.id_pessoa} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var c4GDeletePessoaResult = await C4G.DeletePessoa(data.id_pessoa);
                if (c4GDeletePessoaResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception c4GDeletePessoaException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete Pessoa");
            }
        }
    }
}
