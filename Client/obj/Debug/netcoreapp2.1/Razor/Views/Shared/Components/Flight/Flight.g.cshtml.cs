#pragma checksum "E:\NebbAirline\Client\Views\Shared\Components\Flight\Flight.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3402e598ecf1369c8f1528cc4f1f535ec0919bb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Flight_Flight), @"mvc.1.0.view", @"/Views/Shared/Components/Flight/Flight.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Flight/Flight.cshtml", typeof(AspNetCore.Views_Shared_Components_Flight_Flight))]
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
#line 1 "E:\NebbAirline\Client\Views\_ViewImports.cshtml"
using Client;

#line default
#line hidden
#line 2 "E:\NebbAirline\Client\Views\_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
#line 3 "E:\NebbAirline\Client\Views\_ViewImports.cshtml"
using Client.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3402e598ecf1369c8f1528cc4f1f535ec0919bb4", @"/Views/Shared/Components/Flight/Flight.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c0e4323e51ddd3248e203e27f1781b39e71924", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Flight_Flight : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Client.Models.Flight>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/blue-arrow.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\NebbAirline\Client\Views\Shared\Components\Flight\Flight.cshtml"
  
    ViewData["Title"] = "Flight Details";

#line default
#line hidden
            BeginContext(140, 163, true);
            WriteLiteral("\r\n<div class=\"flight-container col-lg-6 col-md-6 col-sm-12\">\r\n    <div class=\"top-look\">\r\n        <div class=\"display-label\">\r\n            <span class=\"left-span\">");
            EndContext();
            BeginContext(304, 42, false);
#line 10 "E:\NebbAirline\Client\Views\Shared\Components\Flight\Flight.cshtml"
                               Write(Html.DisplayNameFor(model => model.Origin));

#line default
#line hidden
            EndContext();
            BeginContext(346, 46, true);
            WriteLiteral("</span>\r\n            <span class=\"right-span\">");
            EndContext();
            BeginContext(393, 47, false);
#line 11 "E:\NebbAirline\Client\Views\Shared\Components\Flight\Flight.cshtml"
                                Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(440, 98, true);
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"display-field\">\r\n            <span class=\"left-span\">");
            EndContext();
            BeginContext(539, 38, false);
#line 14 "E:\NebbAirline\Client\Views\Shared\Components\Flight\Flight.cshtml"
                               Write(Html.DisplayFor(model => model.Origin));

#line default
#line hidden
            EndContext();
            BeginContext(577, 57, true);
            WriteLiteral("</span>\r\n            <div class=\"icon\">\r\n                ");
            EndContext();
            BeginContext(634, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "502d739a352741b6ba62bb75b6549622", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(671, 59, true);
            WriteLiteral("\r\n            </div>\r\n            <span class=\"right-span\">");
            EndContext();
            BeginContext(731, 43, false);
#line 18 "E:\NebbAirline\Client\Views\Shared\Components\Flight\Flight.cshtml"
                                Write(Html.DisplayFor(model => model.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(774, 141, true);
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n    <div class=\"bottom-look\">\r\n        <div class=\"display-label\">\r\n            <span class=\"left-span\">");
            EndContext();
            BeginContext(916, 45, false);
#line 23 "E:\NebbAirline\Client\Views\Shared\Components\Flight\Flight.cshtml"
                               Write(Html.DisplayNameFor(model => model.Departure));

#line default
#line hidden
            EndContext();
            BeginContext(961, 46, true);
            WriteLiteral("</span>\r\n            <span class=\"right-span\">");
            EndContext();
            BeginContext(1008, 46, false);
#line 24 "E:\NebbAirline\Client\Views\Shared\Components\Flight\Flight.cshtml"
                                Write(Html.DisplayNameFor(model => model.FlightCode));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 103, true);
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"display-field\">\r\n            <span class=\"left-span date\">");
            EndContext();
            BeginContext(1158, 51, false);
#line 27 "E:\NebbAirline\Client\Views\Shared\Components\Flight\Flight.cshtml"
                                    Write(dateTimeFormatter.GetFormattedDate(Model.Departure));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 46, true);
            WriteLiteral("</span>\r\n            <span class=\"right-span\">");
            EndContext();
            BeginContext(1256, 42, false);
#line 28 "E:\NebbAirline\Client\Views\Shared\Components\Flight\Flight.cshtml"
                                Write(Html.DisplayFor(model => model.FlightCode));

#line default
#line hidden
            EndContext();
            BeginContext(1298, 98, true);
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"display-field\">\r\n            <span class=\"left-span\">");
            EndContext();
            BeginContext(1397, 51, false);
#line 31 "E:\NebbAirline\Client\Views\Shared\Components\Flight\Flight.cshtml"
                               Write(dateTimeFormatter.GetFormattedTime(Model.Departure));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 78, true);
            WriteLiteral("</span>\r\n            <button type=\"button\" class=\"btn btn-primary info-button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1526, "\"", 1594, 3);
            WriteAttributeValue("", 1536, "location.href=\'", 1536, 15, true);
#line 32 "E:\NebbAirline\Client\Views\Shared\Components\Flight\Flight.cshtml"
WriteAttributeValue("", 1551, Url.Action("FlightInfo", "Flight", Model), 1551, 42, false);

#line default
#line hidden
            WriteAttributeValue("", 1593, "\'", 1593, 1, true);
            EndWriteAttribute();
            BeginContext(1595, 59, true);
            WriteLiteral(">Flight Info</button>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Client.Services.IDateTimeFormater dateTimeFormatter { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Client.Models.Flight> Html { get; private set; }
    }
}
#pragma warning restore 1591
