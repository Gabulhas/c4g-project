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
    public partial class IndisponibilidadesComponent : ComponentBase
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

        protected RadzenGrid<C4G.Models.C4G.Indisponibilidade> grid0;

        IEnumerable<C4G.Models.C4G.Indisponibilidade> _getIndisponibilidadesResult;
        protected IEnumerable<C4G.Models.C4G.Indisponibilidade> getIndisponibilidadesResult
        {
            get
            {
                return _getIndisponibilidadesResult;
            }
            set
            {
                if(!object.Equals(_getIndisponibilidadesResult, value))
                {
                    _getIndisponibilidadesResult = value;
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
            var c4GGetIndisponibilidadesResult = await C4G.GetIndisponibilidades();
            getIndisponibilidadesResult = c4GGetIndisponibilidadesResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddIndisponibilidade>("Add Indisponibilidade", null);
            grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(C4G.Models.C4G.Indisponibilidade args)
        {
            var dialogResult = await DialogService.OpenAsync<EditIndisponibilidade>("Edit Indisponibilidade", new Dictionary<string, object>() { {"id_pedido", args.id_pedido}, {"id_recursos", args.id_recursos} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var c4GDeleteIndisponibilidadeResult = await C4G.DeleteIndisponibilidade(data.id_pedido, data.id_recursos);
                if (c4GDeleteIndisponibilidadeResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception c4GDeleteIndisponibilidadeException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete Indisponibilidade");
            }
        }
    }
}
