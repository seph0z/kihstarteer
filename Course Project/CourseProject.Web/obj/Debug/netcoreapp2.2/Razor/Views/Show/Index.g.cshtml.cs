#pragma checksum "D:\Repositories\kihstarteer\Course Project\CourseProject.Web\Views\Show\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4653f5914b2a8c558bb822354ec7b477cfee321a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Show_Index), @"mvc.1.0.view", @"/Views/Show/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Show/Index.cshtml", typeof(AspNetCore.Views_Show_Index))]
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
#line 1 "D:\Repositories\kihstarteer\Course Project\CourseProject.Web\Views\_ViewImports.cshtml"
using CourseProject.Web;

#line default
#line hidden
#line 2 "D:\Repositories\kihstarteer\Course Project\CourseProject.Web\Views\_ViewImports.cshtml"
using CourseProject.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4653f5914b2a8c558bb822354ec7b477cfee321a", @"/Views/Show/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"927c1246519129d3ed57e0612fab08071e7c5f2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Show_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CourseProject.Domain.Contracts.ViewModels.ShowProjectViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetTag", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cardDesk"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(84, 36, true);
            WriteLiteral("\r\n\r\n<div style=\"margin-top:50px;\">\r\n");
            EndContext();
#line 5 "D:\Repositories\kihstarteer\Course Project\CourseProject.Web\Views\Show\Index.cshtml"
     if (ViewBag.TagCloud != null)
    {
        

#line default
#line hidden
#line 7 "D:\Repositories\kihstarteer\Course Project\CourseProject.Web\Views\Show\Index.cshtml"
         foreach (var tag in ViewBag.TagCloud)
        {

#line default
#line hidden
            BeginContext(222, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(234, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4653f5914b2a8c558bb822354ec7b477cfee321a5098", async() => {
                BeginContext(313, 3, false);
#line 9 "D:\Repositories\kihstarteer\Course Project\CourseProject.Web\Views\Show\Index.cshtml"
                                                                                     Write(tag);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tag", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 9 "D:\Repositories\kihstarteer\Course Project\CourseProject.Web\Views\Show\Index.cshtml"
                                                                        WriteLiteral(tag);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tag", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(320, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "D:\Repositories\kihstarteer\Course Project\CourseProject.Web\Views\Show\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(335, 26, true);
            WriteLiteral("        <hr id=\"hara\" />\r\n");
            EndContext();
#line 13 "D:\Repositories\kihstarteer\Course Project\CourseProject.Web\Views\Show\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(368, 33, true);
            WriteLiteral("</div>\r\n\r\n\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 19 "D:\Repositories\kihstarteer\Course Project\CourseProject.Web\Views\Show\Index.cshtml"
     if (Model != null)
    {
        

#line default
#line hidden
#line 21 "D:\Repositories\kihstarteer\Course Project\CourseProject.Web\Views\Show\Index.cshtml"
         foreach (var project in Model)
        {

#line default
#line hidden
            BeginContext(485, 77, true);
            WriteLiteral("            <div class=\"col-4\" style=\"margin-bottom:26px;\">\r\n                ");
            EndContext();
            BeginContext(562, 459, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4653f5914b2a8c558bb822354ec7b477cfee321a8811", async() => {
                BeginContext(623, 70, true);
                WriteLiteral("\r\n                    <div class=\"card\">\r\n                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 693, "\"", 713, 1);
#line 26 "D:\Repositories\kihstarteer\Course Project\CourseProject.Web\Views\Show\Index.cshtml"
WriteAttributeValue("", 699, project.Image, 699, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(714, 134, true);
                WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
                EndContext();
                BeginContext(849, 13, false);
#line 28 "D:\Repositories\kihstarteer\Course Project\CourseProject.Web\Views\Show\Index.cshtml"
                                              Write(project.Title);

#line default
#line hidden
                EndContext();
                BeginContext(862, 56, true);
                WriteLiteral("</h5>\r\n                            <p class=\"card-text\">");
                EndContext();
                BeginContext(919, 16, false);
#line 29 "D:\Repositories\kihstarteer\Course Project\CourseProject.Web\Views\Show\Index.cshtml"
                                            Write(project.Subtitle);

#line default
#line hidden
                EndContext();
                BeginContext(935, 82, true);
                WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "D:\Repositories\kihstarteer\Course Project\CourseProject.Web\Views\Show\Index.cshtml"
                                      WriteLiteral(project.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1021, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 34 "D:\Repositories\kihstarteer\Course Project\CourseProject.Web\Views\Show\Index.cshtml"
        }

#line default
#line hidden
#line 34 "D:\Repositories\kihstarteer\Course Project\CourseProject.Web\Views\Show\Index.cshtml"
         
    }
    else
    {

#line default
#line hidden
            BeginContext(1078, 34, true);
            WriteLiteral("        <p>Dont have result!</p>\r\n");
            EndContext();
#line 39 "D:\Repositories\kihstarteer\Course Project\CourseProject.Web\Views\Show\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1119, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CourseProject.Domain.Contracts.ViewModels.ShowProjectViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
