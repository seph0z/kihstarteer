#pragma checksum "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\User\GetProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eb97be27583d2d894e92a14531e1cc5491d2271"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetProfile), @"mvc.1.0.view", @"/Views/User/GetProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/GetProfile.cshtml", typeof(AspNetCore.Views_User_GetProfile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eb97be27583d2d894e92a14531e1cc5491d2271", @"/Views/User/GetProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"927c1246519129d3ed57e0612fab08071e7c5f2d", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseProject.Domain.Contracts.ViewModels.UserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SettingProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserCampaigns", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserManagement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(64, 74, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"row justify-content-center\" style=\"margin-top:150px;\">\r\n");
            EndContext();
#line 6 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\User\GetProfile.cshtml"
     if (Model.Image == null)
    {

#line default
#line hidden
            BeginContext(176, 114, true);
            WriteLiteral("        <img src=\"https://www.meme-arsenal.com/memes/63f058814afac6147b09c2f9e6858e6c.jpg\" id=\"addImageProfile\">\r\n");
            EndContext();
#line 9 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\User\GetProfile.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(314, 12, true);
            WriteLiteral("        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 326, "\"", 344, 1);
#line 12 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\User\GetProfile.cshtml"
WriteAttributeValue("", 332, Model.Image, 332, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(345, 24, true);
            WriteLiteral(" id=\"addImageProfile\">\r\n");
            EndContext();
#line 13 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\User\GetProfile.cshtml"
    }

#line default
#line hidden
            BeginContext(376, 110, true);
            WriteLiteral("</div>\r\n\r\n<div class=\"row justify-content-center\" style=\"margin-top:20px;\">\r\n    <div style=\"font-size:40px;\">");
            EndContext();
            BeginContext(487, 10, false);
#line 17 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\User\GetProfile.cshtml"
                            Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(497, 20, true);
            WriteLiteral("</div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
#line 21 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\User\GetProfile.cshtml"
 if (Model.Biography != null)
{

#line default
#line hidden
            BeginContext(551, 94, true);
            WriteLiteral("    <div class=\"row justify-content-center\" style=\"margin-top:20px;\">\r\n        <div>About me: ");
            EndContext();
            BeginContext(646, 15, false);
#line 24 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\User\GetProfile.cshtml"
                  Write(Model.Biography);

#line default
#line hidden
            EndContext();
            BeginContext(661, 20, true);
            WriteLiteral("</div>\r\n    </div>\r\n");
            EndContext();
#line 26 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\User\GetProfile.cshtml"
}

#line default
#line hidden
            BeginContext(684, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 29 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\User\GetProfile.cshtml"
 if (User.Identity.Name == Model.Name || User.IsInRole("Admin"))
{

#line default
#line hidden
            BeginContext(757, 112, true);
            WriteLiteral("    <div class=\"row justify-content-center\" style=\"margin-top:20px;\">\r\n        <div class=\"col-2\">\r\n            ");
            EndContext();
            BeginContext(869, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7eb97be27583d2d894e92a14531e1cc5491d22718850", async() => {
                BeginContext(983, 15, true);
                WriteLiteral("Profile setting");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\User\GetProfile.cshtml"
                                                                                                       WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1002, 59, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-2\">\r\n            ");
            EndContext();
            BeginContext(1061, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7eb97be27583d2d894e92a14531e1cc5491d227111610", async() => {
                BeginContext(1172, 12, true);
                WriteLiteral("My campaigns");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\User\GetProfile.cshtml"
                                                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1188, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 39 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\User\GetProfile.cshtml"
}

#line default
#line hidden
            BeginContext(1221, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 41 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\User\GetProfile.cshtml"
 if (User.IsInRole("Admin"))
{

#line default
#line hidden
            BeginContext(1256, 71, true);
            WriteLiteral("<div class=\"row justify-content-center\" style=\"margin-top:20px;\">\r\n    ");
            EndContext();
            BeginContext(1327, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7eb97be27583d2d894e92a14531e1cc5491d227114907", async() => {
                BeginContext(1409, 15, true);
                WriteLiteral("User management");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1428, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
#line 46 "D:\Murashkevich\Repos\Course Project\CourseProject.Web\Views\User\GetProfile.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseProject.Domain.Contracts.ViewModels.UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
