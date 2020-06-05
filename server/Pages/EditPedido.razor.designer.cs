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
    public partial class EditPedidoComponent : ComponentBase
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
        public dynamic id_pedido { get; set; }

        C4G.Models.C4G.Pedido _pedido;
        protected C4G.Models.C4G.Pedido pedido
        {
            get
            {
                return _pedido;
            }
            set
            {
                if(!object.Equals(_pedido, value))
                {
                    _pedido = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

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
            var c4GGetPedidoByidPedidoResult = await C4G.GetPedidoByidPedido(id_pedido);
            pedido = c4GGetPedidoByidPedidoResult;

            var c4GGetServicosResult = await C4G.GetServicos();
            getServicosResult = c4GGetServicosResult;

            var c4GGetPessoasResult = await C4G.GetPessoas();
            getPessoasResult = c4GGetPessoasResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(C4G.Models.C4G.Pedido args)
        {
            try
            {
                var c4GUpdatePedidoResult = await C4G.UpdatePedido(id_pedido, pedido);
                DialogService.Close(pedido);
            }
            catch (Exception c4GUpdatePedidoException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update Pedido");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
