#pragma checksum "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_AnnouncementPartial\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6c2d4b7ad9b1aa3a2000dbd1408a3897e690c62a6174d7b812aabd1792079c9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__AnnouncementPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_AnnouncementPartial/Default.cshtml")]
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
#line 1 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_AnnouncementPartial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6c2d4b7ad9b1aa3a2000dbd1408a3897e690c62a6174d7b812aabd1792079c9f", @"/Views/Shared/Components/_AnnouncementPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c99b8e539a5aecac94d942c197af0d3c91f594e3271bc2c3354068a48e7228bf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__AnnouncementPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/images/b1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/images/b2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(" "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/images/b3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""blog"" id=""blog"">
    <div class=""container"">

        <h3 class=""tittle"">Son Haberler</h3>
        <p class=""heading-btm-w3ls"">Çiftliklerimizden ve Tarlalarımızdan Son Haberler Buradadır.</p>

        <div class=""blog-grid-w3-agileits"">
");
#nullable restore
#line 11 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_AnnouncementPartial\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 391, "\"", 410, 1);
#nullable restore
#line 13 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_AnnouncementPartial\Default.cshtml"
WriteAttributeValue("", 399, item.Sınıf, 399, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a href=\"#\" data-toggle=\"modal\" data-target=\"");
#nullable restore
#line 14 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_AnnouncementPartial\Default.cshtml"
                                                            Write(item.Modal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></a>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"col-md-5 blog-info-w3layouts\">\r\n                    <h6> <a href=\"#\" data-toggle=\"modal\" data-target=\"");
#nullable restore
#line 18 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_AnnouncementPartial\Default.cshtml"
                                                                 Write(item.Modal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 18 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_AnnouncementPartial\Default.cshtml"
                                                                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n\r\n                    <div class=\"inner-info\">\r\n                        <a class=\"blog-text-w3ls bar\">Haber Yayınlanma Tarihi :</a><span>");
#nullable restore
#line 21 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_AnnouncementPartial\Default.cshtml"
                                                                                    Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <p class=\"para-w3-agileits\">");
#nullable restore
#line 22 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_AnnouncementPartial\Default.cshtml"
                                               Write(item.Description.ToString().Substring(0, 67));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                    <a href=\"#\" class=\"blog-more-agile\" data-toggle=\"modal\" data-target=\"");
#nullable restore
#line 25 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_AnnouncementPartial\Default.cshtml"
                                                                                    Write(item.Modal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Read More</a>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"clearfix\"></div>\r\n                <br />\r\n");
#nullable restore
#line 30 "C:\Users\Byolcu\source\repos\AgriculturePresentation\AgriculturePresentation\Views\Shared\Components\_AnnouncementPartial\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>


<!-- Modal2 -->
<div class=""modal fade"" id=""#myModal2"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"">
        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4>In Harvest</h4>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6c2d4b7ad9b1aa3a2000dbd1408a3897e690c62a6174d7b812aabd1792079c9f10130", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <h5>FURTHER DEVELOPMENT IN AGRICULTURE GROWTH</h5>
                <p>
                    Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                    Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
                    when an unknown printer took a galley of type and scrambled it to make a type
                    specimen book. It has survived not only five centuries, but also the leap into
                    electronic typesetting.
                </p>
            </div>
        </div>
    </div>
</div>


<!-- Modal3 -->
    <div class=""modal fade"" id=""#myModal3"" tabindex=""-1"" role=""dialog"">
        <div class=""modal-dialog"">
            <!-- Modal content-->
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                    <h4>In Harvest</h4>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6c2d4b7ad9b1aa3a2000dbd1408a3897e690c62a6174d7b812aabd1792079c9f12300", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <h5>KEEPING ON ADVANCING THE AGRICULTURE INDUSTRY</h5>
                    <p>
                        Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                        Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 
                        when an unknown printer took a galley of type and scrambled it to make a type 
                        specimen book. It has survived not only five centuries, but also the leap into 
                        electronic typesetting.
                    </p>
                </div>
            </div>
        </div>
    </div>


<!-- Modal4 -->
    <div class=""modal fade"" id=""#myModal4"" tabindex=""-1"" role=""dialog"">
        <div class=""modal-dialog"">
            <!-- Modal content-->
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                ");
            WriteLiteral("    <h4>In Harvest</h4>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6c2d4b7ad9b1aa3a2000dbd1408a3897e690c62a6174d7b812aabd1792079c9f14641", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <h5>OUR FIRST STEPS ON THE MARKET AMONG AGRICULTURAL COMPANIES</h5>
                    <p>
                        Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                        Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
                        when an unknown printer took a galley of type and scrambled it to make a type
                        specimen book. It has survived not only five centuries, but also the leap into
                        electronic typesetting.
                    </p>
                </div>
            </div>
        </div>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Announcement>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
