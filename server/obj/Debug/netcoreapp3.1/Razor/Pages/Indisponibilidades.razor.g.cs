#pragma checksum "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d379d91205f7a29871d24128d0b980a28cbfedc"
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
#line 5 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
using C4G.Models.C4G;

#line default
#line hidden
#line 8 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
using C4G.Models;

#line default
#line hidden
#line 10 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 11 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/indisponibilidades")]
    public partial class Indisponibilidades : C4G.Pages.IndisponibilidadesComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Indisponibilidades");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "Icon", "add_circle_outline");
                __builder2.AddAttribute(16, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(17, "Text", "Add");
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 19 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<C4G.Models.C4G.Indisponibilidade>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<C4G.Models.C4G.Indisponibilidade>>(
#line 21 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
                                                                                                     getIndisponibilidadesResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<C4G.Models.C4G.Indisponibilidade>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<C4G.Models.C4G.Indisponibilidade>(this, 
#line 21 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
                                                                                                                                                                                       Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<C4G.Models.C4G.Indisponibilidade>>(28);
                    __builder3.AddAttribute(29, "Property", "start_date");
                    __builder3.AddAttribute(30, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(31, "Title", "Start Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<C4G.Models.C4G.Indisponibilidade>>(33);
                    __builder3.AddAttribute(34, "Property", "end_date");
                    __builder3.AddAttribute(35, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(36, "Title", "End Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<C4G.Models.C4G.Indisponibilidade>>(38);
                    __builder3.AddAttribute(39, "Property", "id_pedido");
                    __builder3.AddAttribute(40, "SortProperty", "Pedido.id_pedido");
                    __builder3.AddAttribute(41, "FilterProperty", "Pedido.id_pedido");
                    __builder3.AddAttribute(42, "Title", "Pedido");
                    __builder3.AddAttribute(43, "Template", (Microsoft.AspNetCore.Components.RenderFragment<C4G.Models.C4G.Indisponibilidade>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(44, "\n              ");
                        __builder4.AddContent(45, 
#line 29 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
                data.Pedido?.id_pedido

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(46, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<C4G.Models.C4G.Indisponibilidade>>(48);
                    __builder3.AddAttribute(49, "Property", "id_recursos");
                    __builder3.AddAttribute(50, "SortProperty", "Recurso.id_recursos");
                    __builder3.AddAttribute(51, "FilterProperty", "Recurso.id_recursos");
                    __builder3.AddAttribute(52, "Title", "Recurso");
                    __builder3.AddAttribute(53, "Template", (Microsoft.AspNetCore.Components.RenderFragment<C4G.Models.C4G.Indisponibilidade>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(54, "\n              ");
                        __builder4.AddContent(55, 
#line 34 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
                data.Recurso?.id_recursos

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(56, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<C4G.Models.C4G.Indisponibilidade>>(58);
                    __builder3.AddAttribute(59, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 37 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
                                                                                   false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(60, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 37 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
                                                                                                    false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(61, "Width", "70px");
                    __builder3.AddAttribute(62, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 37 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
                                                                                                                                   TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(63, "Template", (Microsoft.AspNetCore.Components.RenderFragment<C4G.Models.C4G.Indisponibilidade>)((c4GModelsC4GIndisponibilidade) => (__builder4) => {
                        __builder4.AddMarkupContent(64, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(65);
                        __builder4.AddAttribute(66, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 39 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(67, "Icon", "close");
                        __builder4.AddAttribute(68, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 39 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(69, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 39 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, c4GModelsC4GIndisponibilidade)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(70, "onclick", 
#line 39 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
                                                                                                                                                                                                             true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(71, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(73, (__value) => {
#line 21 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\Indisponibilidades.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<C4G.Models.C4G.Indisponibilidade>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
