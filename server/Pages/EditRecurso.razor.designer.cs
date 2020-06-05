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
    public partial class EditRecursoComponent : ComponentBase
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
        public dynamic id_recursos { get; set; }

        C4G.Models.C4G.Recurso _recurso;
        protected C4G.Models.C4G.Recurso recurso
        {
            get
            {
                return _recurso;
            }
            set
            {
                if(!object.Equals(_recurso, value))
                {
                    _recurso = value;
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
            var c4GGetRecursoByidRecursosResult = await C4G.GetRecursoByidRecursos(id_recursos);
            recurso = c4GGetRecursoByidRecursosResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(C4G.Models.C4G.Recurso args)
        {
            try
            {
                var c4GUpdateRecursoResult = await C4G.UpdateRecurso(id_recursos, recurso);
                DialogService.Close(recurso);
            }
            catch (Exception c4GUpdateRecursoException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update Recurso");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
