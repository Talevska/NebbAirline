#pragma checksum "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d64253e110021b216ac6df786e13435df8df6d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_ConfirmDelete), @"mvc.1.0.view", @"/Views/Ticket/ConfirmDelete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ticket/ConfirmDelete.cshtml", typeof(AspNetCore.Views_Ticket_ConfirmDelete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d64253e110021b216ac6df786e13435df8df6d5", @"/Views/Ticket/ConfirmDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c0e4323e51ddd3248e203e27f1781b39e71924", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_ConfirmDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Client.Models.Ticket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/nebb.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ticket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(90, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(134, 27, true);
            WriteLiteral("\r\n<div class=\"page-header\">");
            EndContext();
            BeginContext(162, 15, false);
#line 8 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                    Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(177, 138, true);
            WriteLiteral("</div>\r\n\r\n<div class=\"row ticket-info\">\r\n    <div class=\"ticket-container col-xs-6 col-sm-12\">\r\n        <div class=\"header\">\r\n            ");
            EndContext();
            BeginContext(315, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bbf69d484eac4cec82458c7f85fd4770", async() => {
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
            BeginContext(346, 216, true);
            WriteLiteral("\r\n            <span>Nebb Airline Ticket</span>\r\n        </div>\r\n        <div class=\"ticket-top-look\">\r\n            <span class=\"psg-info\">Passenger Info</span>\r\n            <br />\r\n            <span class=\"name-for\">");
            EndContext();
            BeginContext(563, 45, false);
#line 19 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                              Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(608, 40, true);
            WriteLiteral("</span>\r\n            <span class=\"name\">");
            EndContext();
            BeginContext(649, 41, false);
#line 20 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                          Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(690, 44, true);
            WriteLiteral("</span>\r\n            <span class=\"name-for\">");
            EndContext();
            BeginContext(735, 45, false);
#line 21 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                              Write(Html.DisplayNameFor(model => model.DateBirth));

#line default
#line hidden
            EndContext();
            BeginContext(780, 40, true);
            WriteLiteral("</span>\r\n            <span class=\"name\">");
            EndContext();
            BeginContext(821, 41, false);
#line 22 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                          Write(Html.DisplayFor(model => model.DateBirth));

#line default
#line hidden
            EndContext();
            BeginContext(862, 64, true);
            WriteLiteral("</span>\r\n            <br />\r\n            <span class=\"name-for\">");
            EndContext();
            BeginContext(927, 44, false);
#line 24 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                              Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(971, 40, true);
            WriteLiteral("</span>\r\n            <span class=\"name\">");
            EndContext();
            BeginContext(1012, 40, false);
#line 25 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                          Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 44, true);
            WriteLiteral("</span>\r\n            <span class=\"name-for\">");
            EndContext();
            BeginContext(1097, 44, false);
#line 26 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                              Write(Html.DisplayNameFor(model => model.Passport));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 40, true);
            WriteLiteral("</span>\r\n            <span class=\"name\">");
            EndContext();
            BeginContext(1182, 40, false);
#line 27 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                          Write(Html.DisplayFor(model => model.Passport));

#line default
#line hidden
            EndContext();
            BeginContext(1222, 158, true);
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"ticket-bottom-look\">\r\n            <span class=\"flg-info\">Flight info</span>\r\n            <span class=\"code-name\">");
            EndContext();
            BeginContext(1381, 42, false);
#line 31 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                               Write(Html.DisplayFor(model => model.FlightCode));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 49, true);
            WriteLiteral("</span>\r\n            <span class=\"code-name-for\">");
            EndContext();
            BeginContext(1473, 46, false);
#line 32 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                                   Write(Html.DisplayNameFor(model => model.FlightCode));

#line default
#line hidden
            EndContext();
            BeginContext(1519, 64, true);
            WriteLiteral("</span>\r\n            <br />\r\n            <span class=\"name-for\">");
            EndContext();
            BeginContext(1584, 42, false);
#line 34 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                              Write(Html.DisplayNameFor(model => model.Origin));

#line default
#line hidden
            EndContext();
            BeginContext(1626, 40, true);
            WriteLiteral("</span>\r\n            <span class=\"name\">");
            EndContext();
            BeginContext(1667, 38, false);
#line 35 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                          Write(Html.DisplayFor(model => model.Origin));

#line default
#line hidden
            EndContext();
            BeginContext(1705, 44, true);
            WriteLiteral("</span>\r\n            <span class=\"name-for\">");
            EndContext();
            BeginContext(1750, 47, false);
#line 36 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                              Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(1797, 40, true);
            WriteLiteral("</span>\r\n            <span class=\"name\">");
            EndContext();
            BeginContext(1838, 43, false);
#line 37 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                          Write(Html.DisplayFor(model => model.Destination));

#line default
#line hidden
            EndContext();
            BeginContext(1881, 64, true);
            WriteLiteral("</span>\r\n            <br />\r\n            <span class=\"name-for\">");
            EndContext();
            BeginContext(1946, 45, false);
