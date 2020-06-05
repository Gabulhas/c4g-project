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
    public partial class AtribuicaosComponent : ComponentBase
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

        protected RadzenGrid<C4G.Models.C4G.Atribuicao> grid0;

        IEnumerable<C4G.Models.C4G.Atribuicao> _getAtribuicaosResult;
        protected IEnumerable<C4G.Models.C4G.Atribuicao> getAtribuicaosResult
        {
            get
            {
                return _getAtribuicaosResult;
            }
            set
            {
                if(!object.Equals(_getAtribuicaosResult, value))
                {
                    _getAtribuicaosResult = value;
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
            var c4GGetAtribuicaosResult = await C4G.GetAtribuicaos();
            getAtribuicaosResult = c4GGetAtribuicaosResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddAtribuicao>("Add Atribuicao", null);
            grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(C4G.Models.C4G.Atribuicao args)
        {
            var dialogResult = await DialogService.OpenAsync<EditAtribuicao>("Edit Atribuicao", new Dictionary<string, object>() { {"id_atribuicao", args.id_atribuicao} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var c4GDeleteAtribuicaoResult = await C4G.DeleteAtribuicao(data.id_atribuicao);
                if (c4GDeleteAtribuicaoResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception c4GDeleteAtribuicaoException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete Atribuicao");
            }
        }
    }
}
