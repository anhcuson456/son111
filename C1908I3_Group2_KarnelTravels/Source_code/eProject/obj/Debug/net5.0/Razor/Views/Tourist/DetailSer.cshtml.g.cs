#pragma checksum "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65afc438976978b937e4a1fa0b464746a82c4020"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tourist_DetailSer), @"mvc.1.0.view", @"/Views/Tourist/DetailSer.cshtml")]
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
#line 6 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65afc438976978b937e4a1fa0b464746a82c4020", @"/Views/Tourist/DetailSer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    public class Views_Tourist_DetailSer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eProject.Models.Servi>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "tourist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("240"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "commentSer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
  
    ViewData["Title"] = "detailser";
    Layout = "~/Views/Share/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""main"">

    <!-- ======= Breadcrumbs ======= -->
    <section id=""breadcrumbs"" class=""breadcrumbs"">
        <div class=""container"">

            <div class=""d-flex justify-content-between align-items-center"">
                <h2>Tourist Details</h2>
                <ol>
                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65afc438976978b937e4a1fa0b464746a82c40206415", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65afc438976978b937e4a1fa0b464746a82c40207803", async() => {
                WriteLiteral("Tourist infomation");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("asp-", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    <li>Detail hotel & restaurant</li>
                </ol>
            </div>

        </div>
    </section><!-- End Breadcrumbs -->
    <!-- ======= Tourist Details Section ======= -->
    <section id=""portfolio-details"" class=""portfolio-details"">
        <div class=""container"">
            <div class=""row gy-4"">

                <div class=""col-lg-8"">
                    <div class=""portfolio-details-slider swiper-container"">
                        <div class=""swiper-wrapper align-items-center"">
");
#nullable restore
#line 33 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
                             foreach (var image in ViewBag.service.Imgs)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"swiper-slide\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "65afc438976978b937e4a1fa0b464746a82c402010415", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1383, "~/Img/", 1383, 6, true);
#nullable restore
#line 36 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
AddHtmlAttributeValue("", 1389, image.Name, 1389, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 38 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <div class=""swiper-pagination""></div>
                        <div>
                            <h4 class=""d-none d-lg-block"">Related vehicles </h4>
                            <ul class=""nav nav-tabs row d-flex"">
");
#nullable restore
#line 44 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
                                 foreach (var travel in ViewBag.service.ServiTravels)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <li class=""nav-item col-3"" data-aos=""zoom-in"" data-aos-delay=""100"">
                                        <a class=""nav-link"" data-bs-toggle=""tab"" href=""#tab-2"">
                                            <i class=""ri-body-scan-line"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65afc438976978b937e4a1fa0b464746a82c402013069", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2163, "~/Img/", 2163, 6, true);
#nullable restore
#line 48 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
AddHtmlAttributeValue("", 2169, travel.Travel.Img, 2169, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</i>\r\n                                            <h4 class=\"d-none d-lg-block\">");
#nullable restore
#line 49 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
                                                                     Write(travel.Travel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        </a>\r\n                                    </li>\r\n");
#nullable restore
#line 52 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"col-lg-4\">\r\n                    <div class=\"portfolio-info\">\r\n                        <h3>");
#nullable restore
#line 60 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
                       Write(ViewBag.service.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" information</h3>\r\n\r\n\r\n                        <ul>\r\n                            <li><strong>Address </strong>: ");
#nullable restore
#line 64 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
                                                      Write(ViewBag.service.Addr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><strong>Category </strong>: ");
#nullable restore
#line 65 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
                                                       Write(ViewBag.service.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><strong>Price : form </strong> ");
#nullable restore
#line 66 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
                                                          Write(ViewBag.service.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</li>\r\n                            <li><strong>Tourist </strong>: ");
#nullable restore
#line 67 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
                                                      Write(ViewBag.service.Tour.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ul>\r\n                    </div>\r\n                    <div class=\"portfolio-description\">\r\n                        <h2>Description </h2>\r\n                        <p class=\"fst-italic\">\r\n                            ");
#nullable restore
#line 73 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
                       Write(ViewBag.service.Descrip);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                    </div>
                </div>

            </div>

        </div>

    </section><!-- End Portfolio Details Section -->
    <section id=""team"" class=""team"">
        <div class=""container"">
            <h2><i>Comment</i></h2>
            <div class=""section-title"" data-aos=""zoom-out"">
");
#nullable restore
#line 87 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
                 if (Context.Session.GetString("username") != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65afc438976978b937e4a1fa0b464746a82c402018356", async() => {
                WriteLiteral(@"
                        <div class=""col-md-7 col-sm-5 col-xs-12 form-group pull-right top_search"">
                            <div class=""input-group"">
                                <input type=""text"" name=""Content"" class=""form-control"" placeholder=""Your comment..."">
                                <span class=""input-group-btn"">
                                    <input type=""submit"" class=""btn btn-secondary"" value=""Go !"" />
                                    <input type=""hidden"" name=""ServiId""");
                BeginWriteAttribute("value", " value=\"", 4430, "\"", 4457, 1);
#nullable restore
#line 95 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
WriteAttributeValue("", 4438, ViewBag.service.Id, 4438, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                </span>\r\n                            </div>\r\n                        </div>\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 101 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 103 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
             foreach (var cmt in ViewBag.service.Comments)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p><b>");
#nullable restore
#line 105 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
                 Write(cmt.Acc.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" :</b> ");
#nullable restore
#line 105 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
                                     Write(cmt.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 106 "C:\eProject\eProject\eProject\Views\Tourist\DetailSer.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </section>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eProject.Models.Servi> Html { get; private set; }
    }
}
#pragma warning restore 1591
