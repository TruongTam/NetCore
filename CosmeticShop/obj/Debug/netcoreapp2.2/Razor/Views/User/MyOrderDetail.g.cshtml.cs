#pragma checksum "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eee9cda21a260e7c1f3171354c915c36d1d12b31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_MyOrderDetail), @"mvc.1.0.view", @"/Views/User/MyOrderDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/MyOrderDetail.cshtml", typeof(AspNetCore.Views_User_MyOrderDetail))]
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
#line 1 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\_ViewImports.cshtml"
using CosmeticShop;

#line default
#line hidden
#line 2 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\_ViewImports.cshtml"
using CosmeticShop.Models;

#line default
#line hidden
#line 4 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eee9cda21a260e7c1f3171354c915c36d1d12b31", @"/Views/User/MyOrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a0b54047444c5a89a0e238488d6ceac3767aa53", @"/Views/_ViewImports.cshtml")]
    public class Views_User_MyOrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CosmeticShop.ViewModels.UserMyOrderDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyOrderDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blck vm_order"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
  
    ViewBag.Title = "Đơn đặt hàng của tôi";
    Layout = "~/Views/Shared/Users/_IndexLayout.cshtml";
    int user_id = (int)Context.Session.GetInt32("IdTaiKhoan");
    

#line default
#line hidden
            BeginContext(239, 62, true);
            WriteLiteral("\r\n<div class=\"container-fluid section\">\r\n    <h2>Đơn hàng của ");
            EndContext();
            BeginContext(302, 40, false);
#line 10 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                Write(Context.Session.GetString("TenTaiKhoan"));

#line default
#line hidden
            EndContext();
            BeginContext(342, 59, true);
            WriteLiteral("</h2>\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n");
            EndContext();
