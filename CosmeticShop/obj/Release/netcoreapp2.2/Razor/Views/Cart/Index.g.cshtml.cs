#pragma checksum "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b43d07e32954aba153a1b0ddd56e29b7ce5b7827"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b43d07e32954aba153a1b0ddd56e29b7ce5b7827", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a0b54047444c5a89a0e238488d6ceac3767aa53", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CosmeticShop.ViewModels.CartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("145"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("145"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("poster_1_up"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("shop_thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button--gotocheckout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right:700px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MustSignUp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button--new"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AlreadySignUp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
  ViewBag.Title = "Giỏ hàng";
    Layout = "~/Views/Shared/Users/_IndexLayout.cshtml";

#line default
#line hidden
            BeginContext(138, 902, true);
            WriteLiteral(@"
<div class=""container-fluid section"" id=""CartItemContainer"">
    <div class=""container"">
        <h1 class=""section__title"">
            Giỏ hàng <i class=""fas fa-shopping-cart""></i>
        </h1>
        <br />
        <br />
        <table cellspacing=""0"" class=""shop_table cart"">
            <thead>
                <tr>



                    <th scope=""col"">STT</th>
                    <th class=""product-thumbnail"">Ảnh Sản Phẩm</th>
                    <th scope=""col"">Tên hàng</th>
                    <th scope=""col"" class=""clCenter"" style=""width:200px"">Số lượng</th>
                    <th class=""product-price"" style=""width:150px"">Price</th>
                    <th scope=""col"" class=""clCenter"" style=""width:150px"">Thành tiền</th>
                    <th scope=""col"" class=""clCenter"">Hủy sản phẩm</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 29 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
                  
                    int totalePrice = 0;
                    int stt = 1;
                

#line default
#line hidden
            BeginContext(1155, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 33 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
                 foreach (var item in Model.CartItemViewModels)
                {


#line default
#line hidden
            BeginContext(1241, 84, true);
            WriteLiteral("                    <tr class=\"cart_item\">\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(1326, 3, false);
#line 37 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
                                   Write(stt);

#line default
#line hidden
            EndContext();
            BeginContext(1329, 121, true);
            WriteLiteral("</th>\r\n                        <td class=\"product-thumbnail\">\r\n                            <a href=\"single-product.html\">");
            EndContext();
            BeginContext(1450, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b43d07e32954aba153a1b0ddd56e29b7ce5b78279854", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1526, "~/uploads/", 1526, 10, true);
#line 39 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 1536, item.TenAnh, 1536, 12, false);

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
            BeginContext(1550, 67, true);
            WriteLiteral("</a>\r\n                        </td>\r\n\r\n                        <td>");
            EndContext();
            BeginContext(1618, 9, false);
#line 42 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1627, 62, true);
            WriteLiteral("</td>\r\n\r\n\r\n\r\n\r\n                        <td class=\"clCenter\"><a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1689, "\"", 1718, 3);
            WriteAttributeValue("", 1699, "minusItem(", 1699, 10, true);
#line 47 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1709, item.Id, 1709, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1717, ")", 1717, 1, true);
            EndWriteAttribute();
            BeginContext(1719, 52, true);
            WriteLiteral("   class=\"CartEdit\"><i class=\"fas fa-minus\"></i></a>");
            EndContext();
            BeginContext(1772, 13, false);
#line 47 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
                                                                                                                            Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1785, 2, true);
            WriteLiteral("<a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1787, "\"", 1815, 3);
            WriteAttributeValue("", 1797, "plusItem(", 1797, 9, true);
#line 47 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1806, item.Id, 1806, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1814, ")", 1814, 1, true);
            EndWriteAttribute();
            BeginContext(1816, 159, true);
            WriteLiteral(" class=\"CartEdit\"><i class=\"fas fa-plus\"></i></a></td>\r\n                        <td class=\"product-price\">\r\n                            <span class=\"amount\" > ");
            EndContext();
            BeginContext(1976, 40, false);
#line 49 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
                                              Write(String.Format("{0:0,0 VNĐ}", item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2016, 86, true);
            WriteLiteral("</span>\r\n                        </td>\r\n                        <td class=\"clCenter\"> ");
            EndContext();
            BeginContext(2103, 45, false);
#line 51 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
                                         Write(String.Format("{0:0,0 VNĐ}", item.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2148, 111, true);
            WriteLiteral("</td>\r\n\r\n                        <td class=\"clCenter\">\r\n                            <!--<p onclick=\"deleteItem(");
            EndContext();
            BeginContext(2260, 7, false);
#line 54 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
                                                  Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2267, 156, true);
            WriteLiteral(")\" class=\"point btn btn-secondary btn-sm\" data-toggle=\"modal\" data-target=\"#deleteModal\"><i class=\"fas fa-times\"></i></p>-->\r\n                            <p");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2423, "\"", 2453, 3);
            WriteAttributeValue("", 2433, "deleteItem(", 2433, 11, true);
#line 55 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2444, item.Id, 2444, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2452, ")", 2452, 1, true);
            EndWriteAttribute();
            BeginContext(2454, 132, true);
            WriteLiteral(" class=\"point btn btn-secondary btn-sm\"><i class=\"fas fa-times\"></i></p>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 58 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
                    totalePrice += item.TotalPrice;
                    stt++;
                }

#line default
#line hidden
            BeginContext(2686, 80, true);
            WriteLiteral("                <tr>\r\n                    <td class=\"actions\" colspan=\"7\">\r\n\r\n\r\n");
            EndContext();
#line 65 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
                         if (Context.Session.GetInt32("IdTaiKhoan") == null)
                        {
                            if (Context.Session.GetInt32("IdCart") != null)
                            {
                                int anocart_id = (int)Context.Session.GetInt32("IdCart");
                        

#line default
#line hidden
            BeginContext(3096, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(3128, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b43d07e32954aba153a1b0ddd56e29b7ce5b782717127", async() => {
                BeginContext(3235, 20, true);
                WriteLiteral("<< TIẾP TỤC MUA HÀNG");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3259, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3293, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b43d07e32954aba153a1b0ddd56e29b7ce5b782718921", async() => {
                BeginContext(3407, 10, true);
                WriteLiteral("THANH TOÁN");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-anocartid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
                                                                                                                         WriteLiteral(anocart_id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["anocartid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-anocartid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["anocartid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3421, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 73 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
                            }
                        }
                        else
                        {
                            int userid = (int)Context.Session.GetInt32("IdTaiKhoan");

#line default
#line hidden
            BeginContext(3625, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(3657, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b43d07e32954aba153a1b0ddd56e29b7ce5b782722105", async() => {
                BeginContext(3764, 20, true);
                WriteLiteral("<< TIẾP TỤC MUA HÀNG");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3788, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3818, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b43d07e32954aba153a1b0ddd56e29b7ce5b782723895", async() => {
                BeginContext(3928, 10, true);
                WriteLiteral("THANH TOÁN");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
                                                                                                                     WriteLiteral(userid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3942, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 80 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Cart\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3971, 1148, true);
            WriteLiteral(@"                    </td>
                </tr>
            </tbody>

          
             </table>

</div>
</div>



<script>
    function plusItem(id) {
        $.ajax({
            url: ""/cart/PlusItem"",
            method: ""POST"",
            data: { id: id },
            async: true,
            dataType: ""HTML"",
            success: function (data) {
                $(""#CartItemContainer"").html(data);
            }
        });
    };
    function minusItem(id) {
        $.ajax({
            url: ""/cart/MinusItem"",
            method: ""POST"",
            data: { id: id },
            async: true,
            dataType: ""HTML"",
            success: function (data) {
                $(""#CartItemContainer"").html(data);
            }
        });
    };

    function deleteItem(id) {
        $.ajax({
            url: ""/cart/DeleteItem"",
            method: ""POST"",
            data: { id: id },
            async: true,
            dataType: ""HTML"",
            suc");
            WriteLiteral("cess: function (data) {\r\n                $(\"#CartItemContainer\").html(data);\r\n            }\r\n        });\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CosmeticShop.ViewModels.CartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
