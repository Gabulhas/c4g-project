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
    public partial class EditInstituicoComponent : ComponentBase
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
        public dynamic id_instituicao { get; set; }

        C4G.Models.C4G.Instituico _instituico;
        protected C4G.Models.C4G.Instituico instituico
        {
            get
            {
                return _instituico;
            }
            set
            {
                if(!object.Equals(_instituico, value))
                {
                    _instituico = value;
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
            var c4GGetInstituicoByidInstituicaoResult = await C4G.GetInstituicoByidInstituicao(id_instituicao);
            instituico = c4GGetInstituicoByidInstituicaoResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(C4G.Models.C4G.Instituico args)
        {
            try
            {
                var c4GUpdateInstituicoResult = await C4G.UpdateInstituico(id_instituicao, instituico);
                DialogService.Close(instituico);
            }
            catch (Exception c4GUpdateInstituicoException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update Instituico");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
