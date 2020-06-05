﻿using System;
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
    public partial class EditIndisponibilidadeComponent : ComponentBase
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

        [Parameter]
        public dynamic id_recursos { get; set; }

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
            var c4GGetIndisponibilidadeByIdPedidoAndIdRecursosResult = await C4G.GetIndisponibilidadeByIdPedidoAndIdRecursos(id_pedido, id_recursos);
            indisponibilidade = c4GGetIndisponibilidadeByIdPedidoAndIdRecursosResult;

            var c4GGetPedidosResult = await C4G.GetPedidos();
            getPedidosResult = c4GGetPedidosResult;

            var c4GGetRecursosResult = await C4G.GetRecursos();
            getRecursosResult = c4GGetRecursosResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(C4G.Models.C4G.Indisponibilidade args)
        {
            try
            {
                var c4GUpdateIndisponibilidadeResult = await C4G.UpdateIndisponibilidade(id_pedido, id_recursos, indisponibilidade);
                DialogService.Close(indisponibilidade);
            }
            catch (Exception c4GUpdateIndisponibilidadeException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update Indisponibilidade");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
