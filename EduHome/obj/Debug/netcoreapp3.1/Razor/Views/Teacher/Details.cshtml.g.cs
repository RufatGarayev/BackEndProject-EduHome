#pragma checksum "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e676202b568128e6c848abc3446642541930e65f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Details), @"mvc.1.0.view", @"/Views/Teacher/Details.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e676202b568128e6c848abc3446642541930e65f", @"/Views/Teacher/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f96ea0f62644188d3c5db6a1758a61a83dd5917a", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeacherDetailsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--HeaderTop Start-->
<div class=""header-top"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 col-sm-8 col-xs-12"">
                <div class=""header-top-left"">
                    <p>HAVE ANY QUESTION ?  +880 5698  598  6587</p>
                </div>
            </div>
            <div class=""col-md-4 col-sm-4 col-xs-12"">
                <div class=""header-top-right text-right"">
                    <ul>
                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e676202b568128e6c848abc3446642541930e65f5154", async() => {
                WriteLiteral("login");
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
            WriteLiteral("</li>\r\n                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e676202b568128e6c848abc3446642541930e65f6547", async() => {
                WriteLiteral("signup");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<!--HeaderTop End-->
<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>teachers / details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Teacher Start -->
<div class=""teacher-details-area pt-150 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 col-sm-5 col-xs-12"">
                <div class=""teacher-details-img"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e676202b568128e6c848abc3446642541930e65f8866", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1658, "~/img/teacher/", 1658, 14, true);
#nullable restore
#line 50 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
AddHtmlAttributeValue("", 1672, Model.TeacherBasicInfo.Image, 1672, 29, false);

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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\r\n                <div class=\"teacher-details-content ml-50\">\r\n                    <h2>");
#nullable restore
#line 55 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
                   Write(Model.TeacherBasicInfo.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h5>");
#nullable restore
#line 56 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
                   Write(Model.TeacherBasicInfo.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h4>about me</h4>\r\n                    <p>");
#nullable restore
#line 58 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
                  Write(Model.TeacherBasicInfo.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul>\r\n                        <li><span>degree: </span>");
#nullable restore
#line 60 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
                                            Write(Model.TeacherBasicInfo.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>experience: </span>");
#nullable restore
#line 61 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
                                                Write(Model.TeacherBasicInfo.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>hobbies: </span>");
#nullable restore
#line 62 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
                                             Write(Model.TeacherBasicInfo.Hobbies);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>faculty: </span>");
#nullable restore
#line 63 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
                                             Write(Model.TeacherBasicInfo.Faculty);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span>");
#nullable restore
#line 72 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
                                         Write(Model.TeacherContactInfo.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>make a call : </span>(+125) 5896 548 9874</p>\r\n                    <p><span>skype : </span>");
#nullable restore
#line 74 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
                                       Write(Model.TeacherContactInfo.Skype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul>\r\n                        <li><a ");
#nullable restore
#line 76 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
                          Write(Model.TeacherContactInfo.Facebook);

#line default
#line hidden
#nullable disable
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\r\n                        <li><a ");
#nullable restore
#line 77 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
                          Write(Model.TeacherContactInfo.Pinterest);

#line default
#line hidden
#nullable disable
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\r\n                        <li><a href=\"#\"><i class=\"zmdi zmdi-vimeo\"></i></a></li>\r\n                        <li><a ");
#nullable restore
#line 79 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
                          Write(Model.TeacherContactInfo.Twitter);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ""><i class=""zmdi zmdi-twitter""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                        <div class=""row"">
");
#nullable restore
#line 89 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
                             foreach (TeacherSkill skill in Model.TeacherSkills)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-sm-4\">\r\n                                    <div class=\"skill-bar-item\">\r\n                                        <span>");
#nullable restore
#line 93 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
                                         Write(skill.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <div class=\"progress\">\r\n                                            <div data-wow-delay=\"1.2s\" data-wow-duration=\"1.5s\"");
            BeginWriteAttribute("style", " style=\"", 4192, "\"", 4322, 10);
#nullable restore
#line 95 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
WriteAttributeValue("", 4200, skill.CompletedPercent, 4200, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4223, ";", 4223, 1, true);
            WriteAttributeValue(" ", 4224, "visibility:", 4225, 12, true);
            WriteAttributeValue(" ", 4236, "visible;", 4237, 9, true);
            WriteAttributeValue(" ", 4245, "animation-duration:", 4246, 20, true);
            WriteAttributeValue(" ", 4265, "1.5s;", 4266, 6, true);
            WriteAttributeValue(" ", 4271, "animation-delay:", 4272, 17, true);
            WriteAttributeValue(" ", 4288, "1.2s;", 4289, 6, true);
            WriteAttributeValue(" ", 4294, "animation-name:", 4295, 16, true);
            WriteAttributeValue(" ", 4310, "fadeInLeft;", 4311, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                                <span class=\"text-top\">");
#nullable restore
#line 96 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
                                                                  Write(skill.Percent);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 101 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\Teacher\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Teacher End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeacherDetailsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
