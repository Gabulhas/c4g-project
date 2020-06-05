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
    public partial class AddFormacoComponent : ComponentBase
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

        IEnumerable<C4G.Models.C4G.Laboratorio> _getLaboratoriosResult;
        protected IEnumerable<C4G.Models.C4G.Laboratorio> getLaboratoriosResult
        {
            get
            {
                return _getLaboratoriosResult;
            }
            set
            {
                if(!object.Equals(_getLaboratoriosResult, value))
                {
                    _getLaboratoriosResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<C4G.Models.C4G.Recurso> _getRecursosResult;
        protected IEnumerable<C4G.Models.C4G.Recurso> getRecursosResult
        {
            get
            {
                return _getRecursosResult;
            }
            set
            {
                if(!object.Equals(_getRecursosResult, value))
                {
                    _getRecursosResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        C4G.Models.C4G.Formaco _formaco;
        protected C4G.Models.C4G.Formaco formaco
        {
            get
            {
                return _formaco;
            }
            set
            {
                if(!object.Equals(_formaco, value))
                {
                    _formaco = value;
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
            var c4GGetLaboratoriosResult = await C4G.GetLaboratorios();
            getLaboratoriosResult = c4GGetLaboratoriosResult;

            var c4GGetRecursosResult = await C4G.GetRecursos();
            getRecursosResult = c4GGetRecursosResult;

            formaco = new C4G.Models.C4G.Formaco(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(C4G.Models.C4G.Formaco args)
        {
            try
            {
                var c4GCreateFormacoResult = await C4G.CreateFormaco(formaco);
                DialogService.Close(formaco);
            }
            catch (Exception c4GCreateFormacoException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new Formaco!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
