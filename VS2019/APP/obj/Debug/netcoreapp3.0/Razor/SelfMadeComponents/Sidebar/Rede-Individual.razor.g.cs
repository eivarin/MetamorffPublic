#pragma checksum "C:\Users\RP\METAMORFF\VS2019\APP\SelfMadeComponents\Sidebar\Rede-Individual.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5a094d0cd78e4721963c97a33666641de73d7a5"
// <auto-generated/>
#pragma warning disable 1591
namespace APP.SelfMadeComponents.Sidebar
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\RP\METAMORFF\VS2019\APP\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RP\METAMORFF\VS2019\APP\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\RP\METAMORFF\VS2019\APP\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\RP\METAMORFF\VS2019\APP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\RP\METAMORFF\VS2019\APP\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\RP\METAMORFF\VS2019\APP\_Imports.razor"
using APP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\RP\METAMORFF\VS2019\APP\_Imports.razor"
using APP.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\RP\METAMORFF\VS2019\APP\_Imports.razor"
using APP.SelfMadeComponents.Sidebar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\RP\METAMORFF\VS2019\APP\_Imports.razor"
using APP.SelfMadeComponents.icons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\RP\METAMORFF\VS2019\APP\_Imports.razor"
using APP.SelfMadeComponents.ModalBoxes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\RP\METAMORFF\VS2019\APP\_Imports.razor"
using APP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\RP\METAMORFF\VS2019\APP\_Imports.razor"
using BlazorStyled;

#line default
#line hidden
#nullable disable
    public partial class Rede_Individual : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "rede-individual");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"HoverDiv\">\r\n        \r\n    </div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "mainDiv");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "Estado");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "style", 
#nullable restore
#line 7 "C:\Users\RP\METAMORFF\VS2019\APP\SelfMadeComponents\Sidebar\Rede-Individual.razor"
                         Estilo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "NomeRede");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "p");
            __builder.AddContent(18, 
#nullable restore
#line 10 "C:\Users\RP\METAMORFF\VS2019\APP\SelfMadeComponents\Sidebar\Rede-Individual.razor"
                Rede.NomeRede

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "opcoesbtn");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "button");
            __builder.OpenComponent<APP.SelfMadeComponents.icons.TogllingArrow>(25);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "Net_Options_Sub_Menu");
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "div");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "opcao1");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\RP\METAMORFF\VS2019\APP\SelfMadeComponents\Sidebar\Rede-Individual.razor"
                                          EventModalBox

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            <div class=\"opcao2\"></div>\r\n            <div class=\"opcao3\"></div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\RP\METAMORFF\VS2019\APP\SelfMadeComponents\Sidebar\Rede-Individual.razor"
       

    [CascadingParameter]public MainLayout MainLayout{get; set;}


    [Parameter]
    public RedeModel Rede {get;set;}
    
    private string Estilo;


    private void EventModalBox() {
        MainLayout.AbrirExampleModal();
    }

    protected override void OnInitialized()
    {
        switch (Rede.Status)
        {
            case(1):
                Estilo = "background-color: red;";
                break;
            case(2):
                Estilo = "background-color: yellow;";
                break;
            case(3):
                Estilo = "background-color: green;";
                break;
            default:
                break;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
