#pragma checksum "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bb04ec284efb61ef68da21be871bfa19cf2a187"
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
#line 5 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
using C4G.Models.C4G;

#line default
#line hidden
#line 8 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
using C4G.Models;

#line default
#line hidden
#line 10 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 11 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-laboratorio")]
    public partial class AddLaboratorio : C4G.Pages.AddLaboratorioComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<C4G.Models.C4G.Laboratorio>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<C4G.Models.C4G.Laboratorio>(
#line 17 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
                                   laboratorio

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
                                                                                              laboratorio != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<C4G.Models.C4G.Laboratorio>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<C4G.Models.C4G.Laboratorio>(this, 
#line 17 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
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
                    __builder3.AddAttribute(24, "Component", "designacao");
                    __builder3.AddAttribute(25, "style", "width: 100%");
                    __builder3.AddAttribute(26, "Text", "Designacao");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(32);
                    __builder3.AddAttribute(33, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 25 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(34, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(35, "Name", "Designacao");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 25 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
                                                                                                 laboratorio.designacao

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => laboratorio.designacao = __value, laboratorio.designacao))));
                    __builder3.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => laboratorio.designacao));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(40);
                    __builder3.AddAttribute(41, "Component", "Designacao");
                    __builder3.AddAttribute(42, "style", "position: absolute");
                    __builder3.AddAttribute(43, "Text", "designacao is required");
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
                    __builder3.AddAttribute(55, "Component", "acronimo");
                    __builder3.AddAttribute(56, "style", "width: 100%");
                    __builder3.AddAttribute(57, "Text", "Acronimo");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(59, "\n              ");
                    __builder3.OpenElement(60, "div");
                    __builder3.AddAttribute(61, "class", "col-md-9");
                    __builder3.AddMarkupContent(62, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(63);
                    __builder3.AddAttribute(64, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 37 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
                                          10

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(65, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(66, "Name", "Acronimo");
                    __builder3.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 37 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
                                                                                                 laboratorio.acronimo

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => laboratorio.acronimo = __value, laboratorio.acronimo))));
                    __builder3.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => laboratorio.acronimo));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(71);
                    __builder3.AddAttribute(72, "Component", "Acronimo");
                    __builder3.AddAttribute(73, "style", "position: absolute");
                    __builder3.AddAttribute(74, "Text", "acronimo is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(76, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\n            ");
                    __builder3.OpenElement(78, "div");
                    __builder3.AddAttribute(79, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(80, "class", "row");
                    __builder3.AddMarkupContent(81, "\n              ");
                    __builder3.OpenElement(82, "div");
                    __builder3.AddAttribute(83, "class", "col-md-3");
                    __builder3.AddMarkupContent(84, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(85);
                    __builder3.AddAttribute(86, "Component", "grupo");
                    __builder3.AddAttribute(87, "style", "width: 100%");
                    __builder3.AddAttribute(88, "Text", "Grupo");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\n              ");
                    __builder3.OpenElement(91, "div");
                    __builder3.AddAttribute(92, "class", "col-md-9");
                    __builder3.AddMarkupContent(93, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(94);
                    __builder3.AddAttribute(95, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 49 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(96, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(97, "Name", "Grupo");
                    __builder3.AddAttribute(98, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 49 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
                                                                                                 laboratorio.grupo

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(99, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => laboratorio.grupo = __value, laboratorio.grupo))));
                    __builder3.AddAttribute(100, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => laboratorio.grupo));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(102);
                    __builder3.AddAttribute(103, "Component", "Grupo");
                    __builder3.AddAttribute(104, "style", "position: absolute");
                    __builder3.AddAttribute(105, "Text", "grupo is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(106, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(107, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(108, "\n            ");
                    __builder3.OpenElement(109, "div");
                    __builder3.AddAttribute(110, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(111, "class", "row");
                    __builder3.AddMarkupContent(112, "\n              ");
                    __builder3.OpenElement(113, "div");
                    __builder3.AddAttribute(114, "class", "col-md-3");
                    __builder3.AddMarkupContent(115, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(116);
                    __builder3.AddAttribute(117, "Component", "id_instituicao");
                    __builder3.AddAttribute(118, "style", "width: 100%");
                    __builder3.AddAttribute(119, "Text", "Instituico");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(120, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(121, "\n              ");
                    __builder3.OpenElement(122, "div");
                    __builder3.AddAttribute(123, "class", "col-md-9");
                    __builder3.AddMarkupContent(124, "\n                ");
                    __Blazor.C4G.Pages.AddLaboratorio.TypeInference.CreateRadzenDropDown_0(__builder3, 125, 126, 
#line 61 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
                                       getInstituicosResult

#line default
#line hidden
                    , 127, "Choose Instituico", 128, "display: block; width: 100%", 129, "designacao", 130, "id_instituicao", 131, "Id_instituicao", 132, 
#line 61 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
                                                                                                                                                                          laboratorio.id_instituicao

#line default
#line hidden
                    , 133, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => laboratorio.id_instituicao = __value, laboratorio.id_instituicao)), 134, () => laboratorio.id_instituicao);
                    __builder3.AddMarkupContent(135, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(136);
                    __builder3.AddAttribute(137, "Component", "Id_instituicao");
                    __builder3.AddAttribute(138, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 63 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
                                                                                  0

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(139, "style", "position: absolute");
                    __builder3.AddAttribute(140, "Text", "id_instituicao is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(141, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(142, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(143, "\n            ");
                    __builder3.OpenElement(144, "div");
                    __builder3.AddAttribute(145, "class", "row");
                    __builder3.AddMarkupContent(146, "\n              ");
                    __builder3.OpenElement(147, "div");
                    __builder3.AddAttribute(148, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(149, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(150);
                    __builder3.AddAttribute(151, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 69 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(152, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 69 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(153, "Icon", "save");
                    __builder3.AddAttribute(154, "Text", "Save");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(155, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(156);
                    __builder3.AddAttribute(157, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 71 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(158, "Text", "Cancel");
                    __builder3.AddAttribute(159, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 71 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddLaboratorio.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(160, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(161, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(162, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(163, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(164, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(165, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.C4G.Pages.AddLaboratorio
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, System.Object __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Placeholder", __arg1);
        __builder.AddAttribute(__seq2, "style", __arg2);
        __builder.AddAttribute(__seq3, "TextProperty", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
