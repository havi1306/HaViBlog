#pragma checksum "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\_SideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de6125c3399cf4320c81a991b614b91cfce73f3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SideBar), @"mvc.1.0.view", @"/Views/Shared/_SideBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_SideBar.cshtml", typeof(AspNetCore.Views_Shared__SideBar))]
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
#line 1 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\_ViewImports.cshtml"
using HaViBlog;

#line default
#line hidden
#line 2 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\_ViewImports.cshtml"
using HaViBlog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de6125c3399cf4320c81a991b614b91cfce73f3a", @"/Views/Shared/_SideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4e093d822daafdf308d3c1333c67e734a645eb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 195, true);
            WriteLiteral("\r\n<aside class=\"col-lg-4\">\r\n    <!-- Widget [Search Bar Widget]-->\r\n    <div class=\"widget search\">\r\n        <header>\r\n            <h3 class=\"h6\">Search the blog</h3>\r\n        </header>\r\n        ");
            EndContext();
            BeginContext(195, 341, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de6125c3399cf4320c81a991b614b91cfce73f3a4834", async() => {
                BeginContext(276, 253, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"search\" name=\"keyword\" placeholder=\"What are you looking for?\">\r\n                <button type=\"submit\" class=\"submit\"><i class=\"icon-search\"></i></button>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(536, 253, true);
            WriteLiteral("\r\n    </div>\r\n    <!-- end search bar -->\r\n    <!-- Widget [Latest Posts Widget]-->\r\n    <div class=\"widget latest-posts\">\r\n        <header>\r\n            <h3 class=\"h6\">Latest Posts</h3>\r\n        </header>\r\n        <div class=\"blog-posts\">\r\n            ");
            EndContext();
            BeginContext(791, 41, false);
#line 22 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\_SideBar.cshtml"
        Write(await Component.InvokeAsync("LatestPost"));

#line default
#line hidden
            EndContext();
            BeginContext(833, 226, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <!-- end latest post -->\r\n    <!-- Widget [Categories Widget]-->\r\n    <div class=\"widget categories\">\r\n        <header>\r\n            <h3 class=\"h6\">Chuyên mục</h3>\r\n        </header>\r\n        ");
            EndContext();
            BeginContext(1061, 46, false);
#line 31 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\_SideBar.cshtml"
    Write(await Component.InvokeAsync("CategoriesGroup"));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 240, true);
            WriteLiteral("\r\n    </div>\r\n    <!-- end categories post -->\r\n    <!-- Widget [Tags Cloud Widget]-->\r\n    <div class=\"widget tags\">\r\n        <header>\r\n            <h3 class=\"h6\">Tags</h3>\r\n        </header>\r\n        <ul class=\"list-inline\">\r\n            ");
            EndContext();
            BeginContext(1350, 34, false);
#line 40 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\_SideBar.cshtml"
        Write(await Component.InvokeAsync("Tag"));

#line default
#line hidden
            EndContext();
            BeginContext(1385, 67, true);
            WriteLiteral("\r\n        </ul>\r\n    </div>\r\n    <!-- end tag wideget -->\r\n</aside>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591