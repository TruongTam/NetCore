#pragma checksum "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc3d718ef370e8d6a3e3279cea542be54c21fc23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Details.cshtml", typeof(AspNetCore.Views_Products_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc3d718ef370e8d6a3e3279cea542be54c21fc23", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a0b54047444c5a89a0e238488d6ceac3767aa53", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CosmeticShop.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductsOverview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("overview__button overview__button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("overview__button overview__button--new "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Admin/_AdminIndexLayout.cshtml";

#line default
#line hidden
            BeginContext(135, 42, true);
            WriteLiteral("<div class=\"container-fluid create\">\r\n    ");
            EndContext();
            BeginContext(177, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc3d718ef370e8d6a3e3279cea542be54c21fc235302", async() => {
                BeginContext(275, 40, true);
                WriteLiteral("<i class=\"fas fa-backward\"></i> Quay lại");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(319, 175, true);
            WriteLiteral("\r\n    <hr>\r\n    <p class=\"create__title\">Chi tiết sản phẩm</p>\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            <dl>\r\n                <dt>Tên sản phẩm</dt><dd>");
            EndContext();
            BeginContext(495, 36, false);
#line 13 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
                                    Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(531, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>Loại sản phẩm</dt><dd>");
            EndContext();
            BeginContext(599, 48, false);
#line 15 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
                                     Write(Html.DisplayFor(model => model.ProductType.Type));

#line default
#line hidden
            EndContext();
            BeginContext(647, 63, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>Nhãn hàng</dt><dd>");
            EndContext();
            BeginContext(711, 49, false);
#line 17 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
                                 Write(Html.DisplayFor(model => model.ProductBrand.Name));

#line default
#line hidden
            EndContext();
            BeginContext(760, 61, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>Đơn giá</dt><dd>");
            EndContext();
            BeginContext(822, 37, false);
#line 19 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(859, 76, true);
            WriteLiteral(" VNĐ\r\n                </dd>\r\n                <dt>Phần trăm giảm giá</dt><dd>");
            EndContext();
            BeginContext(936, 39, false);
#line 21 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Saleoff));

#line default
#line hidden
            EndContext();
            BeginContext(975, 75, true);
            WriteLiteral(" %\r\n                </dd>\r\n                <dt>Mô tả sản phẩm</dt><dd><pre>");
            EndContext();
            BeginContext(1051, 43, false);
#line 23 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
                                           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1094, 171, true);
            WriteLiteral("\r\n                </pre> \r\n                </dd>\r\n            </dl>\r\n        </div>\r\n        <div class=\"col-4\">\r\n            <dl>\r\n                <dt>Người đăng</dt><dd>");
            EndContext();
            BeginContext(1266, 46, false);
#line 30 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
                                  Write(Html.DisplayFor(model => model.Admin.Username));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 63, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>Ngày đăng</dt><dd>");
            EndContext();
            BeginContext(1376, 42, false);
#line 32 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
                                 Write(Html.DisplayFor(model => model.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(1418, 73, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>Ngày chỉnh sửa cuối</dt><dd>");
            EndContext();
            BeginContext(1492, 42, false);
#line 34 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
                                           Write(Html.DisplayFor(model => model.DateModify));

#line default
#line hidden
            EndContext();
            BeginContext(1534, 78, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>Điểm đánh giá trung bình</dt><dd>");
            EndContext();
            BeginContext(1613, 37, false);
#line 36 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
                                                Write(Html.DisplayFor(model => model.Stars));

#line default
#line hidden
            EndContext();
            BeginContext(1650, 69, true);
            WriteLiteral(" / 5\r\n                </dd>\r\n                <dt>Số lượt xem</dt><dd>");
            EndContext();
            BeginContext(1720, 37, false);
#line 38 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.Views));

#line default
#line hidden
            EndContext();
            BeginContext(1757, 69, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>Số lượt đặt mua</dt><dd>");
            EndContext();
            BeginContext(1827, 38, false);
#line 40 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Orders));

#line default
#line hidden
            EndContext();
            BeginContext(1865, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>Điểm tích lũy khi mua sản phẩm</dt><dd>");
            EndContext();
            BeginContext(1950, 41, false);
#line 42 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
                                                      Write(Html.DisplayFor(model => model.BuyPoints));

#line default
#line hidden
            EndContext();
            BeginContext(1991, 81, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>Số lượng hàng còn trong kho</dt><dd>");
            EndContext();
            BeginContext(2073, 39, false);
#line 44 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Instore));

#line default
#line hidden
            EndContext();
            BeginContext(2112, 199, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n        <div class=\"col-4\">\r\n            <dl>\r\n                <dt>Ảnh đại diện sản phẩm</dt>\r\n                <dd>\r\n                    \r\n");
            EndContext();
#line 53 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
                         if (Model.Thumbnail != "" && Model.Thumbnail != "#")
                        {
                            string source = @"/uploads/" + Model.Thumbnail;

#line default
#line hidden
            BeginContext(2494, 32, true);
            WriteLiteral("                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2526, "\"", 2539, 1);
#line 56 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
WriteAttributeValue("", 2532, source, 2532, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2540, 28, true);
            WriteLiteral(" width=\"300\" height=\"300\">\r\n");
            EndContext();
#line 57 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2652, 66, true);
            WriteLiteral("                            <p>Sản phẩm chưa có ảnh đại diện</p>\r\n");
            EndContext();
#line 61 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
                        }

#line default
#line hidden
            BeginContext(2745, 101, true);
            WriteLiteral("                    \r\n                </dd>\r\n            </dl>\r\n        </div>\r\n    </div>\r\n   \r\n    ");
            EndContext();
            BeginContext(2846, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc3d718ef370e8d6a3e3279cea542be54c21fc2315499", async() => {
                BeginContext(2940, 47, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i> Chỉnh sửa thông tin");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Products\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2991, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CosmeticShop.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591