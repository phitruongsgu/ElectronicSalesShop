#pragma checksum "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\Account\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae1edbb3d2cfdf2aee5b91eeb72e2bb76f4430c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Detail), @"mvc.1.0.view", @"/Views/Account/Detail.cshtml")]
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
#line 1 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\_ViewImports.cshtml"
using ElectronicSalesManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\_ViewImports.cshtml"
using ElectronicSalesManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\_ViewImports.cshtml"
using ElectronicSalesManagement.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\_ViewImports.cshtml"
using Core.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\Account\Detail.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae1edbb3d2cfdf2aee5b91eeb72e2bb76f4430c9", @"/Views/Account/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d1a8f12826ad9c4c89e83498a6afeb80b54d5b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ModelView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirmRemove()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\Account\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1 style=\"text-align:center\" class=\"text-black-50\">DETAIL YOUR ACCOUNT</h1>\r\n        </div>\r\n    </div>\r\n    <hr />\r\n");
#nullable restore
#line 14 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\Account\Detail.cshtml"
      
        String username = Context.Session.GetString("login");
        if (username != null)
        {
            username = JsonConvert.DeserializeObject<String>(username);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">Username</th>
                        <th scope=""col"">Password</th>
                        <th scope=""col"">Status</th>
                        <th scope=""col"">Email</th>
                        <th scope=""col"">Date Active</th>
                        <th scope=""col"">Action</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 31 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\Account\Detail.cshtml"
                     foreach (var i in Model.Accounts)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 34 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\Account\Detail.cshtml"
                         if (i.Username == username)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 36 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\Account\Detail.cshtml"
                           Write(i.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\Account\Detail.cshtml"
                           Write(i.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\Account\Detail.cshtml"
                           Write(i.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\Account\Detail.cshtml"
                           Write(i.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 40 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\Account\Detail.cshtml"
                           Write(i.DateActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae1edbb3d2cfdf2aee5b91eeb72e2bb76f4430c910602", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\Account\Detail.cshtml"
                                                                                                        WriteLiteral(i.ID_Account);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae1edbb3d2cfdf2aee5b91eeb72e2bb76f4430c913210", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\Account\Detail.cshtml"
                                                                                                                                          WriteLiteral(i.ID_Account);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 45 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\Account\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 49 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\Account\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 53 "D:\CodeC#\.NET CORE MVC\ElectronicSales\.Net Core Application.WebApp\ElectronicSalesManagement\ElectronicSalesManagement\Views\Account\Detail.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<script>\r\n    function confirmRemove() {\r\n        var a = confirm(\"Do you really want to delete your own account?\");\r\n        if (a) {\r\n            return true;\r\n        }\r\n        return false;\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591
