#pragma checksum "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddRecurso.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29c8d98b24c87a045803c11c414ed71d0b919c5a"
// <auto-generated/>
#pragma warning disable 1591
namespace C4G.Pages
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
#line 5 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddRecurso.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddRecurso.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddRecurso.razor"
using C4G.Models.C4G;

#line default
#line hidden
#line 8 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddRecurso.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddRecurso.razor"
using C4G.Models;

#line default
#line hidden
#line 10 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddRecurso.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 11 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddRecurso.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-recurso")]
    public partial class AddRecurso : C4G.Pages.AddRecursoComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<C4G.Models.C4G.Recurso>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<C4G.Models.C4G.Recurso>(
#line 17 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddRecurso.razor"
                                   recurso

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddRecurso.razor"
                                                       recurso != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<C4G.Models.C4G.Recurso>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<C4G.Models.C4G.Recurso>(this, 
#line 17 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddRecurso.razor"
                                                                                                                 Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "class", "row");
                    __builder3.AddMarkupContent(18, "\n              ");
                    __builder3.OpenElement(19, "div");
                    __builder3.AddAttribute(20, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(21, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(22);
                    __builder3.AddAttribute(23, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 21 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddRecurso.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(24, "Icon", "save");
                    __builder3.AddAttribute(25, "Text", "Save");
                    __builder3.AddAttribute(26, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 21 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddRecurso.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(28);
                    __builder3.AddAttribute(29, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 23 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddRecurso.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(30, "Text", "Cancel");
                    __builder3.AddAttribute(31, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 23 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddRecurso.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(33, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