#line 39 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                              Write(Html.DisplayNameFor(model => model.Departure));

#line default
#line hidden
            EndContext();
            BeginContext(1991, 48, true);
            WriteLiteral("</span>\r\n            <span class=\"name-dep-ret\">");
            EndContext();
            BeginContext(2040, 51, false);
#line 40 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                                  Write(dateTimeFormatter.GetFormattedDate(Model.Departure));

#line default
#line hidden
            EndContext();
            BeginContext(2091, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2093, 51, false);
#line 40 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                                                                                       Write(dateTimeFormatter.GetFormattedTime(Model.Departure));

#line default
#line hidden
            EndContext();
            BeginContext(2144, 31, true);
            WriteLiteral("</span>\r\n            <br />\r\n\r\n");
            EndContext();
#line 43 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
              
                if (Model.Return.HasValue)
                {
                    DateTime date = Model.Return.Value;

#line default
#line hidden
            BeginContext(2311, 43, true);
            WriteLiteral("                    <span class=\"name-for\">");
            EndContext();
            BeginContext(2355, 42, false);
#line 47 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                                      Write(Html.DisplayNameFor(model => model.Return));

#line default
#line hidden
            EndContext();
            BeginContext(2397, 56, true);
            WriteLiteral("</span>\r\n                    <span class=\"name-dep-ret\">");
            EndContext();
            BeginContext(2454, 40, false);
#line 48 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                                          Write(dateTimeFormatter.GetFormattedDate(date));

#line default
#line hidden
            EndContext();
            BeginContext(2494, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2496, 40, false);
#line 48 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                                                                                    Write(dateTimeFormatter.GetFormattedTime(date));

#line default
#line hidden
            EndContext();
            BeginContext(2536, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 49 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                }
            

#line default
#line hidden
            BeginContext(2579, 62, true);
            WriteLiteral("\r\n            <br />\r\n            <span class=\"bags-name-for\">");
            EndContext();
            BeginContext(2642, 46, false);
#line 53 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                                   Write(Html.DisplayNameFor(model => model.CarryOnBag));

#line default
#line hidden
            EndContext();
            BeginContext(2688, 45, true);
            WriteLiteral("</span>\r\n            <span class=\"bags-name\">");
            EndContext();
            BeginContext(2734, 42, false);
#line 54 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                               Write(Html.DisplayFor(model => model.CarryOnBag));

#line default
#line hidden
            EndContext();
            BeginContext(2776, 49, true);
            WriteLiteral("</span>\r\n            <span class=\"bags-name-for\">");
            EndContext();
            BeginContext(2826, 46, false);
#line 55 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TrolleyBag));

#line default
#line hidden
            EndContext();
            BeginContext(2872, 45, true);
            WriteLiteral("</span>\r\n            <span class=\"bags-name\">");
            EndContext();
            BeginContext(2918, 42, false);
#line 56 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                               Write(Html.DisplayFor(model => model.TrolleyBag));

#line default
#line hidden
            EndContext();
            BeginContext(2960, 49, true);
            WriteLiteral("</span>\r\n            <span class=\"bags-name-for\">");
            EndContext();
            BeginContext(3010, 48, false);
#line 57 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                                   Write(Html.DisplayNameFor(model => model.CheckedInBag));

#line default
#line hidden
            EndContext();
            BeginContext(3058, 45, true);
            WriteLiteral("</span>\r\n            <span class=\"bags-name\">");
            EndContext();
            BeginContext(3104, 44, false);
#line 58 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
                               Write(Html.DisplayFor(model => model.CheckedInBag));

#line default
#line hidden
            EndContext();
            BeginContext(3148, 74, true);
            WriteLiteral("</span>\r\n        </div>\r\n\r\n        <div class=\"delete-form\">\r\n            ");
            EndContext();
            BeginContext(3222, 448, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd46b35ed42341c98b03718b5b716d8f", async() => {
                BeginContext(3316, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(3334, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b4ef485482f74d0d9039ddaf8e8d7e84", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 63 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TicketID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3376, 193, true);
                WriteLiteral("\r\n                <input id=\"yes-delete\" class=\"btn btn-danger\" type=\"submit\" value=\"Yes\" />\r\n                <button id=\"no-delete\" type=\"button\" class=\"btn btn-success\">\r\n                    ");
                EndContext();
                BeginContext(3570, 52, false);
#line 66 "E:\NebbAirline\Client\Views\Ticket\ConfirmDelete.cshtml"
               Write(Html.ActionLink("No", "TicketInfo", "Ticket", Model));

#line default
#line hidden
                EndContext();
                BeginContext(3622, 41, true);
                WriteLiteral("\r\n                </button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3670, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Client.Models.Ticket> Html { get; private set; }
    }
}
#pragma warning restore 1591