#line 13 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
             foreach (var vm in Model.MyOrderViewModels)
            {
                

#line default
#line hidden
#line 15 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                 if (vm.Order.OrderStatus_Id != 4)
                {
                    string status = "Đang chờ xử lý";
                    if (vm.Order.OrderStatus_Id == 2) {status = "Đang lấy hàng";}
                    else if (vm.Order.OrderStatus_Id == 3) {status = "Đang vận chuyển";}

#line default
#line hidden
            BeginContext(773, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(793, 595, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eee9cda21a260e7c1f3171354c915c36d1d12b316941", async() => {
                BeginContext(930, 63, true);
                WriteLiteral("\r\n                        <p class=\"vm_order__id\">Mã đơn hàng: ");
                EndContext();
                BeginContext(994, 11, false);
#line 21 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                                                        Write(vm.Order.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1005, 88, true);
                WriteLiteral("</p>\r\n                        <p class=\"vm_order__status\">\r\n                            ");
                EndContext();
                BeginContext(1094, 6, false);
#line 23 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                       Write(status);

#line default
#line hidden
                EndContext();
                BeginContext(1100, 94, true);
                WriteLiteral("\r\n                        </p>\r\n                        <p class=\"vm_order__p\">Ngày đặt hàng: ");
                EndContext();
                BeginContext(1195, 48, false);
#line 25 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                                                         Write(vm.Order.DateCreate.ToString("dd/MM/yyyy hh:mm"));

#line default
#line hidden
                EndContext();
                BeginContext(1243, 64, true);
                WriteLiteral("</p>\r\n                        <p class=\"vm_order__p\">Tổng cộng: ");
                EndContext();
                BeginContext(1308, 49, false);
#line 26 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                                                     Write(String.Format("{0:0,0 VNĐ}", vm.Order.TotalPrice));

#line default
#line hidden
                EndContext();
                BeginContext(1357, 27, true);
                WriteLiteral("</p>\r\n                     ");
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
#line 20 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                                                                               WriteLiteral(user_id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["user_id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-user_id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["user_id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 20 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
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
            BeginContext(1388, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                }

#line default
#line hidden
#line 28 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(1424, 99, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-8\">\r\n            <h3>Thông tin giao hàng</h3>\r\n            ");
            EndContext();
            BeginContext(1523, 2267, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eee9cda21a260e7c1f3171354c915c36d1d12b3112799", async() => {
                BeginContext(1529, 159, true);
                WriteLiteral("\r\n                <div class=\"form-row\">\r\n                    <div class=\"col form-group\">\r\n                        <label>Họ</label>\r\n                        ");
                EndContext();
                BeginContext(1688, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eee9cda21a260e7c1f3171354c915c36d1d12b3113352", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 37 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.MyOrderViewModel.Order.NameLast);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1786, 151, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col form-group\">\r\n                        <label>Họ đệm</label>\r\n                        ");
                EndContext();
                BeginContext(1937, 100, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eee9cda21a260e7c1f3171354c915c36d1d12b3115762", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 41 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.MyOrderViewModel.Order.NameMiddle);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2037, 148, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col form-group\">\r\n                        <label>Tên</label>\r\n                        ");
                EndContext();
                BeginContext(2185, 99, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eee9cda21a260e7c1f3171354c915c36d1d12b3118170", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 45 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.MyOrderViewModel.Order.NameFirst);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2284, 184, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                \r\n                <div class=\"form-group\">\r\n                    <label>Số điện thoại</label>\r\n                    ");
                EndContext();
                BeginContext(2468, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eee9cda21a260e7c1f3171354c915c36d1d12b3120618", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 51 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.MyOrderViewModel.Order.PhoneNumber);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2569, 201, true);
                WriteLiteral("\r\n                </div>\r\n            \r\n                <div class=\"form-row\">\r\n                    <div class=\"col form-group\">\r\n                        <label>Số nhà</label>\r\n                        ");
                EndContext();
                BeginContext(2770, 106, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eee9cda21a260e7c1f3171354c915c36d1d12b3123087", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 57 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.MyOrderViewModel.Order.AddressApartment);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2876, 150, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col form-group\">\r\n                        <label>Đường</label>\r\n                        ");
                EndContext();
                BeginContext(3026, 103, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eee9cda21a260e7c1f3171354c915c36d1d12b3125504", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 61 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.MyOrderViewModel.Order.AddressStreet);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3129, 221, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-row\">\r\n                    <div class=\"col form-group\">\r\n                        <label>Quận / Huyện</label>\r\n                        ");
                EndContext();
                BeginContext(3350, 105, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eee9cda21a260e7c1f3171354c915c36d1d12b3127995", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 67 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.MyOrderViewModel.Order.AddressDistrict);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3455, 161, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col form-group\">\r\n                        <label>Tỉnh / Thành phố</label>\r\n                        ");
                EndContext();
                BeginContext(3616, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eee9cda21a260e7c1f3171354c915c36d1d12b3130422", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 71 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.MyOrderViewModel.Order.AddressCity);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3717, 66, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3790, 243, true);
            WriteLiteral("\r\n\r\n            <h3>Chi tiết đơn hàng</h3>\r\n            <table class=\"table\">\r\n                <tr>\r\n                    <th>Sản phẩm</th>\r\n                    <th>Số lượng</th>\r\n                    <th>Thành tiền</th>\r\n                </tr>\r\n");
            EndContext();
#line 83 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                 foreach (var detail in Model.MyOrderViewModel.OrderDetails)
                {

#line default
#line hidden
            BeginContext(4130, 26, true);
            WriteLiteral("                    <tr>\r\n");
            EndContext();
#line 86 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                         foreach (var product in Model.MyOrderViewModel.Products)
                        {
                            

#line default
#line hidden
#line 88 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                             if (product.Id == detail.Product_Id)
                            {

#line default
#line hidden
            BeginContext(4364, 74, true);
            WriteLiteral("                                <td>\r\n                                    ");
            EndContext();
            BeginContext(4439, 12, false);
#line 91 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                               Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4451, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 93 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                            }

#line default
#line hidden
#line 93 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                             
                        }

#line default
#line hidden
            BeginContext(4550, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(4609, 15, false);
#line 96 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                       Write(detail.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(4624, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4716, 47, false);
#line 99 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                       Write(String.Format("{0:0,0 VNĐ}", detail.PriceTotal));

#line default
#line hidden
            EndContext();
            BeginContext(4763, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 102 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                }

#line default
#line hidden
            BeginContext(4842, 67, true);
            WriteLiteral("            </table>\r\n            <h4>\r\n                Tổng cộng: ");
            EndContext();
            BeginContext(4910, 69, false);
#line 105 "C:\Users\MY PC\Desktop\NetCore\CosmeticShop\Views\User\MyOrderDetail.cshtml"
                      Write(String.Format("{0:0,0 VNĐ}", Model.MyOrderViewModel.Order.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(4979, 63, true);
            WriteLiteral("\r\n            </h4>\r\n        </div>\r\n    </div>    \r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CosmeticShop.ViewModels.UserMyOrderDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591