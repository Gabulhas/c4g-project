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
    public partial class AddIndisponibilidadeComponent : ComponentBase
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

        IEnumerable<C4G.Models.C4G.Pedido> _getPedidosResult;
        protected IEnumerable<C4G.Models.C4G.Pedido> getPedidosResult
        {
            get
            {
                return _getPedidosResult;
            }
            set
            {
                if(!object.Equals(_getPedidosResult, value))
                {
                    _getPedidosResult = value;
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

        C4G.Models.C4G.Indisponibilidade _indisponibilidade;
        protected C4G.Models.C4G.Indisponibilidade indisponibilidade
        {
            get
            {
                return _indisponibilidade;
            }
            set
            {
                if(!object.Equals(_indisponibilidade, value))
                {
                    _indisponibilidade = value;
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
            var c4GGetPedidosResult = await C4G.GetPedidos();
            getPedidosResult = c4GGetPedidosResult;

            var c4GGetRecursosResult = await C4G.GetRecursos();
            getRecursosResult = c4GGetRecursosResult;

            indisponibilidade = new C4G.Models.C4G.Indisponibilidade(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(C4G.Models.C4G.Indisponibilidade args)
        {
            try
            {
                var c4GCreateIndisponibilidadeResult = await C4G.CreateIndisponibilidade(indisponibilidade);
                DialogService.Close(indisponibilidade);
            }
            catch (Exception c4GCreateIndisponibilidadeException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new Indisponibilidade!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
