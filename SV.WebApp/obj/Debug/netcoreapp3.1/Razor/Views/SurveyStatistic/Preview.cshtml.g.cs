#pragma checksum "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "598e0c84ec7f78fa72ccd578f7d4b3c227e8e574"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SurveyStatistic_Preview), @"mvc.1.0.view", @"/Views/SurveyStatistic/Preview.cshtml")]
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
#line 1 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\_ViewImports.cshtml"
using SV.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\_ViewImports.cshtml"
using SV.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\_ViewImports.cshtml"
using SV.WebApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
using SV.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"598e0c84ec7f78fa72ccd578f7d4b3c227e8e574", @"/Views/SurveyStatistic/Preview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d25336d0c18f3e1fdf2947ea67e1c8f988f4f74", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SurveyStatistic_Preview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LauchSurveyViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/sv/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:53px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PreviewQuestion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/sv/js/Preview.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
  
    ViewBag.Title = $"{Model.Survey.Name} - Survey";
    Layout = "~/Views/Shared/_SurveyPreviewLayout.cshtml";

    ViewData["Language"] = Model.Survey.Language;

    var childQuestions = Model.Options.Where(m => m.Question.ParentQuestionId != null || m.Question.ParentQuestionId != 0);
    Model.Options = Model.Options.Where(m => m.Question.ParentQuestionId == null || m.Question.ParentQuestionId == 0).ToList();

    int totalQuestions = Model.Options.Count;
    int questionsPerPage = (int)Model.Survey.QuestionPerPage;
    int totalPages = (int)Math.Ceiling((float)totalQuestions / (float)questionsPerPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n\r\n");
#nullable restore
#line 20 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
     if (totalPages > 0)
    {
        for (int staringPageCounter = 1; staringPageCounter <= totalPages; staringPageCounter++)
        {
            int startingIndex = (staringPageCounter - 1) * questionsPerPage;
            int endingIndex = startingIndex + questionsPerPage;




#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"uniForm\"");
            BeginWriteAttribute("id", " id=\"", 1026, "\"", 1057, 2);
            WriteAttributeValue("", 1031, "screen-", 1031, 7, true);
#nullable restore
#line 29 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
WriteAttributeValue("", 1038, staringPageCounter, 1038, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none;\">\r\n                <div class=\"header \">\r\n                    <div class=\"row fr_head\">\r\n                        <div class=\"uniform-surveyTitle\">\r\n                            ");
#nullable restore
#line 33 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
                       Write(Model.Survey.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-4 uniform-surveyLogo\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "598e0c84ec7f78fa72ccd578f7d4b3c227e8e5747588", async() => {
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
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <!--<div class=\"row fr_heading\">\r\n                        <div class=\"col-md-12\" style=\"padding: 0px 30px;\">\r\n                            <h2>");
#nullable restore
#line 41 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
                           Write(Model.Survey.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>-->\r\n");
            WriteLiteral("                            <!--<p>&nbsp;</p>\r\n                        </div>\r\n                    </div>-->\r\n                </div>\r\n\r\n");
#nullable restore
#line 48 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
                 for (int x = startingIndex; x < endingIndex; x++)
                {
                    if (x < Model.Options.Count)
                    {
                        var option = Model.Options[x];
                        TempData["IsParentQuestion"] = true;
                        option.AnswerIndex = x;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "598e0c84ec7f78fa72ccd578f7d4b3c227e8e5749916", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 55 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = option;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 56 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
                    }

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 60 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
                 if (staringPageCounter == totalPages)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"buttonHolder\">\r\n");
#nullable restore
#line 63 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
                         if (staringPageCounter != 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"button\" class=\"primaryAction\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2621, "\"", 2681, 6);
            WriteAttributeValue("", 2631, "SSShowPage((", 2631, 12, true);
#nullable restore
#line 65 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
WriteAttributeValue("", 2643, staringPageCounter, 2643, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2662, "-", 2663, 2, true);
            WriteAttributeValue(" ", 2664, "1),", 2665, 4, true);
#nullable restore
#line 65 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
WriteAttributeValue(" ", 2668, totalPages, 2669, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2680, ")", 2680, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Previous</button>\r\n");
#nullable restore
#line 66 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 68 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"buttonHolder\">\r\n");
#nullable restore
#line 72 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
                         if (staringPageCounter != 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"button\" class=\"primaryAction\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3018, "\"", 3078, 6);
            WriteAttributeValue("", 3028, "SSShowPage((", 3028, 12, true);
#nullable restore
#line 74 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
WriteAttributeValue("", 3040, staringPageCounter, 3040, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3059, "-", 3060, 2, true);
            WriteAttributeValue(" ", 3061, "1),", 3062, 4, true);
#nullable restore
#line 74 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
WriteAttributeValue(" ", 3065, totalPages, 3066, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3077, ")", 3077, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Previous</button>\r\n");
#nullable restore
#line 75 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button type=\"button\" class=\"primaryAction\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3193, "\"", 3253, 6);
            WriteAttributeValue("", 3203, "SSShowPage((", 3203, 12, true);
#nullable restore
#line 76 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
WriteAttributeValue("", 3215, staringPageCounter, 3215, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3234, "+", 3235, 2, true);
            WriteAttributeValue(" ", 3236, "1),", 3237, 4, true);
#nullable restore
#line 76 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
WriteAttributeValue(" ", 3240, totalPages, 3241, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3252, ")", 3252, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Next</button>\r\n                    </div>\r\n");
#nullable restore
#line 78 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n");
            WriteLiteral("            <div id=\"footer\"");
            BeginWriteAttribute("class", " class=\"", 3371, "\"", 3405, 2);
            WriteAttributeValue("", 3379, "footer-", 3379, 7, true);
#nullable restore
#line 83 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
WriteAttributeValue("", 3386, staringPageCounter, 3386, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none;\">\r\n                <p>?? 2021 - Bank Nizwa Survey Application</p>\r\n            </div>\r\n");
#nullable restore
#line 86 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "598e0c84ec7f78fa72ccd578f7d4b3c227e8e57417476", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        if(\'");
#nullable restore
#line 95 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Preview.cshtml"
       Write(Model.Survey.Language);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' == 'Arabic'){
            $('html').attr('dir', 'rtl');
            
        }

        function SSShowPage(pageNo, totalPages) {

            $('[id*=screen]').each(function () {
                $(this).hide();
            });

            $('[id*=footer]').each(function () {
                $(this).hide();
            });

            $('#screen-' + pageNo + ', .footer-' + pageNo).show();
            window.scrollTo(0, 0);

            var percentage = Math.floor(((pageNo - 1) / totalPages) * 100);

            progressbar.progressbar(""value"", percentage);
        }
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LauchSurveyViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
