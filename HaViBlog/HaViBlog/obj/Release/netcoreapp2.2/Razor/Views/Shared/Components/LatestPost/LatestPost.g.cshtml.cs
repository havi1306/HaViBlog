#pragma checksum "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\LatestPost\LatestPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a358a468dd9b611ae5b98009e85fc8c92ef91bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LatestPost_LatestPost), @"mvc.1.0.view", @"/Views/Shared/Components/LatestPost/LatestPost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/LatestPost/LatestPost.cshtml", typeof(AspNetCore.Views_Shared_Components_LatestPost_LatestPost))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a358a468dd9b611ae5b98009e85fc8c92ef91bc", @"/Views/Shared/Components/LatestPost/LatestPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4e093d822daafdf308d3c1333c67e734a645eb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LatestPost_LatestPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HaViBlog.Service.ViewModels.PostViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\LatestPost\LatestPost.cshtml"
  
    foreach (var item in Model)
    {
        var url = "/" + item.Alias + "-post." + item.Id + ".html";

#line default
#line hidden
            BeginContext(177, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 187, "\"", 198, 1);
#line 7 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\LatestPost\LatestPost.cshtml"
WriteAttributeValue("", 194, url, 194, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(199, 124, true);
            WriteLiteral(">\r\n            <div class=\"item d-flex align-items-center\">\r\n\r\n                <div class=\"image\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 323, "\"", 358, 1);
#line 11 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\LatestPost\LatestPost.cshtml"
WriteAttributeValue("", 329, Url.Content(@item.Thumbnail), 329, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(359, 120, true);
            WriteLiteral(" alt=\"...\" class=\"img-fluid\">\r\n                </div>\r\n                <div class=\"title\">\r\n                    <strong>");
            EndContext();
            BeginContext(480, 10, false);
#line 14 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\LatestPost\LatestPost.cshtml"
                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(490, 139, true);
            WriteLiteral("</strong>\r\n                    <div class=\"d-flex align-items-center\">\r\n                        <div class=\"views\"><i class=\"icon-eye\"></i>");
            EndContext();
            BeginContext(630, 14, false);
#line 16 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\LatestPost\LatestPost.cshtml"
                                                              Write(item.ViewCount);

#line default
#line hidden
            EndContext();
            BeginContext(644, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(740, 86, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </a>\r\n");
            EndContext();
#line 22 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\LatestPost\LatestPost.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HaViBlog.Service.ViewModels.PostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591