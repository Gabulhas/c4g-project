#pragma checksum "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c38e5167ae7ea3197aed14736c23358d7f878f5"
// <auto-generated/>
#pragma warning disable 1591
namespace C4G.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\_Imports.razor"
using C4G.Shared;

#line default
#line hidden
#line 3 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
using Radzen;

#line default
#line hidden
#line 4 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 5 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
using C4G.Models.C4G;

#line default
#line hidden
#line 6 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 7 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
using C4G.Models;

#line default
#line hidden
    public partial class MainLayout : C4G.Layouts.MainLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenHeader>(4);
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row justify-content-start align-items-center");
                __builder2.AddMarkupContent(9, "\n      ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-md-6 d-flex align-items-center");
                __builder2.AddMarkupContent(12, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSidebarToggle>(13);
                __builder2.AddAttribute(14, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.EventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#line 15 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                     SidebarToggle0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(16);
                __builder2.AddAttribute(17, "Text", "c4g");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n      ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col-md-6 text-lg-right");
                __builder2.AddMarkupContent(22, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenProfileMenu>(23);
                __builder2.AddAttribute(24, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                      Security.IsAuthenticated()

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenProfileMenuItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenProfileMenuItem>(this, 
#line 21 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                                                           Profilemenu0Click

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(28);
                    __builder3.AddAttribute(29, "Path", "profile");
                    __builder3.AddAttribute(30, "Icon", "settings");
                    __builder3.AddAttribute(31, "Text", "Profile");
                    __builder3.AddAttribute(32, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 23 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                                                                           Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(34);
                    __builder3.AddAttribute(35, "Path", "application-users");
                    __builder3.AddAttribute(36, "Icon", "person");
                    __builder3.AddAttribute(37, "Text", "Users");
                    __builder3.AddAttribute(38, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 25 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                                                                                 Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(40);
                    __builder3.AddAttribute(41, "Path", "application-roles");
                    __builder3.AddAttribute(42, "Icon", "security");
                    __builder3.AddAttribute(43, "Text", "Roles");
                    __builder3.AddAttribute(44, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 27 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                                                                                   Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenProfileMenuItem>(46);
                    __builder3.AddAttribute(47, "Text", "Logout");
                    __builder3.AddAttribute(48, "Value", "Logout");
                    __builder3.AddAttribute(49, "Icon", "power_settings_new");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n          ");
                }
                ));
                __builder2.AddAttribute(51, "Template", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(52, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGravatar>(53);
                    __builder3.AddAttribute(54, "Email", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 33 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                     Security.User?.Name

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\n  ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenBody>(60);
            __builder.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(62, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenContentContainer>(63);
                __builder2.AddAttribute(64, "Name", "main");
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(66, "\n    ");
                    __builder3.AddContent(67, 
#line 44 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
     Body

#line default
#line hidden
                    );
                    __builder3.AddMarkupContent(68, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(70, (__value) => {
#line 41 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                  body0 = (Radzen.Blazor.RadzenBody)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(71, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenSidebar>(72);
            __builder.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(74, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanelMenu>(75);
                __builder2.AddAttribute(76, "style", "height: 100%");
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(78, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(79);
                    __builder3.AddAttribute(80, "Text", "Atribuicaos");
                    __builder3.AddAttribute(81, "Path", "atribuicaos");
                    __builder3.AddAttribute(82, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 52 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                                                             Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(84);
                    __builder3.AddAttribute(85, "Text", "Dados");
                    __builder3.AddAttribute(86, "Path", "dados");
                    __builder3.AddAttribute(87, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 54 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                                                 Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(89);
                    __builder3.AddAttribute(90, "Text", "Equipamentos");
                    __builder3.AddAttribute(91, "Path", "equipamentos");
                    __builder3.AddAttribute(92, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 56 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                                                               Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(94);
                    __builder3.AddAttribute(95, "Text", "Formacos");
                    __builder3.AddAttribute(96, "Path", "formacos");
                    __builder3.AddAttribute(97, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 58 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                                                       Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(98, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(99);
                    __builder3.AddAttribute(100, "Text", "Indisponibilidades");
                    __builder3.AddAttribute(101, "Path", "indisponibilidades");
                    __builder3.AddAttribute(102, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 60 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                                                                           Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(103, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(104);
                    __builder3.AddAttribute(105, "Text", "Instituicos");
                    __builder3.AddAttribute(106, "Path", "instituicos");
                    __builder3.AddAttribute(107, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 62 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                                                             Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(108, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(109);
                    __builder3.AddAttribute(110, "Text", "Laboratorios");
                    __builder3.AddAttribute(111, "Path", "laboratorios");
                    __builder3.AddAttribute(112, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 64 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                                                               Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(113, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(114);
                    __builder3.AddAttribute(115, "Text", "Pedidos");
                    __builder3.AddAttribute(116, "Path", "pedidos");
                    __builder3.AddAttribute(117, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 66 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                                                     Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(118, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(119);
                    __builder3.AddAttribute(120, "Text", "Pessoas");
                    __builder3.AddAttribute(121, "Path", "pessoas");
                    __builder3.AddAttribute(122, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 68 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                                                     Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(123, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(124);
                    __builder3.AddAttribute(125, "Text", "Produtos");
                    __builder3.AddAttribute(126, "Path", "produtos");
                    __builder3.AddAttribute(127, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 70 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                                                       Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(128, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(129);
                    __builder3.AddAttribute(130, "Text", "Recursos");
                    __builder3.AddAttribute(131, "Path", "recursos");
                    __builder3.AddAttribute(132, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 72 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                                                       Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(133, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(134);
                    __builder3.AddAttribute(135, "Text", "Recursos Humanos");
                    __builder3.AddAttribute(136, "Path", "recursos-humanos");
                    __builder3.AddAttribute(137, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 74 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                                                                       Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(138, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(139);
                    __builder3.AddAttribute(140, "Text", "Servicos");
                    __builder3.AddAttribute(141, "Path", "servicos");
                    __builder3.AddAttribute(142, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 76 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                                                                       Security.IsInRole(new string[]{"Authenticated"})

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(143, "\n      ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(144, "\n  ");
            }
            ));
            __builder.AddComponentReferenceCapture(145, (__value) => {
#line 48 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Shared\MainLayout.razor"
                     sidebar0 = (Radzen.Blazor.RadzenSidebar)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(146, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenFooter>(147);
            __builder.AddAttribute(148, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(149, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(150);
                __builder2.AddAttribute(151, "Text", "c4g, Copyright Ⓒ 2020");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(152, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591