#pragma checksum "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6c6d0008512aacc39d1dc44816d52eb9825ce3d"
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
#line 5 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor"
using C4G.Models.C4G;

#line default
#line hidden
#line 8 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor"
using C4G.Models;

#line default
#line hidden
#line 10 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 11 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-instituico")]
    public partial class AddInstituico : C4G.Pages.AddInstituicoComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<C4G.Models.C4G.Instituico>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<C4G.Models.C4G.Instituico>(
#line 17 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor"
                                   instituico

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor"
                                                          instituico != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<C4G.Models.C4G.Instituico>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<C4G.Models.C4G.Instituico>(this, 
#line 17 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor"
                                                                                                                          Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\n              ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                    __builder3.AddAttribute(24, "Text", "Designacao");
                    __builder3.AddAttribute(25, "Component", "designacao");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(32);
                    __builder3.AddAttribute(33, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 25 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(34, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(35, "Name", "Designacao");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 25 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor"
                                                                                                 instituico.designacao

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => instituico.designacao = __value, instituico.designacao))));
                    __builder3.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => instituico.designacao));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(40);
                    __builder3.AddAttribute(41, "Component", "Designacao");
                    __builder3.AddAttribute(42, "Text", "designacao is required");
                    __builder3.AddAttribute(43, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\n            ");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(49, "class", "row");
                    __builder3.AddMarkupContent(50, "\n              ");
                    __builder3.OpenElement(51, "div");
                    __builder3.AddAttribute(52, "class", "col-md-3");
                    __builder3.AddMarkupContent(53, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(54);
                    __builder3.AddAttribute(55, "Text", "Acronimo");
                    __builder3.AddAttribute(56, "Component", "acronimo");
                    __builder3.AddAttribute(57, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(59, "\n              ");
                    __builder3.OpenElement(60, "div");
                    __builder3.AddAttribute(61, "class", "col-md-9");
                    __builder3.AddMarkupContent(62, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(63);
                    __builder3.AddAttribute(64, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 37 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor"
                                          10

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(65, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(66, "Name", "Acronimo");
                    __builder3.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 37 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor"
                                                                                                 instituico.acronimo

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => instituico.acronimo = __value, instituico.acronimo))));
                    __builder3.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => instituico.acronimo));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(71);
                    __builder3.AddAttribute(72, "Component", "Acronimo");
                    __builder3.AddAttribute(73, "Text", "acronimo is required");
                    __builder3.AddAttribute(74, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(76, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\n            ");
                    __builder3.OpenElement(78, "div");
                    __builder3.AddAttribute(79, "class", "row");
                    __builder3.AddMarkupContent(80, "\n              ");
                    __builder3.OpenElement(81, "div");
                    __builder3.AddAttribute(82, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(83, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(84);
                    __builder3.AddAttribute(85, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 45 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(86, "Icon", "save");
                    __builder3.AddAttribute(87, "Text", "Save");
                    __builder3.AddAttribute(88, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 45 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(90);
                    __builder3.AddAttribute(91, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 47 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(92, "Text", "Cancel");
                    __builder3.AddAttribute(93, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 47 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddInstituico.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(94, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(95, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(96, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(97, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591