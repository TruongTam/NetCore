#pragma checksum "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Admin\Session.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03a230593fd6c1a5e188436ddbac77f7f2b7e097"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Session), @"mvc.1.0.view", @"/Views/Admin/Session.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Session.cshtml", typeof(AspNetCore.Views_Admin_Session))]
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
#line 2 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Admin\Session.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03a230593fd6c1a5e188436ddbac77f7f2b7e097", @"/Views/Admin/Session.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a0b54047444c5a89a0e238488d6ceac3767aa53", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Session : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CosmeticShop.ViewModels.ProductEditViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Admin\Session.cshtml"
  
    ViewData["Title"] = "Thông tin các Session";
    Layout = "~/Views/Admin/_AdminIndexLayout.cshtml";

#line default
#line hidden
            BeginContext(201, 72, true);
            WriteLiteral("\r\n<div class=\"container-fluid create\">\r\n    <p> TenTaiKhoan = \r\n        ");
            EndContext();
            BeginContext(274, 40, false);
#line 10 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Admin\Session.cshtml"
   Write(Context.Session.GetString("TenTaiKhoan"));

#line default
#line hidden
            EndContext();
            BeginContext(314, 44, true);
            WriteLiteral(";\r\n    </p>\r\n    <p> IdTaiKhoan = \r\n        ");
            EndContext();
            BeginContext(359, 39, false);
#line 13 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Admin\Session.cshtml"
   Write(Context.Session.GetString("IdTaiKhoan"));

#line default
#line hidden
            EndContext();
            BeginContext(398, 40, true);
            WriteLiteral(";\r\n    </p>\r\n    <p> CartId = \r\n        ");
            EndContext();
            BeginContext(439, 34, false);
#line 16 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Admin\Session.cshtml"
   Write(Context.Session.GetInt32("CartId"));

#line default
#line hidden
            EndContext();
            BeginContext(473, 42, true);
            WriteLiteral(";\r\n    </p>\r\n    <p> CartType = \r\n        ");
            EndContext();
            BeginContext(516, 37, false);
#line 19 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Admin\Session.cshtml"
   Write(Context.Session.GetString("CartType"));

#line default
#line hidden
            EndContext();
            BeginContext(553, 46, true);
            WriteLiteral(";\r\n    </p>\r\n    <p> DecodeResult = \r\n        ");
            EndContext();
            BeginContext(600, 41, false);
#line 22 "D:\Dot Net MVC\net-core\CosmeticShop\CosmeticShop\Views\Admin\Session.cshtml"
   Write(Context.Session.GetString("DecodeResult"));

#line default
#line hidden
            EndContext();
            BeginContext(641, 19, true);
            WriteLiteral(";\r\n    </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CosmeticShop.ViewModels.ProductEditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591