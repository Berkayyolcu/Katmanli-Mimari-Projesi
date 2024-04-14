#pragma checksum "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Team\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f2317f52741a5a042b3ad821cfa73eccf6cd8a19fa7d9f33b17129d1073fc5fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_Index), @"mvc.1.0.view", @"/Views/Team/Index.cshtml")]
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
#line 1 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Team\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f2317f52741a5a042b3ad821cfa73eccf6cd8a19fa7d9f33b17129d1073fc5fb", @"/Views/Team/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c99b8e539a5aecac94d942c197af0d3c91f594e3271bc2c3354068a48e7228bf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Team_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Team>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Team\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">TAKIM BİLGİ LİSTESİ SAYFASI</h4>
            <div class=""table-responsive"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Görsel</th>
                            <th>Ad</th>
                            <th>Soyad</th>
                            <th>Görev</th>
                            <th>Sil</th>
                            <th>Güncelle</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 27 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Team\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"py-1\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1076, "\"", 1096, 1);
#nullable restore
#line 31 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Team\Index.cshtml"
WriteAttributeValue("", 1082, item.ImageUrl, 1082, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" />                                   \r\n                                </td>\r\n                                <td>");
#nullable restore
#line 33 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Team\Index.cshtml"
                               Write(item.TeamID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 34 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Team\Index.cshtml"
                               Write(item.PersonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 35 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Team\Index.cshtml"
                               Write(item.PersonSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 36 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Team\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1456, "\"", 1492, 2);
            WriteAttributeValue("", 1463, "/Team/DeleteTeam/", 1463, 17, true);
#nullable restore
#line 37 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Team\Index.cshtml"
WriteAttributeValue("", 1480, item.TeamID, 1480, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1577, "\"", 1613, 2);
            WriteAttributeValue("", 1584, "/Team/UpdateTeam/", 1584, 17, true);
#nullable restore
#line 38 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Team\Index.cshtml"
WriteAttributeValue("", 1601, item.TeamID, 1601, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Güncelle</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Team\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <br />\r\n                <a href=\"/Team/AddTeam/\" class=\"btn btn-outline-info\">Yeni Takım Arkadaşı Ekle</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Team>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
