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
    public partial class InstituicosComponent : ComponentBase
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

        protected RadzenGrid<C4G.Models.C4G.Instituico> grid0;

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
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddInstituico>("Add Instituico", null);
            grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(C4G.Models.C4G.Instituico args)
        {
            var dialogResult = await DialogService.OpenAsync<EditInstituico>("Edit Instituico", new Dictionary<string, object>() { {"id_instituicao", args.id_instituicao} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var c4GDeleteInstituicoResult = await C4G.DeleteInstituico(data.id_instituicao);
                if (c4GDeleteInstituicoResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception c4GDeleteInstituicoException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete Instituico");
            }
        }
    }
}
