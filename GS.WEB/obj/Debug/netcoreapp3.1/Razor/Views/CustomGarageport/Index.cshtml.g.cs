#pragma checksum "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\CustomGarageport\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "798ab6df70ad092de6b55437e26ce68f7eff2c98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomGarageport_Index), @"mvc.1.0.view", @"/Views/CustomGarageport/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"798ab6df70ad092de6b55437e26ce68f7eff2c98", @"/Views/CustomGarageport/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"551d6c05c19596f8e24527e7dd725dfab8f6ff76", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomGarageport_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GS.DATA.Entities.CustomPort.BaseGaragePort>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\CustomGarageport\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<hr class=""offset-lg"">
<hr class=""offset-lg"">
<hr class=""offset-lg hidden-xs"">
<section class=""product"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-5 col-md-5 white no-padding"">

                <div class=""carousel-product"" data-count=""4"" data-current=""1"">

                    <div class=""items"" style=""height:370px"">
                        <button class=""btn btn-control"" data-direction=""right""> <i class=""ion-ios-arrow-right""></i></button>
                        <button class=""btn btn-control"" data-direction=""left""> <i class=""ion-ios-arrow-left""></i></button>


                        <div class=""item center"" data-marker=""1"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 818, "\"", 853, 1);
#nullable restore
#line 21 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\CustomGarageport\Index.cshtml"
WriteAttributeValue("", 824, Url.Content(Model.BaseImage), 824, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Microsoft Surface Studio\" class=\"background\" />\r\n                        </div>\r\n\r\n                        <div class=\"item\" data-marker=\"2\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1035, "\"", 1067, 1);
#nullable restore
#line 25 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\CustomGarageport\Index.cshtml"
WriteAttributeValue("", 1041, Url.Content(Model.Image1), 1041, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Microsoft Surface Studio\" class=\"background\" />\r\n                        </div>\r\n\r\n                        <div class=\"item\" data-marker=\"3\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1249, "\"", 1281, 1);
#nullable restore
#line 29 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\CustomGarageport\Index.cshtml"
WriteAttributeValue("", 1255, Url.Content(Model.Image2), 1255, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Microsoft Surface Studio"" class=""background"" />
                        </div>

                    </div>


                    <ul class=""markers"">
                        <li data-marker=""1"" class=""active""></li>
                        <li data-marker=""2""></li>
                        <li data-marker=""3""></li>
                    </ul>

                </div>
            </div>
            <div class=""col-sm-7 col-md-7 no-padding-xs"">
                <div class=""caption"">
                    <h1 class=""text-themecolor"">Customize Compact +</h1>
                    <div>");
#nullable restore
#line 46 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\CustomGarageport\Index.cshtml"
                    Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    Totalt inkl. moms.:\r\n                    <div id=\"diivprice\">\r\n                        <h4 style=\"color:black\">");
#nullable restore
#line 49 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\CustomGarageport\Index.cshtml"
                                           Write(Model.BasePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                    </div>
                    <hr class=""offset-md hidden-sm"">
                    <hr class=""offset-sm visible-sm"">
                    <hr class=""offset-xs visible-sm"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div id=""errorwidth""></div>
                            <div id=""errorheight""></div>
                        </div>
                        <div class=""col-md-6"">
                            <label class=""control-label"">Width(in mm)</label>
                            <input id=""widthrole""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2676, "\"", 2690, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" value=\"1800\" />\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <label class=\"control-label\">Height(in mm)</label>\r\n                            <input id=\"heightrole\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2940, "\"", 2954, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" value=\"1850\" />\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <label class=\"control-label\">Pattern</label>\r\n                            ");
