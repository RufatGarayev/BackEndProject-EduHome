#pragma checksum "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "996b0245a712302f6b71882d026f667a2578c161"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EventDetails_Index), @"mvc.1.0.view", @"/Views/EventDetails/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"996b0245a712302f6b71882d026f667a2578c161", @"/Views/EventDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f96ea0f62644188d3c5db6a1758a61a83dd5917a", @"/Views/_ViewImports.cshtml")]
    public class Views_EventDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventDetailsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://demo.devitems.com/eduhome/mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BlogDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-10 mb-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>event / details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Event Details Start -->
<div class=""event-details-area blog-area pt-150 pb-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""event-details"">
                    <div class=""event-details-img"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 915, "\"", 952, 2);
            WriteAttributeValue("", 921, "img/event/", 921, 10, true);
#nullable restore
#line 30 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
WriteAttributeValue("", 931, Model.WorkShop.Image, 931, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""event-details"">
                        <div class=""event-date"">
                            <h3>20 <span>jun</span></h3>
                        </div>
                    </div>
                    <div class=""event-details-content"">
                        <h2>");
#nullable restore
#line 36 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                       Write(Model.WorkShop.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <ul>\r\n                            <li><span>time : </span>9:30am - 4:45pm</li>\r\n                            <li><span>venue : </span>");
#nullable restore
#line 39 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                                                Write(Model.WorkShop.Venue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ul>\r\n                        ");
#nullable restore
#line 41 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                   Write(Html.Raw(Model.WorkShop.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        <!-- Speakers Start -->\r\n                        <div class=\"speakers-area fix\">\r\n                            <h4>speakers</h4>\r\n");
#nullable restore
#line 46 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                             foreach (Speaker sp in Model.Speakers)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"single-speaker\">\r\n                                    <div class=\"speaker-img\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1960, "\"", 1985, 2);
            WriteAttributeValue("", 1966, "img/event/", 1966, 10, true);
#nullable restore
#line 50 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
WriteAttributeValue("", 1976, sp.Image, 1976, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"speaker\">\r\n                                    </div>\r\n                                    <div class=\"speaker-name\">\r\n                                        <h5>");
#nullable restore
#line 53 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                                       Write(sp.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <p>");
#nullable restore
#line 54 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                                      Write(sp.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 57 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <!-- Speakers End -->
                    </div>
                    <!-- PeplyArea Start -->
                    <div class=""reply-area"">
                        <h3>LEAVE A REPLY</h3>
                        <p>I must explain to you how all this a mistaken idea of ncing great explorer of the rut<br> the is lder of human happinescias unde omnis iste natus error sit volptatem </p>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "996b0245a712302f6b71882d026f667a2578c16111652", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <p>Name</p>
                                    <input type=""text"" name=""name"" id=""name"">
                                </div>
                                <div class=""col-md-12"">
                                    <p>Email</p>
                                    <input type=""text"" name=""email"" id=""email"">
                                </div>
                                <div class=""col-md-12"">
                                    <p>Subject</p>
                                    <input type=""text"" name=""subject"" id=""subject"">
                                    <p>Massage</p>
                                    <textarea name=""message"" id=""message"" cols=""15"" rows=""10""></textarea>
                                </div>
                            </div>
                            <a class=""reply-btn"" href=""#"" data-text=""send""><span>send message");
                WriteLiteral("</span></a>\r\n                            <p class=\"form-messege\"></p>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <!-- PeplyArea End -->
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""blog-sidebar right"">
                    <div class=""single-blog-widget mb-50"">
                        <h3>search</h3>
                        <div class=""blog-search"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "996b0245a712302f6b71882d026f667a2578c16114836", async() => {
                WriteLiteral(@"
                                <input type=""search"" placeholder=""Search..."" name=""search"" />
                                <button type=""submit"">
                                    <span><i class=""fa fa-search""></i></span>
                                </button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    \r\n                    <div class=\"single-blog-widget mb-50\">\r\n                        <h3>categories</h3>\r\n                        <ul>\r\n");
#nullable restore
#line 106 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                             foreach (Category ctg in Model.Categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a href=\"#\">");
#nullable restore
#line 108 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                                           Write(ctg.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 108 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                                                      Write(ctg.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a></li>\r\n");
#nullable restore
#line 109 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                    <div class=\"single-blog-widget mb-50\">\r\n                        <div class=\"single-blog-banner\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "996b0245a712302f6b71882d026f667a2578c16118059", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 5459, "\"", 5497, 2);
                WriteAttributeValue("", 5465, "img/blog/", 5465, 9, true);
#nullable restore
#line 114 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
WriteAttributeValue("", 5474, Model.BlogBanner.Image, 5474, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"blog\">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
#nullable restore
#line 115 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                       Write(Html.Raw(Model.BlogBanner.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"single-blog-widget mb-50\">\r\n                        <h3>latest post</h3>\r\n");
#nullable restore
#line 120 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                         foreach (Post post in Model.Posts)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-post mb-30\">\r\n                                <div class=\"single-post-img\">\r\n                                    <a href=\"blog-details.html\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 6067, "\"", 6093, 2);
            WriteAttributeValue("", 6073, "img/post/", 6073, 9, true);
#nullable restore
#line 125 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
WriteAttributeValue("", 6082, post.Image, 6082, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""post"">
                                        <div class=""blog-hover"">
                                            <i class=""fa fa-link""></i>
                                        </div>
                                    </a>
                                </div>
                                <div class=""single-post-content"">
                                    <h4><a href=""blog-details.html"">");
#nullable restore
#line 132 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                                                               Write(post.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                    <p>");
#nullable restore
#line 133 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                                  Write(post.Composer);

#line default
#line hidden
#nullable disable
            WriteLiteral("  /  June 20, 2017</p>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 136 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"single-blog-widget\">\r\n                        <h3>tags</h3>\r\n                        <div class=\"single-tag\">\r\n");
#nullable restore
#line 141 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                             foreach (Tag tag in Model.Tags)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "996b0245a712302f6b71882d026f667a2578c16123162", async() => {
#nullable restore
#line 143 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                                                                                                  Write(tag.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 144 "C:\Users\ASUS\Desktop\EduHome\EduHome\Views\EventDetails\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Event Details End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventDetailsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
