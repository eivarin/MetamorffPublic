#pragma checksum "C:\Users\RP\METAMORFF\VS2019\APP\SelfMadeComponents\Sidebar\IconMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26b541e3f947e27a493da017f37813a5ece4dd65"
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
    public partial class IconMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""icon-menu"">
    <div id=""options-div""><div>
        <div id=""bloco1"" class=""bloco"">1</div>
        <div id=""bloco2"" class=""bloco"">2</div>
        <div id=""bloco3"" class=""bloco"">3</div>
    </div></div>
    <div class=""icon-holder"">
        <a class=""icon-btn"" onclick=""MenuUpOrDown(1)"">

        </a>
        <a class=""icon-btn"" onclick=""MenuUpOrDown(2)"">

        </a>
        <a class=""icon-btn"" onclick=""MenuUpOrDown(3)"">

        </a>
    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager MyNavigationManager { get; set; }
    }
}
#pragma warning restore 1591
