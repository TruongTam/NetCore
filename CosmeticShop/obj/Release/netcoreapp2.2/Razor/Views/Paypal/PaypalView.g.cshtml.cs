#pragma checksum "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Paypal\PaypalView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f37d29ddc4e6b1d42718d675dfa859d38489d01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paypal_PaypalView), @"mvc.1.0.view", @"/Views/Paypal/PaypalView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Paypal/PaypalView.cshtml", typeof(AspNetCore.Views_Paypal_PaypalView))]
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
#line 1 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\_ViewImports.cshtml"
using CosmeticShop;

#line default
#line hidden
#line 2 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\_ViewImports.cshtml"
using CosmeticShop.Models;

#line default
#line hidden
#line 4 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f37d29ddc4e6b1d42718d675dfa859d38489d01", @"/Views/Paypal/PaypalView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a0b54047444c5a89a0e238488d6ceac3767aa53", @"/Views/_ViewImports.cshtml")]
    public class Views_Paypal_PaypalView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CosmeticShop.Models.PaypalModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Paypal\PaypalView.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(69, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(96, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f37d29ddc4e6b1d42718d675dfa859d38489d014433", async() => {
                BeginContext(102, 39, true);
                WriteLiteral("\r\n    <title>Index</title>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 141, "\"", 202, 1);
#line 11 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Paypal\PaypalView.cshtml"
WriteAttributeValue("", 147, Url.Content("https://code.jquery.com/jquery-3.3.1.js"), 147, 55, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(203, 37, true);
                WriteLiteral(" type=\"text/javascript\"></script>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(247, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(251, 628, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f37d29ddc4e6b1d42718d675dfa859d38489d016153", async() => {
                BeginContext(257, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(263, 512, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f37d29ddc4e6b1d42718d675dfa859d38489d016539", async() => {
                    BeginContext(304, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(315, 34, false);
#line 17 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Paypal\PaypalView.cshtml"
   Write(Html.HiddenFor(model => model.cmd));

#line default
#line hidden
                    EndContext();
                    BeginContext(349, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(360, 39, false);
#line 18 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Paypal\PaypalView.cshtml"
   Write(Html.HiddenFor(model => model.business));

#line default
#line hidden
                    EndContext();
                    BeginContext(399, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(410, 42, false);
#line 19 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Paypal\PaypalView.cshtml"
   Write(Html.HiddenFor(model => model.no_shipping));

#line default
#line hidden
                    EndContext();
                    BeginContext(452, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(463, 38, false);
#line 20 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Paypal\PaypalView.cshtml"
   Write(Html.HiddenFor(model => model.@return));

#line default
#line hidden
                    EndContext();
                    BeginContext(501, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(512, 44, false);
#line 21 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Paypal\PaypalView.cshtml"
   Write(Html.HiddenFor(model => model.cancel_return));

#line default
#line hidden
                    EndContext();
                    BeginContext(556, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(567, 41, false);
#line 22 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Paypal\PaypalView.cshtml"
   Write(Html.HiddenFor(model => model.notify_url));

#line default
#line hidden
                    EndContext();
                    BeginContext(608, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(619, 44, false);
#line 23 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Paypal\PaypalView.cshtml"
   Write(Html.HiddenFor(model => model.currency_code));

#line default
#line hidden
                    EndContext();
                    BeginContext(663, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(674, 40, false);
#line 24 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Paypal\PaypalView.cshtml"
   Write(Html.HiddenFor(model => model.item_name));

#line default
#line hidden
                    EndContext();
                    BeginContext(714, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(725, 37, false);
#line 25 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Paypal\PaypalView.cshtml"
   Write(Html.HiddenFor(model => model.amount));

#line default
#line hidden
                    EndContext();
                    BeginContext(762, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 16 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Paypal\PaypalView.cshtml"
AddHtmlAttributeValue("", 285, ViewBag.actionURL, 285, 18, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(775, 97, true);
                WriteLiteral("\r\n\r\n    <p style=\"text-align: center\">\r\n        <h2>Redirecting to Paypal...</h2>\r\n\r\n    </p>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(879, 136, true);
            WriteLiteral("\r\n</html>\r\n\r\n<script>\r\n    $(this.document).ready(function () {\r\n        var frm = $(\"form\");\r\n        frm.submit();\r\n    });\r\n</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CosmeticShop.Models.PaypalModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
