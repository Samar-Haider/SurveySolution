#pragma checksum "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf4b86513f3038a412e311ab8a0c25a4ffd305ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Survey_Preview), @"mvc.1.0.view", @"/Views/Survey/Preview.cshtml")]
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
#line 1 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
using SV.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf4b86513f3038a412e311ab8a0c25a4ffd305ca", @"/Views/Survey/Preview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1190a92d7293542a140bd67903d20c4c77e3e4b1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Survey_Preview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LauchSurveyViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/sv/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:53px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PreviewQuestion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("surveyForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/sv/js/Preview.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
  
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
            WriteLiteral("\r\n<div id=\"progressbar\"><div class=\"progress-label\">0%</div></div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf4b86513f3038a412e311ab8a0c25a4ffd305ca7322", async() => {
                WriteLiteral("\r\n\r\n    <input type=\"hidden\" name=\"surveyId\"");
                BeginWriteAttribute("value", " value=\"", 870, "\"", 894, 1);
#nullable restore
#line 21 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
WriteAttributeValue("", 878, Model.Survey.Id, 878, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n");
#nullable restore
#line 23 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
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
                BeginWriteAttribute("id", " id=\"", 1225, "\"", 1256, 2);
                WriteAttributeValue("", 1230, "screen-", 1230, 7, true);
#nullable restore
#line 32 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
WriteAttributeValue("", 1237, staringPageCounter, 1237, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display: none;\">\r\n                <div class=\"header \">\r\n                    <div class=\"row fr_head\">\r\n                        <div class=\"uniform-surveyTitle\">\r\n                            ");
#nullable restore
#line 36 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
                       Write(Model.Survey.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-4 uniform-surveyLogo\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bf4b86513f3038a412e311ab8a0c25a4ffd305ca9551", async() => {
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
#line 44 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
                           Write(Model.Survey.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>-->\r\n");
                WriteLiteral("                            <!--<p>&nbsp;</p>\r\n                        </div>\r\n                    </div>-->\r\n                </div>\r\n\r\n");
#nullable restore
#line 51 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
                 for (int x = startingIndex; x < endingIndex; x++)
                {
                    if (x < Model.Options.Count)
                    {
                        var option = Model.Options[x];
                        TempData["IsParentQuestion"] = true;
                        option.AnswerIndex = x;

                        if (option.Question.Type == "Logic")
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bf4b86513f3038a412e311ab8a0c25a4ffd305ca12028", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 61 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
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
#line 64 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
                                                                                  
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bf4b86513f3038a412e311ab8a0c25a4ffd305ca14035", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 68 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
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
                WriteLiteral("   \r\n");
#nullable restore
#line 69 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
                        }
                    }

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 74 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
                 if (staringPageCounter == totalPages)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"buttonHolder\">\r\n");
#nullable restore
#line 77 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
                         if (staringPageCounter != 1)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <button type=\"button\" class=\"primaryAction\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3399, "\"", 3457, 6);
                WriteAttributeValue("", 3409, "ShowPage((", 3409, 10, true);
#nullable restore
#line 79 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
WriteAttributeValue("", 3419, staringPageCounter, 3419, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 3438, "-", 3439, 2, true);
                WriteAttributeValue(" ", 3440, "1),", 3441, 4, true);
#nullable restore
#line 79 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
WriteAttributeValue(" ", 3444, totalPages, 3445, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3456, ")", 3456, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Previous</button>\r\n");
#nullable restore
#line 80 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button class=\"primaryAction\" type=\"submit\">Submit</button>\r\n                    </div>\r\n");
#nullable restore
#line 83 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"buttonHolder\">\r\n");
#nullable restore
#line 87 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
                         if (staringPageCounter != 1)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <button type=\"button\" class=\"primaryAction\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3879, "\"", 3937, 6);
                WriteAttributeValue("", 3889, "ShowPage((", 3889, 10, true);
#nullable restore
#line 89 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
WriteAttributeValue("", 3899, staringPageCounter, 3899, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 3918, "-", 3919, 2, true);
                WriteAttributeValue(" ", 3920, "1),", 3921, 4, true);
#nullable restore
#line 89 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
WriteAttributeValue(" ", 3924, totalPages, 3925, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3936, ")", 3936, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Previous</button>\r\n");
#nullable restore
#line 90 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"button\" class=\"primaryAction\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4052, "\"", 4110, 6);
                WriteAttributeValue("", 4062, "ShowPage((", 4062, 10, true);
#nullable restore
#line 91 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
WriteAttributeValue("", 4072, staringPageCounter, 4072, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 4091, "+", 4092, 2, true);
                WriteAttributeValue(" ", 4093, "1),", 4094, 4, true);
#nullable restore
#line 91 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
WriteAttributeValue(" ", 4097, totalPages, 4098, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4109, ")", 4109, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Next</button>\r\n                    </div>\r\n");
#nullable restore
#line 93 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </div>\r\n");
                WriteLiteral("            <div id=\"footer\"");
                BeginWriteAttribute("class", " class=\"", 4228, "\"", 4262, 2);
                WriteAttributeValue("", 4236, "footer-", 4236, 7, true);
#nullable restore
#line 98 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
WriteAttributeValue("", 4243, staringPageCounter, 4243, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display: none;\">\r\n                <p>© 2021 - Bank Nizwa Survey Application</p>\r\n            </div>\r\n");
#nullable restore
#line 101 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf4b86513f3038a412e311ab8a0c25a4ffd305ca23092", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        if(\'");
#nullable restore
#line 110 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\Survey\Preview.cshtml"
       Write(Model.Survey.Language);

#line default
#line hidden
#nullable disable
                WriteLiteral("\' == \'Arabic\'){\r\n            $(\'html\').attr(\'dir\', \'rtl\');\r\n            \r\n        }\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
