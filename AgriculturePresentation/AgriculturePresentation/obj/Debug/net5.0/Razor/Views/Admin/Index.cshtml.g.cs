#pragma checksum "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Admin\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ee84253e0ae1ebf87206bea45f0f29f21c8bacc759919294ccb11b831c8333c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\_ViewImports.cshtml"
using AgriculturePresentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\_ViewImports.cshtml"
using AgriculturePresentation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Admin\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ee84253e0ae1ebf87206bea45f0f29f21c8bacc759919294ccb11b831c8333c3", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c99b8e539a5aecac94d942c197af0d3c91f594e3271bc2c3354068a48e7228bf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Admin>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">ADMİN BİLGİ SAYFASI</h4>
            <div class=""table-responsive pt-3"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Kullanıcı Adı</th>
                            <th>Tarih</th>
                            <th>Resim</th>
                            <th>Sil</th>
                            <th>Güncelle</th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 27 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Admin\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 30 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Admin\Index.cshtml"
                               Write(item.AdminID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 31 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Admin\Index.cshtml"
                               Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1103, "\"", 1142, 2);
            WriteAttributeValue("", 1110, "/Admin/DeleteAdmin/", 1110, 19, true);
#nullable restore
#line 32 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1129, item.AdminID, 1129, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1227, "\"", 1266, 2);
            WriteAttributeValue("", 1234, "/Admin/UpdateAdmin/", 1234, 19, true);
#nullable restore
#line 33 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1253, item.AdminID, 1253, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Güncelle</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Admin\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <br />\r\n                <a href=\"/Admin/AddAdmin/\" class=\"btn btn-outline-info\">Admin Ekle</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Admin>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
