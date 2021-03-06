#pragma checksum "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Areas\Manage\Views\Store\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35e8d200baceb2b735a723f54bfa95ccadcaa67b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Store_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Store/Index.cshtml")]
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
#line 1 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Areas\Manage\Views\_ViewImports.cshtml"
using GS.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Areas\Manage\Views\_ViewImports.cshtml"
using GS.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35e8d200baceb2b735a723f54bfa95ccadcaa67b", @"/Areas/Manage/Views/Store/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f295f54a301a3e9f6005acb6bccf5019c4c8e7df", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Store_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GS.DATA.Entities.Shop.Store>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Areas\Manage\Views\Store\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1>Store list</h1>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                    <li class=""breadcrumb-item active"">Store</li>
                </ol>
            </div>
        </div>
    </div>
</section>

<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Store table</h3>

                        <div class=""card-tools"">
                            <div class=""input-group input-group-sm"" style=""width: 150px;"">

                                <div class=""input-group-append"">
                          ");
            WriteLiteral(@"          <a href=""/Manage/Store/Create"" class=""btn btn-default""><i class=""fas fa-plus""></i>Create new</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""card-body table-responsive p-0"">
                        <table class=""table table-head-fixed text-nowrap"">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Name</th>
                                    <th>Address</th>
                                    <th>Email</th>
                                    <th>Phone</th>
                                    <th>Employee</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 53 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Areas\Manage\Views\Store\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 56 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Areas\Manage\Views\Store\Index.cshtml"
                                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 57 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Areas\Manage\Views\Store\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 58 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Areas\Manage\Views\Store\Index.cshtml"
                                       Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 59 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Areas\Manage\Views\Store\Index.cshtml"
                                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 60 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Areas\Manage\Views\Store\Index.cshtml"
                                       Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 2547, "\"", 2593, 2);
            WriteAttributeValue("", 2554, "/Manage/StoreEmployee/Index?id=", 2554, 31, true);
#nullable restore
#line 61 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Areas\Manage\Views\Store\Index.cshtml"
WriteAttributeValue("", 2585, item.Id, 2585, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View all </a></td>\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2707, "\"", 2744, 2);
            WriteAttributeValue("", 2714, "/Manage/store/Edit?id=", 2714, 22, true);
#nullable restore
#line 63 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Areas\Manage\Views\Store\Index.cshtml"
WriteAttributeValue("", 2736, item.Id, 2736, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success btn-sm\"><i class=\"fa fa-edit\"></i></a>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2855, "\"", 2894, 2);
            WriteAttributeValue("", 2862, "/Manage/store/Delete?id=", 2862, 24, true);
#nullable restore
#line 64 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Areas\Manage\Views\Store\Index.cshtml"
WriteAttributeValue("", 2886, item.Id, 2886, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\"><i class=\"fa fa-trash\"></i></a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 67 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Areas\Manage\Views\Store\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GS.DATA.Entities.Shop.Store>> Html { get; private set; }
    }
}
#pragma warning restore 1591
