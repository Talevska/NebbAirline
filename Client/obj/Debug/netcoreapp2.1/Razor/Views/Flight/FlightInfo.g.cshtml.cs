#pragma checksum "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52f8f3bc2f1538eab517bbebc246ea05c8b61ffe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flight_FlightInfo), @"mvc.1.0.view", @"/Views/Flight/FlightInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flight/FlightInfo.cshtml", typeof(AspNetCore.Views_Flight_FlightInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52f8f3bc2f1538eab517bbebc246ea05c8b61ffe", @"/Views/Flight/FlightInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c0e4323e51ddd3248e203e27f1781b39e71924", @"/Views/_ViewImports.cshtml")]
    public class Views_Flight_FlightInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Client.ViewModels.FlightInfoViewModel>
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
#line 3 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
  
    ViewData["Title"] = "Flight";

#line default
#line hidden
            BeginContext(149, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(177, 25, true);
            WriteLiteral("<div class=\"page-header\">");
            EndContext();
            BeginContext(203, 15, false);
#line 8 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
                    Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(218, 215, true);
            WriteLiteral("</div>\r\n<div class=\"row flight-info\">\r\n    <div class=\"single-flight-container col-md-12 col-sm-12\">\r\n        <div class=\"top-look\">\r\n            <div class=\"display-label\">\r\n                <span class=\"left-span\">");
            EndContext();
            BeginContext(434, 42, false);
#line 13 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Origin));

#line default
#line hidden
            EndContext();
            BeginContext(476, 50, true);
            WriteLiteral("</span>\r\n                <span class=\"right-span\">");
            EndContext();
            BeginContext(527, 47, false);
#line 14 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
                                    Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(574, 110, true);
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"display-field\">\r\n                <span class=\"left-span\">");
            EndContext();
            BeginContext(685, 38, false);
#line 17 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
                                   Write(Html.DisplayFor(model => model.Origin));

#line default
#line hidden
            EndContext();
            BeginContext(723, 65, true);
            WriteLiteral("</span>\r\n                <div class=\"icon\">\r\n                    ");
            EndContext();
            BeginContext(788, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0cf0224047114682b375d802f16ae29d", async() => {
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
            BeginContext(825, 67, true);
            WriteLiteral("\r\n                </div>\r\n                <span class=\"right-span\">");
            EndContext();
            BeginContext(893, 43, false);
#line 21 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
                                    Write(Html.DisplayFor(model => model.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(936, 161, true);
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n        <div class=\"bottom-look\">\r\n            <div class=\"display-label\">\r\n                <span class=\"left-span\">");
            EndContext();
            BeginContext(1098, 45, false);
#line 26 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Departure));

#line default
#line hidden
            EndContext();
            BeginContext(1143, 50, true);
            WriteLiteral("</span>\r\n                <span class=\"right-span\">");
            EndContext();
            BeginContext(1194, 46, false);
#line 27 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
                                    Write(Html.DisplayNameFor(model => model.FlightCode));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 115, true);
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"display-field\">\r\n                <span class=\"left-span date\">");
            EndContext();
            BeginContext(1356, 51, false);
#line 30 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
                                        Write(dateTimeFormatter.GetFormattedDate(Model.Departure));

#line default
#line hidden
            EndContext();
            BeginContext(1407, 50, true);
            WriteLiteral("</span>\r\n                <span class=\"right-span\">");
            EndContext();
            BeginContext(1458, 46, false);
#line 31 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
                                    Write(Html.DisplayNameFor(model => model.FlightCode));

#line default
#line hidden
            EndContext();
            BeginContext(1504, 110, true);
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"display-field\">\r\n                <span class=\"left-span\">");
            EndContext();
            BeginContext(1615, 51, false);
#line 34 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
                                   Write(dateTimeFormatter.GetFormattedTime(Model.Departure));

#line default
#line hidden
            EndContext();
            BeginContext(1666, 169, true);
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n        <div class=\"buttons\">\r\n            <button id=\"edit-ticket\" type=\"button\" class=\"btn btn-success\">\r\n                ");
            EndContext();
            BeginContext(1836, 70, false);
#line 39 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
           Write(Html.ActionLink("Edit", "Edit", "Flight", new { id = Model.FlightID }));

#line default
#line hidden
            EndContext();
            BeginContext(1906, 119, true);
            WriteLiteral("\r\n            </button>\r\n            <button id=\"delete-ticket\" type=\"button\" class=\"btn btn-danger\">\r\n                ");
            EndContext();
            BeginContext(2026, 81, false);
#line 42 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
           Write(Html.ActionLink("Delete", "ConfirmDelete", "Flight", new { id = Model.FlightID }));

#line default
#line hidden
            EndContext();
            BeginContext(2107, 63, true);
            WriteLiteral("\r\n            </button>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2192, 284, true);
            WriteLiteral(@"<div class=""row passengers"">
    <span>Passengers</span>
    <div class=""col-sm-12 passenger-row"">
        <div class=""col-sm-3 col-xs-3"">First Name</div>
        <div class=""col-sm-3 col-xs-3"">Last Name</div>
        <div class=""col-sm-3 col-xs-3"">Passport #</div>
    </div>
");
            EndContext();
#line 56 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
     foreach (var item in Model.Passengers)
    {

#line default
#line hidden
            BeginContext(2528, 90, true);
            WriteLiteral("        <div class=\"col-sm-12 passenger-row\">\r\n            <div class=\"col-sm-3 col-xs-3\">");
            EndContext();
            BeginContext(2619, 14, false);
#line 59 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
                                      Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2633, 51, true);
            WriteLiteral("</div>\r\n            <div class=\"col-sm-3 col-xs-3\">");
            EndContext();
            BeginContext(2685, 13, false);
#line 60 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
                                      Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2698, 51, true);
            WriteLiteral("</div>\r\n            <div class=\"col-sm-3 col-xs-3\">");
            EndContext();
            BeginContext(2750, 13, false);
#line 61 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
                                      Write(item.Passport);

#line default
#line hidden
            EndContext();
            BeginContext(2763, 126, true);
            WriteLiteral("</div>\r\n            <div class=\"col-sm-3 col-xs-3\">\r\n                <button type=\"button\" class=\"btn btn-primary info-button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2889, "\"", 2962, 3);
            WriteAttributeValue("", 2899, "location.href=\'", 2899, 15, true);
#line 63 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
WriteAttributeValue("", 2914, Url.Action("PassengerInfo", "Passenger", item), 2914, 47, false);

#line default
#line hidden
            WriteAttributeValue("", 2961, "\'", 2961, 1, true);
            EndWriteAttribute();
            BeginContext(2963, 52, true);
            WriteLiteral(">Info</button>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 66 "E:\NebbAirline\Client\Views\Flight\FlightInfo.cshtml"
    }

#line default
#line hidden
            BeginContext(3022, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Client.ViewModels.FlightInfoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
