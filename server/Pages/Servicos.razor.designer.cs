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
    public partial class ServicosComponent : ComponentBase
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

        protected RadzenGrid<C4G.Models.C4G.Servico> grid0;

        IEnumerable<C4G.Models.C4G.Servico> _getServicosResult;
        protected IEnumerable<C4G.Models.C4G.Servico> getServicosResult
        {
            get
            {
                return _getServicosResult;
            }
            set
            {
                if(!object.Equals(_getServicosResult, value))
                {
                    _getServicosResult = value;
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
            var c4GGetServicosResult = await C4G.GetServicos();
            getServicosResult = c4GGetServicosResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddServico>("Add Servico", null);
            grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(C4G.Models.C4G.Servico args)
        {
            var dialogResult = await DialogService.OpenAsync<EditServico>("Edit Servico", new Dictionary<string, object>() { {"id_servico", args.id_servico} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var c4GDeleteServicoResult = await C4G.DeleteServico(data.id_servico);
                if (c4GDeleteServicoResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception c4GDeleteServicoException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete Servico");
            }
        }
    }
}
