#pragma checksum "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\Project\PreViewAlbum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d42a55baf31aeda15dba12f498fbf4043348843c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_PreViewAlbum), @"mvc.1.0.view", @"/Views/Project/PreViewAlbum.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/PreViewAlbum.cshtml", typeof(AspNetCore.Views_Project_PreViewAlbum))]
namespace AspNetCore
{
    #line hidden
    using System;
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
#line 1 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\Project\PreViewAlbum.cshtml"
using System.Collections.Generic;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d42a55baf31aeda15dba12f498fbf4043348843c", @"/Views/Project/PreViewAlbum.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"927c1246519129d3ed57e0612fab08071e7c5f2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_PreViewAlbum : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 21, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n");
            EndContext();
#line 5 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\Project\PreViewAlbum.cshtml"
     foreach (var img in Model)
    {

#line default
#line hidden
            BeginContext(117, 76, true);
            WriteLiteral("        <div class=\"col-sm-6\" style=\"margin-bottom:30px;\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 193, "\"", 203, 1);
#line 8 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\Project\PreViewAlbum.cshtml"
WriteAttributeValue("", 199, img, 199, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(204, 76, true);
            WriteLiteral(" id=\"imgs\" class=\"mx-auto d-block\" alt=\"Alternate Text\" />\r\n        </div>\r\n");
            EndContext();
#line 10 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\Project\PreViewAlbum.cshtml"
    }

#line default
#line hidden
            BeginContext(287, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591