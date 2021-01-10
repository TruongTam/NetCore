#pragma checksum "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\User\MyOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84379aae26b11f7fb735c56b85585025cc0db83e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_MyOrders), @"mvc.1.0.view", @"/Views/User/MyOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/MyOrders.cshtml", typeof(AspNetCore.Views_User_MyOrders))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84379aae26b11f7fb735c56b85585025cc0db83e", @"/Views/User/MyOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a0b54047444c5a89a0e238488d6ceac3767aa53", @"/Views/_ViewImports.cshtml")]
    public class Views_User_MyOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CosmeticShop.ViewModels.UserMyOrdersViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyOrderDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blck vm_order"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\User\MyOrders.cshtml"
  
    ViewBag.Title = "Đơn đặt hàng của tôi";
    Layout = "~/Views/Shared/Users/_IndexLayout.cshtml";
    int user_id = (int)Context.Session.GetInt32("IdTaiKhoan");

#line default
#line hidden
            BeginContext(228, 62, true);
            WriteLiteral("\r\n<div class=\"container-fluid section\">\r\n    <h2>Đơn hàng của ");
            EndContext();
            BeginContext(291, 40, false);
#line 9 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\User\MyOrders.cshtml"
                Write(Context.Session.GetString("TenTaiKhoan"));

#line default
#line hidden
            EndContext();
            BeginContext(331, 59, true);
            WriteLiteral("</h2>\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n");
            EndContext();
#line 12 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\User\MyOrders.cshtml"
             foreach (var vm in Model.MyOrderViewModels)
            {
                

#line default
#line hidden
#line 14 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\User\MyOrders.cshtml"
                 if (vm.Order.OrderStatus_Id != 4)
                {
                    string status = "Đang chờ xử lý";
                    if (vm.Order.OrderStatus_Id == 2) { status = "Đang lấy hàng"; }
                    else if (vm.Order.OrderStatus_Id == 3) { status = "Đang vận chuyển"; }

#line default
#line hidden
            BeginContext(766, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(786, 594, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84379aae26b11f7fb735c56b85585025cc0db83e5869", async() => {
                BeginContext(923, 63, true);
                WriteLiteral("\r\n                        <p class=\"vm_order__id\">Mã đơn hàng: ");
                EndContext();
                BeginContext(987, 11, false);
#line 20 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\User\MyOrders.cshtml"
                                                        Write(vm.Order.Id);

#line default
#line hidden
                EndContext();
                BeginContext(998, 88, true);
                WriteLiteral("</p>\r\n                        <p class=\"vm_order__status\">\r\n                            ");
                EndContext();
                BeginContext(1087, 6, false);
#line 22 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\User\MyOrders.cshtml"
                       Write(status);

#line default
#line hidden
                EndContext();
                BeginContext(1093, 94, true);
                WriteLiteral("\r\n                        </p>\r\n                        <p class=\"vm_order__p\">Ngày đặt hàng: ");
                EndContext();
                BeginContext(1188, 48, false);
#line 24 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\User\MyOrders.cshtml"
                                                         Write(vm.Order.DateCreate.ToString("dd/MM/yyyy hh:mm"));

#line default
#line hidden
                EndContext();
                BeginContext(1236, 64, true);
                WriteLiteral("</p>\r\n                        <p class=\"vm_order__p\">Tổng cộng: ");
                EndContext();
                BeginContext(1301, 49, false);
#line 25 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\User\MyOrders.cshtml"
                                                     Write(String.Format("{0:0,0 VNĐ}", vm.Order.TotalPrice));

#line default
#line hidden
                EndContext();
                BeginContext(1350, 26, true);
                WriteLiteral("</p>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-user_id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\User\MyOrders.cshtml"
                                                                               WriteLiteral(user_id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["user_id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-user_id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["user_id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 19 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\User\MyOrders.cshtml"
                                                                                                             WriteLiteral(vm.Order.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["order_id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-order_id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["order_id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1380, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 27 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\User\MyOrders.cshtml"
                }

#line default
#line hidden
#line 27 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\User\MyOrders.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(1416, 85, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-8\">\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CosmeticShop.ViewModels.UserMyOrdersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591