#pragma checksum "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d303b3b30067d4d2c562023330909ff65f0482b6efe2451183b9b1caf332c77f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__TeamPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_TeamPartial/Default.cshtml")]
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
#line 1 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d303b3b30067d4d2c562023330909ff65f0482b6efe2451183b9b1caf332c77f", @"/Views/Shared/Components/_TeamPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c99b8e539a5aecac94d942c197af0d3c91f594e3271bc2c3354068a48e7228bf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__TeamPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Team>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""team"" id=""team"">
    <div class=""container"">

        <h3 class=""tittle"">EKİP ARKADAŞLARIMIZ</h3>
        <p class=""heading-btm-w3ls"">Birbirinden Farklı Konularda  Oldukça Donanımlı Ekip Arkadaşlarımız</p>

        <div class=""wthree_team_grids"">
");
#nullable restore
#line 11 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 wthree_team_grid\">\r\n                    <div class=\"hovereffect\">\r\n                       \r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 530, "\"", 550, 1);
#nullable restore
#line 16 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml"
WriteAttributeValue("", 536, item.ImageUrl, 536, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-responsive"" />
                       
                        <div class=""overlay"">
                            <div class=""rotate"">
                                
                                <p class=""group1"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 825, "\"", 848, 1);
#nullable restore
#line 22 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml"
WriteAttributeValue("", 832, item.TwitterUrl, 832, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <i class=\"fa fa-twitter\"></i>\r\n                                    </a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1003, "\"", 1027, 1);
#nullable restore
#line 25 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml"
WriteAttributeValue("", 1010, item.FacebookUrl, 1010, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""fa fa-facebook""></i>
                                    </a>
                                </p>

                                <hr> <hr>
                               
                                <p class=""group2"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 1351, "\"", 1376, 1);
#nullable restore
#line 33 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml"
WriteAttributeValue("", 1358, item.InstagramUrl, 1358, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <i class=\"fa fa-instagram\"></i>\r\n                                    </a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1533, "\"", 1556, 1);
#nullable restore
#line 36 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml"
WriteAttributeValue("", 1540, item.WebsiteUrl, 1540, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""fa fa-dribbble""></i>
                                    </a>
                                </p>

                            </div>
                        </div>
                    </div>
                   
                    <h4>");
#nullable restore
#line 45 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml"
                   Write(item.PersonName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 45 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml"
                                    Write(item.PersonSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p>");
#nullable restore
#line 46 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml"
                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                </div>\r\n");
#nullable restore
#line 49 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_TeamPartial\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"clearfix\"> </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
