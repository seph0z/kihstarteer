#pragma checksum "D:\Murashkevich\Visual Studio\Course Project\CourseProject.Web\Views\Project\PreViewAlbum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70624dab06393e312c63ab8b48c3c34f0dedbbf6"
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
#line 1 "D:\Murashkevich\Visual Studio\Course Project\CourseProject.Web\Views\_ViewImports.cshtml"
using CourseProject.Web;

#line default
#line hidden
#line 2 "D:\Murashkevich\Visual Studio\Course Project\CourseProject.Web\Views\_ViewImports.cshtml"
using CourseProject.Web.Models;

#line default
#line hidden
#line 1 "D:\Murashkevich\Visual Studio\Course Project\CourseProject.Web\Views\Project\PreViewAlbum.cshtml"
using System.Collections.Generic;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70624dab06393e312c63ab8b48c3c34f0dedbbf6", @"/Views/Project/PreViewAlbum.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"927c1246519129d3ed57e0612fab08071e7c5f2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_PreViewAlbum : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Murashkevich\Visual Studio\Course Project\CourseProject.Web\Views\Project\PreViewAlbum.cshtml"
 foreach(var img in Model)
{

#line default
#line hidden
            BeginContext(89, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(97, 3, false);
#line 6 "D:\Murashkevich\Visual Studio\Course Project\CourseProject.Web\Views\Project\PreViewAlbum.cshtml"
  Write(img);

#line default
#line hidden
            EndContext();
            BeginContext(100, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 7 "D:\Murashkevich\Visual Studio\Course Project\CourseProject.Web\Views\Project\PreViewAlbum.cshtml"
}

#line default
#line hidden
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
