#pragma checksum "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\Contact\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7796fce100622e0d4075f84b2a42c0e4b7b99af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Success), @"mvc.1.0.view", @"/Views/Contact/Success.cshtml")]
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
#line 1 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\_ViewImports.cshtml"
using GS.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\_ViewImports.cshtml"
using GS.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7796fce100622e0d4075f84b2a42c0e4b7b99af", @"/Views/Contact/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"551d6c05c19596f8e24527e7dd725dfab8f6ff76", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\Contact\Success.cshtml"
  
    ViewData["Title"] = "Success";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""products"" style=""background-color:#42929d"">
    <div class=""container"" style=""margin-top:50px"">
        <hr class=""offset-lg"">
        <hr class=""offset-lg"">

        <div style=""background-color:#f8f6f6;padding:10px"">
            <div class=""text-center"">
                <h2>WE COME TO YOU!</h2>
                <p>");
#nullable restore
#line 15 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\Contact\Success.cshtml"
              Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591