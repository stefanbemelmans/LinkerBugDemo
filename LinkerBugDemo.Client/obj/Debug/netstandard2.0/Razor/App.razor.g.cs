#pragma checksum "C:\Users\stack\gitrepos\LinkerBugDemo\LinkerBugDemo.Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fac2356b676507bf22bef6294028940bc3998737"
// <auto-generated/>
#pragma warning disable 1591
namespace LinkerBugDemo.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\stack\gitrepos\LinkerBugDemo\LinkerBugDemo.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\stack\gitrepos\LinkerBugDemo\LinkerBugDemo.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\stack\gitrepos\LinkerBugDemo\LinkerBugDemo.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "C:\Users\stack\gitrepos\LinkerBugDemo\LinkerBugDemo.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\stack\gitrepos\LinkerBugDemo\LinkerBugDemo.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\stack\gitrepos\LinkerBugDemo\LinkerBugDemo.Client\_Imports.razor"
using LinkerBugDemo.Client;

#line default
#line hidden
#line 7 "C:\Users\stack\gitrepos\LinkerBugDemo\LinkerBugDemo.Client\_Imports.razor"
using LinkerBugDemo.Client.Shared;

#line default
#line hidden
    public class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#line 1 "C:\Users\stack\gitrepos\LinkerBugDemo\LinkerBugDemo.Client\App.razor"
                     typeof(Program).Assembly

#line default
#line hidden
            ));
            builder.AddAttribute(2, "NotFoundContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(3, "\r\n        ");
                builder2.AddMarkupContent(4, "<p>Sorry, there\'s nothing at this address.</p>\r\n    ");
            }
            ));
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
