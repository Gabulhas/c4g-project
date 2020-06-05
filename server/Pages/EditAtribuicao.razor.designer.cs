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
    public partial class EditAtribuicaoComponent : ComponentBase
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
        public dynamic id_atribuicao { get; set; }

        C4G.Models.C4G.Atribuicao _atribuicao;
        protected C4G.Models.C4G.Atribuicao atribuicao
        {
            get
            {
                return _atribuicao;
            }
            set
            {
                if(!object.Equals(_atribuicao, value))
                {
                    _atribuicao = value;
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
            var c4GGetAtribuicaoByidAtribuicaoResult = await C4G.GetAtribuicaoByidAtribuicao(id_atribuicao);
            atribuicao = c4GGetAtribuicaoByidAtribuicaoResult;

            var c4GGetRecursosResult = await C4G.GetRecursos();
            getRecursosResult = c4GGetRecursosResult;

            var c4GGetServicosResult = await C4G.GetServicos();
            getServicosResult = c4GGetServicosResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(C4G.Models.C4G.Atribuicao args)
        {
            try
            {
                var c4GUpdateAtribuicaoResult = await C4G.UpdateAtribuicao(id_atribuicao, atribuicao);
                DialogService.Close(atribuicao);
            }
            catch (Exception c4GUpdateAtribuicaoException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update Atribuicao");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
