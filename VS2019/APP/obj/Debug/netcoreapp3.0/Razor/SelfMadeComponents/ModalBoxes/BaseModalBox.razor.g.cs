#pragma checksum "C:\Users\RP\METAMORFF\VS2019\APP\SelfMadeComponents\ModalBoxes\BaseModalBox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f40d0aeb46bd8d7798673549cb0a6a7527f98eb"
// <auto-generated/>
#pragma warning disable 1591
namespace APP.SelfMadeComponents.ModalBoxes
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
    public partial class BaseModalBox : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "HiddenModalBox2");
            __builder.AddMarkupContent(2, "    \r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "ModalBox");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "UpperPart");
            __builder.AddMarkupContent(8, "\r\n            <div class=\"icon\"></div>\r\n            ");
            __builder.OpenElement(9, "p");
            __builder.AddAttribute(10, "class", "TituloJanela");
            __builder.AddContent(11, 
#nullable restore
#line 5 "C:\Users\RP\METAMORFF\VS2019\APP\SelfMadeComponents\ModalBoxes\BaseModalBox.razor"
                                     TituloJanela

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            <div class=\"uselessDiv\"></div>\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "CloseButton");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\RP\METAMORFF\VS2019\APP\SelfMadeComponents\ModalBoxes\BaseModalBox.razor"
                                               FecharModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "div");
            __builder.OpenComponent<APP.SelfMadeComponents.icons.Cancel>(18);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "MainContent");
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.AddContent(25, 
#nullable restore
#line 12 "C:\Users\RP\METAMORFF\VS2019\APP\SelfMadeComponents\ModalBoxes\BaseModalBox.razor"
         ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    <div class=\"BottomButtonsContainer\"></div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\RP\METAMORFF\VS2019\APP\SelfMadeComponents\ModalBoxes\BaseModalBox.razor"
       

    [CascadingParameter]public MainLayout MainLayout{get; set;}

    private void FecharModal(){
        MainLayout.FecharModal();
    }

    [Parameter]
    public string TituloJanela{get;set;}

    [Parameter]
    public string TipoJanela{get;set;}

    [Parameter]
    public RenderFragment ChildContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