#nullable restore
#line 69 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\CustomGarageport\Index.cshtml"
                       Write(Html.DropDownList("patternrole", (SelectList)ViewBag.patternlist, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <label class=\"control-label\">Color</label>\r\n                            ");
#nullable restore
#line 73 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\CustomGarageport\Index.cshtml"
                       Write(Html.DropDownList("colorrole", (SelectList)ViewBag.colorlist, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <label class=\"control-label\">Surface layer</label>\r\n                            ");
#nullable restore
#line 77 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\CustomGarageport\Index.cshtml"
                       Write(Html.DropDownList("surfacelayerrole", (SelectList)ViewBag.surfacelayerlist, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <label class=\"control-label\">Operation</label>\r\n                            ");
#nullable restore
#line 81 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\CustomGarageport\Index.cshtml"
                       Write(Html.DropDownList("operationrole", (SelectList)ViewBag.operationstylelist, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>

                    </div>
                    <hr class=""offset-md hidden-sm"">
                    <hr class=""offset-sm visible-sm"">
                    <hr class=""offset-xs visible-sm"">
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <label>Quantity</label>
                                </div>
                                <div class=""col-md-6"">
                                    <input type=""number"" class=""form-control input-sm"" placeholder=""Qty"" value=""1"">
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-8"">
                            <div class=""text-right"">
                                <button class=""btn btn-primary""> <i class=""ion-bag""></i> Add to cart</button>
           ");
            WriteLiteral(@"                 </div>
                        </div>

                        <div class=""col-md-12"">
                            <div class=""text-center"">
                                <hr>
                                <p class=""text-themecolor"">Beräknad leveranstid är 4-5 veckor.</p>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
        <hr class=""offset-sm hidden-xs"">

        <div class=""row"">
            <div class=""col-sm-12 white sm-padding"">



                <div class=""tabset"">
                    <input type=""radio"" name=""tabset"" id=""tab1"" aria-controls=""Produktbeskrivning"" checked>
                    <label for=""tab1"">
                        Produktbeskrivning
                    </label>
                    <input type=""radio"" name=""tabset"" id=""tab2"" aria-controls=""Specifikationer"">
                    <label for=""tab2"">
                        Specifikati");
            WriteLiteral(@"oner
                    </label>
                    <input type=""radio"" name=""tabset"" id=""tab3"" aria-controls=""Dokument"">
                    <label for=""tab3"">
                        Dokument
                    </label>
                    <input type=""radio"" name=""tabset"" id=""tab4"" aria-controls=""Instructions"">
                    <label for=""tab4"">
                        Instructions
                    </label>

                    <div class=""tab-panels"">
                        <section id=""Produktbeskrivning"" class=""tab-panel"">
                            ");
#nullable restore
#line 143 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\CustomGarageport\Index.cshtml"
                       Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </section>\r\n                        <section id=\"Specifikationer\" class=\"tab-panel\">\r\n                            ");
#nullable restore
#line 146 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\CustomGarageport\Index.cshtml"
                       Write(Html.Raw(Model.TechnicalSpecification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </section>\r\n                        <section id=\"Dokument\" class=\"tab-panel\">\r\n                            <ul>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 7164, "\"", 7203, 1);
#nullable restore
#line 150 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\CustomGarageport\Index.cshtml"
WriteAttributeValue("", 7171, Url.Content(Model.DocumentFile), 7171, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 150 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\CustomGarageport\Index.cshtml"
                                                                          Write(Model.DocumentFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 7273, "\"", 7313, 1);
#nullable restore
#line 151 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\CustomGarageport\Index.cshtml"
WriteAttributeValue("", 7280, Url.Content(Model.DocumentFile1), 7280, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 151 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\CustomGarageport\Index.cshtml"
                                                                           Write(Model.DocumentFile1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            </ul>\r\n                        </section>\r\n                        <section id=\"Instructions\" class=\"tab-panel\">\r\n                            ");
#nullable restore
#line 155 "C:\Users\Asifs\Desktop\GarageSpecialisten\GS.WEB\Views\CustomGarageport\Index.cshtml"
                       Write(Html.Raw(Model.Instruction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </section>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(document).ready(function () {

            $(""#searchbtn"").click(function (e) {
                $(""#mdlsearch"").modal('show');
            });

        });
        function CalculatePrice() {
            var url = ""/CustomGarageport/CalculatePrice"";
            var width = $(""#widthrole"").val();
            var height = $(""#heightrole"").val();
            var pattern = $(""#patternrole"").val();
            var color = $(""#colorrole"").val();
            var surfacelayer = $(""#surfacelayerrole"").val();
            var operation = $(""#operationrole"").val();
            $.getJSON(url, { width: width, height: height, pattern: pattern, color: color, surfacelayer: surfacelayer, operation: operation }, function (data) {
                var item = """";
                $(""#diivprice"").empty();
                item = '<h4 style=""color:black"">' + data + '</h4>';

                $(""#diivprice"").html(item);
            });
        }

        $(""#patt");
                WriteLiteral(@"ernrole"").change(function () {
            var patternrole = $(""#patternrole"").val();
            var url = ""/CustomGarageport/GetSurfaceLayerRole"";

            $.getJSON(url, { patternrole: patternrole }, function (data) {
                var item = """";
                $(""#surfacelayerrole"").empty();
                $.each(data, function (i, locks) {
                    item += '<option value=""' + locks.value + '"">' + locks.text + '</option>'
                });
                $(""#surfacelayerrole"").html(item);
            });
            CalculatePrice();
        });

        $(""#colorrole"").change(function () {
            CalculatePrice();
        });
        $(""#surfacelayerrole"").change(function () {
            CalculatePrice();
        });

        $(""#oldDoorrole"").change(function () {
            CalculatePrice();
        });
        $(""#widthrole"").change(function () {
            var value = $(""#widthrole"").val();
            if (value < 1800) {
                var it");
                WriteLiteral(@"em = """";
                $(""#errorwidth"").empty();
                item = '<p style=""color:black"">Width must be bigger than 1800</p>';

                $(""#errorwidth"").html(item);
            }
            else if (value > 4500) {
                var item = """";
                $(""#errorwidth"").empty();
                item = '<p style=""color:black"">Width must be smaller than 4500</p>';

                $(""#errorwidth"").html(item);
            }
            else {
                $(""#errorwidth"").empty();
                CalculatePrice();
            }
        });
        $(""#heightrole"").change(function () {
            var value = $(""#heightrole"").val();
            if (value < 1850) {
                var item = """";
                $(""#errorheight"").empty();
                item = '<p style=""color:black"">Width must be bigger than 1850</p>';

                $(""#errorheight"").html(item);
            }
            else if (value > 2500) {
                var item = """";
           ");
                WriteLiteral(@"     $(""#errorheight"").empty();
                item = '<p style=""color:black"">Width must be smaller than 2500</p>';

                $(""#errorheight"").html(item);
            }
            else {
                $(""#errorheight"").empty();
                CalculatePrice();
            }
        });

        $(""#operationrole"").change(function () {
            var operationrole = $(""#operationrole"").val();

            CalculatePrice();
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GS.DATA.Entities.CustomPort.BaseGaragePort> Html { get; private set; }
    }
}
#pragma warning restore 1591
