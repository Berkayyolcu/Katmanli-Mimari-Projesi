#pragma checksum "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_SocialMediaPartial\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bc28d7e2ce6a63d3eff807dd68da69280d37ff404d4d7b191c46561ac580f756"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__SocialMediaPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_SocialMediaPartial/Default.cshtml")]
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
#line 1 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_SocialMediaPartial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bc28d7e2ce6a63d3eff807dd68da69280d37ff404d4d7b191c46561ac580f756", @"/Views/Shared/Components/_SocialMediaPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c99b8e539a5aecac94d942c197af0d3c91f594e3271bc2c3354068a48e7228bf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__SocialMediaPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SocialMedia>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"w3l_header_right\">\r\n    <div class=\"w3ls-social-icons text-left\">\r\n");
#nullable restore
#line 6 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_SocialMediaPartial\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("class", " class=\"", 199, "\"", 218, 1);
#nullable restore
#line 8 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_SocialMediaPartial\Default.cshtml"
WriteAttributeValue("", 207, item.Title, 207, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 219, "\"", 235, 1);
#nullable restore
#line 8 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_SocialMediaPartial\Default.cshtml"
WriteAttributeValue("", 226, item.Url, 226, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 239, "\"", 257, 1);
#nullable restore
#line 8 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_SocialMediaPartial\Default.cshtml"
WriteAttributeValue("", 247, item.Icon, 247, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n");
#nullable restore
#line 9 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_SocialMediaPartial\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SocialMedia>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
