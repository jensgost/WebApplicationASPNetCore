#pragma checksum "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCore\WebApplicationASPNetCore\Views\Events\MyEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddb95dca2bd1f85bcd06404a90c86ce78320a020"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_MyEvents), @"mvc.1.0.view", @"/Views/Events/MyEvents.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCore\WebApplicationASPNetCore\Views\_ViewImports.cshtml"
using WebApplicationASPNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCore\WebApplicationASPNetCore\Views\_ViewImports.cshtml"
using WebApplicationASPNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddb95dca2bd1f85bcd06404a90c86ce78320a020", @"/Views/Events/MyEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6941220ac1c9323fd7b4f9fe7a2857eaefe9617e", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_MyEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplicationASPNetCore.Controllers.AttendeesController>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>My Events</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCore\WebApplicationASPNetCore\Views\Events\MyEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.AttendeeEvents[0].Event.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCore\WebApplicationASPNetCore\Views\Events\MyEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.AttendeeEvents[0].Event.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCore\WebApplicationASPNetCore\Views\Events\MyEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.AttendeeEvents[0].Event.Place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCore\WebApplicationASPNetCore\Views\Events\MyEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.AttendeeEvents[0].Event.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCore\WebApplicationASPNetCore\Views\Events\MyEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.AttendeeEvents[0].Event.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCore\WebApplicationASPNetCore\Views\Events\MyEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.AttendeeEvents[0].Event.SpotsAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCore\WebApplicationASPNetCore\Views\Events\MyEvents.cshtml"
         foreach (var item in Model.AttendeeEvents)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCore\WebApplicationASPNetCore\Views\Events\MyEvents.cshtml"
               Write(Html.DisplayFor(modelItem => item.Event.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCore\WebApplicationASPNetCore\Views\Events\MyEvents.cshtml"
               Write(Html.DisplayFor(modelItem => item.Event.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCore\WebApplicationASPNetCore\Views\Events\MyEvents.cshtml"
               Write(Html.DisplayFor(modelItem => item.Event.Place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCore\WebApplicationASPNetCore\Views\Events\MyEvents.cshtml"
               Write(Html.DisplayFor(modelItem => item.Event.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCore\WebApplicationASPNetCore\Views\Events\MyEvents.cshtml"
               Write(Html.DisplayFor(modelItem => item.Event.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCore\WebApplicationASPNetCore\Views\Events\MyEvents.cshtml"
               Write(Html.DisplayFor(modelItem => item.Event.SpotsAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCore\WebApplicationASPNetCore\Views\Events\MyEvents.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplicationASPNetCore.Controllers.AttendeesController> Html { get; private set; }
    }
}
#pragma warning restore 1591
