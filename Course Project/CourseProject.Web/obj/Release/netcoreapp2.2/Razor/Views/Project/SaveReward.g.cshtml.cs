#pragma checksum "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\Project\SaveReward.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afaa72a7dba7496d79e9e0f82bab4a256dcc70a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_SaveReward), @"mvc.1.0.view", @"/Views/Project/SaveReward.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/SaveReward.cshtml", typeof(AspNetCore.Views_Project_SaveReward))]
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
#line 1 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\_ViewImports.cshtml"
using CourseProject.Web;

#line default
#line hidden
#line 2 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\_ViewImports.cshtml"
using CourseProject.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afaa72a7dba7496d79e9e0f82bab4a256dcc70a0", @"/Views/Project/SaveReward.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"927c1246519129d3ed57e0612fab08071e7c5f2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_SaveReward : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CourseProject.Domain.Contracts.ViewModels.RewardViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(79, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\Project\SaveReward.cshtml"
 foreach (var reward in Model)
{

#line default
#line hidden
            BeginContext(118, 278, true);
            WriteLiteral(@"    <a href=""#"" id=""linkCard"">
        <div class=""card text-center"" id=""cardHover"" style=""margin-bottom: 30px;"">
            <div class=""card-body"" style=""height: 150px"">
                <div class=""row"">
                    <div class=""col-sm-6"">
                        ");
            EndContext();
            BeginContext(397, 12, false);
#line 11 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\Project\SaveReward.cshtml"
                   Write(reward.Title);

#line default
#line hidden
            EndContext();
            BeginContext(409, 98, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-sm-6\">\r\n                        ");
            EndContext();
            BeginContext(508, 13, false);
#line 14 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\Project\SaveReward.cshtml"
                   Write(reward.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(521, 588, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""card-footer text-muted"">
                <div>
                    <div class=""row justify-content-end"">
                        <div class=""col-1"">
                            <a href=""#"" id=""cardLink"">Edit</a>
                        </div>
                        <div class=""col-1"">
                            <a href=""#"" id=""cardLink"">Delete</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </a>
");
            EndContext();
#line 32 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\Project\SaveReward.cshtml"
}

#line default
#line hidden
            BeginContext(1112, 29, true);
            WriteLiteral("\r\n<div id=\"viewReward\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CourseProject.Domain.Contracts.ViewModels.RewardViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591