#pragma checksum "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "060582a4dbf63a377d8d0f2fc3be660aab83c124"
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
#line 5 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
using C4G.Models.C4G;

#line default
#line hidden
#line 8 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
using C4G.Models;

#line default
#line hidden
#line 10 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 11 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-dado")]
    public partial class AddDado : C4G.Pages.AddDadoComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<C4G.Models.C4G.Dado>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<C4G.Models.C4G.Dado>(
#line 17 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                   dado

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                                    dado != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<C4G.Models.C4G.Dado>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<C4G.Models.C4G.Dado>(this, 
#line 17 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
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
                    __builder3.AddAttribute(24, "Text", "Designacao Pt");
                    __builder3.AddAttribute(25, "Component", "designacao_PT");
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
#line 25 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(34, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(35, "Name", "Designacao_PT");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 25 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                                                                                 dado.designacao_PT

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dado.designacao_PT = __value, dado.designacao_PT))));
                    __builder3.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dado.designacao_PT));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(40);
                    __builder3.AddAttribute(41, "Component", "Designacao_PT");
                    __builder3.AddAttribute(42, "Text", "designacao_PT is required");
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
                    __builder3.AddAttribute(55, "Text", "Designacao En");
                    __builder3.AddAttribute(56, "Component", "designacao_EN");
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
#line 37 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(65, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(66, "Name", "Designacao_EN");
                    __builder3.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 37 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                                                                                 dado.designacao_EN

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dado.designacao_EN = __value, dado.designacao_EN))));
                    __builder3.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dado.designacao_EN));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(71);
                    __builder3.AddAttribute(72, "Component", "Designacao_EN");
                    __builder3.AddAttribute(73, "Text", "designacao_EN is required");
                    __builder3.AddAttribute(74, "style", "position: absolute");
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
                    __builder3.AddAttribute(86, "Text", "Webpage");
                    __builder3.AddAttribute(87, "Component", "webpage");
                    __builder3.AddAttribute(88, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\n              ");
                    __builder3.OpenElement(91, "div");
                    __builder3.AddAttribute(92, "class", "col-md-9");
                    __builder3.AddMarkupContent(93, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(94);
                    __builder3.AddAttribute(95, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 49 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                          30

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(96, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(97, "Name", "Webpage");
                    __builder3.AddAttribute(98, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 49 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                                                                                 dado.webpage

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(99, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dado.webpage = __value, dado.webpage))));
                    __builder3.AddAttribute(100, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dado.webpage));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(102);
                    __builder3.AddAttribute(103, "Component", "Webpage");
                    __builder3.AddAttribute(104, "Text", "webpage is required");
                    __builder3.AddAttribute(105, "style", "position: absolute");
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
                    __builder3.AddAttribute(117, "Text", "Observacoes");
                    __builder3.AddAttribute(118, "Component", "observacoes");
                    __builder3.AddAttribute(119, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(120, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(121, "\n              ");
                    __builder3.OpenElement(122, "div");
                    __builder3.AddAttribute(123, "class", "col-md-9");
                    __builder3.AddMarkupContent(124, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(125);
                    __builder3.AddAttribute(126, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 61 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                          1000

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(127, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(128, "Name", "Observacoes");
                    __builder3.AddAttribute(129, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 61 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                                                                                   dado.observacoes

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(130, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dado.observacoes = __value, dado.observacoes))));
                    __builder3.AddAttribute(131, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => dado.observacoes));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(132, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(133);
                    __builder3.AddAttribute(134, "Component", "Observacoes");
                    __builder3.AddAttribute(135, "Text", "observacoes is required");
                    __builder3.AddAttribute(136, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(137, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(138, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(139, "\n            ");
                    __builder3.OpenElement(140, "div");
                    __builder3.AddAttribute(141, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(142, "class", "row");
                    __builder3.AddMarkupContent(143, "\n              ");
                    __builder3.OpenElement(144, "div");
                    __builder3.AddAttribute(145, "class", "col-md-3");
                    __builder3.AddMarkupContent(146, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(147);
                    __builder3.AddAttribute(148, "Text", "Custo Unitario");
                    __builder3.AddAttribute(149, "Component", "custo_unitario");
                    __builder3.AddAttribute(150, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(151, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(152, "\n              ");
                    __builder3.OpenElement(153, "div");
                    __builder3.AddAttribute(154, "class", "col-md-9");
                    __builder3.AddMarkupContent(155, "\n                ");
                    __Blazor.C4G.Pages.AddDado.TypeInference.CreateRadzenNumeric_0(__builder3, 156, 157, "display: block; width: 100%", 158, "Custo_unitario", 159, 
#line 73 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                                                                  dado.custo_unitario

#line default
#line hidden
                    , 160, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dado.custo_unitario = __value, dado.custo_unitario)), 161, () => dado.custo_unitario);
                    __builder3.AddMarkupContent(162, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(163);
                    __builder3.AddAttribute(164, "Component", "Custo_unitario");
                    __builder3.AddAttribute(165, "Text", "custo_unitario is required");
                    __builder3.AddAttribute(166, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(167, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(168, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(169, "\n            ");
                    __builder3.OpenElement(170, "div");
                    __builder3.AddAttribute(171, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(172, "class", "row");
                    __builder3.AddMarkupContent(173, "\n              ");
                    __builder3.OpenElement(174, "div");
                    __builder3.AddAttribute(175, "class", "col-md-3");
                    __builder3.AddMarkupContent(176, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(177);
                    __builder3.AddAttribute(178, "Text", "Laboratorio");
                    __builder3.AddAttribute(179, "Component", "id_lab");
                    __builder3.AddAttribute(180, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(181, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(182, "\n              ");
                    __builder3.OpenElement(183, "div");
                    __builder3.AddAttribute(184, "class", "col-md-9");
                    __builder3.AddMarkupContent(185, "\n                ");
                    __Blazor.C4G.Pages.AddDado.TypeInference.CreateRadzenDropDown_1(__builder3, 186, 187, 
#line 85 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                       getLaboratoriosResult

#line default
#line hidden
                    , 188, "designacao", 189, "id_lab", 190, "Choose Laboratorio", 191, "display: block; width: 100%", 192, "Id_lab", 193, 
#line 85 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                                                                                                                                                                                   dado.id_lab

#line default
#line hidden
                    , 194, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dado.id_lab = __value, dado.id_lab)), 195, () => dado.id_lab);
                    __builder3.AddMarkupContent(196, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(197);
                    __builder3.AddAttribute(198, "Component", "Id_lab");
                    __builder3.AddAttribute(199, "Text", "id_lab is required");
                    __builder3.AddAttribute(200, "style", "position: absolute");
                    __builder3.AddAttribute(201, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 87 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                                                                                                               0

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(202, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(203, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(204, "\n            ");
                    __builder3.OpenElement(205, "div");
                    __builder3.AddAttribute(206, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(207, "class", "row");
                    __builder3.AddMarkupContent(208, "\n              ");
                    __builder3.OpenElement(209, "div");
                    __builder3.AddAttribute(210, "class", "col-md-3");
                    __builder3.AddMarkupContent(211, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(212);
                    __builder3.AddAttribute(213, "Text", "Recurso");
                    __builder3.AddAttribute(214, "Component", "id_recursos");
                    __builder3.AddAttribute(215, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(216, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(217, "\n              ");
                    __builder3.OpenElement(218, "div");
                    __builder3.AddAttribute(219, "class", "col-md-9");
                    __builder3.AddMarkupContent(220, "\n                ");
                    __Blazor.C4G.Pages.AddDado.TypeInference.CreateRadzenDropDown_2(__builder3, 221, 222, 
#line 97 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                       getRecursosResult

#line default
#line hidden
                    , 223, "id_recursos", 224, "id_recursos", 225, "Choose Recurso", 226, "display: block; width: 100%", 227, "Id_recursos", 228, 
#line 97 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                                                                                                                                                                                 dado.id_recursos

#line default
#line hidden
                    , 229, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dado.id_recursos = __value, dado.id_recursos)), 230, () => dado.id_recursos);
                    __builder3.AddMarkupContent(231, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(232);
                    __builder3.AddAttribute(233, "Component", "Id_recursos");
                    __builder3.AddAttribute(234, "Text", "id_recursos is required");
                    __builder3.AddAttribute(235, "style", "position: absolute");
                    __builder3.AddAttribute(236, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 99 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                                                                                                                         0

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(237, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(238, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(239, "\n            ");
                    __builder3.OpenElement(240, "div");
                    __builder3.AddAttribute(241, "class", "row");
                    __builder3.AddMarkupContent(242, "\n              ");
                    __builder3.OpenElement(243, "div");
                    __builder3.AddAttribute(244, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(245, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(246);
                    __builder3.AddAttribute(247, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 105 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(248, "Icon", "save");
                    __builder3.AddAttribute(249, "Text", "Save");
                    __builder3.AddAttribute(250, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 105 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(251, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(252);
                    __builder3.AddAttribute(253, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 107 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(254, "Text", "Cancel");
                    __builder3.AddAttribute(255, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 107 "C:\Users\BreiaLopes\Documents\guilherme\trabalho_bd_programa\server\Pages\AddDado.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(256, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(257, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(258, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(259, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(260, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(261, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.C4G.Pages.AddDado
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenNumeric_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
