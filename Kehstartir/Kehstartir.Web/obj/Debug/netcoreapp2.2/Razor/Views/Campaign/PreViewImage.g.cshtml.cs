#pragma checksum "D:\Murashkevich\Repos\Kehstartir\Kehstartir.Web\Views\Campaign\PreViewImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65b8e7fde178afd700bad74465518d96fccb297c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Campaign_PreViewImage), @"mvc.1.0.view", @"/Views/Campaign/PreViewImage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Campaign/PreViewImage.cshtml", typeof(AspNetCore.Views_Campaign_PreViewImage))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Murashkevich\Repos\Kehstartir\Kehstartir.Web\Views\_ViewImports.cshtml"
using Kehstartir.Web;

#line default
#line hidden
#line 2 "D:\Murashkevich\Repos\Kehstartir\Kehstartir.Web\Views\_ViewImports.cshtml"
using Kehstartir.Web.Models;

#line default
#line hidden
#line 1 "D:\Murashkevich\Repos\Kehstartir\Kehstartir.Web\Views\Campaign\PreViewImage.cshtml"
using System.Collections.Generic;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b8e7fde178afd700bad74465518d96fccb297c", @"/Views/Campaign/PreViewImage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a265d407100bbc8fc96a34f26480874596d6e912", @"/Views/_ViewImports.cshtml")]
    public class Views_Campaign_PreViewImage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 85, true);
            WriteLiteral("\r\n<script>\r\n    var simplVal = simplemde.value();\r\n</script>\r\n\r\n<div class=\"row\">\r\n\r\n");
            EndContext();
#line 10 "D:\Murashkevich\Repos\Kehstartir\Kehstartir.Web\Views\Campaign\PreViewImage.cshtml"
         foreach (var img in Model)
        {

#line default
#line hidden
            BeginContext(189, 59, true);
            WriteLiteral("            <script>\r\n                imageLinks += \"\\n![](");
            EndContext();
            BeginContext(249, 3, false);
#line 13 "D:\Murashkevich\Repos\Kehstartir\Kehstartir.Web\Views\Campaign\PreViewImage.cshtml"
                                Write(img);

#line default
#line hidden
            EndContext();
            BeginContext(252, 84, true);
            WriteLiteral(")\";\r\n            </script>\r\n            <div class=\"col-md-4\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 336, "\"", 346, 1);
#line 16 "D:\Murashkevich\Repos\Kehstartir\Kehstartir.Web\Views\Campaign\PreViewImage.cshtml"
WriteAttributeValue("", 342, img, 342, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(347, 10, true);
            WriteLiteral(" id=\"imgs\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 357, "\"", 388, 4);
            WriteAttributeValue("", 367, "setLogo(\'", 367, 9, true);
#line 16 "D:\Murashkevich\Repos\Kehstartir\Kehstartir.Web\Views\Campaign\PreViewImage.cshtml"
WriteAttributeValue("", 376, img, 376, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 380, "\',", 380, 2, true);
            WriteAttributeValue(" ", 382, "this)", 383, 6, true);
            EndWriteAttribute();
            BeginContext(389, 70, true);
            WriteLiteral(" class=\"mx-auto d-block\" alt=\"Alternate Text\" />\r\n            </div>\r\n");
            EndContext();
#line 18 "D:\Murashkevich\Repos\Kehstartir\Kehstartir.Web\Views\Campaign\PreViewImage.cshtml"
        }

#line default
#line hidden
            BeginContext(470, 118, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<script>\r\n    simplVal += imageLinks;\r\n    simplemde.value(simplVal);\r\n    imageLinks = \"\";\r\n</script>\r\n");
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
