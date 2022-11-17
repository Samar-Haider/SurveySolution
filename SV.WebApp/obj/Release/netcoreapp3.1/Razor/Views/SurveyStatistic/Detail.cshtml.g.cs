#pragma checksum "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be3356543856ed2e34dc048cd0edca21cf55198b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SurveyStatistic_Detail), @"mvc.1.0.view", @"/Views/SurveyStatistic/Detail.cshtml")]
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
#line 3 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\_ViewImports.cshtml"
using SV.Models.ViewModels;

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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be3356543856ed2e34dc048cd0edca21cf55198b", @"/Views/SurveyStatistic/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1190a92d7293542a140bd67903d20c4c77e3e4b1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SurveyStatistic_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Survey>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Statistics", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("View Answers"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Detail.cshtml"
  
    ViewData["Title"] = "Statistics Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    
<div id=""main-content"">
                        
    <div class=""notice_messages""></div>
						
    <div class=""quick-buttons"">
        <div class=""row-fluid"">
            <div class=""span3"">                    
                    <div>
                    <strong>2</strong>
                    <span class=""dasboard-icons-title"">Total Surveys</span>
                    </div>
            </div>
            <div class=""span3"">                    
                    <div>
                    <strong>3</strong>
                    <span class=""dasboard-icons-title"">Questions</span>
                    </div> 
            </div> 
            <div class=""span3"">                    
                    <div>
                    <strong>0</strong>
                    <span class=""dasboard-icons-title"">Answers</span>
                    </div>
            </div>                
            <div class=""span3"">                    
                    <div>
                    <strong>0");
            WriteLiteral(@"</strong>
                    <span class=""dasboard-icons-title"">Took Survey</span>
                    </div> 
            </div> 
        </div>
    </div>
                        
    <div class=""box"">
        <div class=""header""><h4> Choose Questions</div> 
        <div class=""content"">
");
#nullable restore
#line 42 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Detail.cshtml"
         if(Model.Questions.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""normal bt-dataTable"" border=""0""  cellpadding=""0"" cellspacing=""0"" width=""100%"" id=""dataTable"">
                <thead>
                    <tr>
                        <th>Fill</th>
                        <th>Question</th>
                        <th>Question Type</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 53 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Detail.cshtml"
                     foreach(var question in Model.Questions) 
                    { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"w30\">\r\n");
#nullable restore
#line 58 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Detail.cshtml"
                                 if(false)
					            {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t            <i class=\"icon-ok\"></i>\r\n");
#nullable restore
#line 61 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Detail.cshtml"
					            } 
                                else 
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t            <i class=\"icon-remove\"></i>\r\n");
#nullable restore
#line 65 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Detail.cshtml"
					            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t        </td>\r\n                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be3356543856ed2e34dc048cd0edca21cf55198b7842", async() => {
#nullable restore
#line 67 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Detail.cshtml"
                                                                                                       Write(question.QuestionText);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Detail.cshtml"
                                                             WriteLiteral(question.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                            <td class=\"w130\">");
#nullable restore
#line 68 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Detail.cshtml"
                                        Write(question.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\t\r\n");
#nullable restore
#line 70 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 73 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Detail.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"pad20\">No Questions found</p>\r\n            <p class=\"pad20\">There are no questions to this survey.</p>   \r\n");
#nullable restore
#line 78 "E:\Enum Solutions\SurveySolution\SV.WebApp\Views\SurveyStatistic\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n                                                \r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Survey> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
