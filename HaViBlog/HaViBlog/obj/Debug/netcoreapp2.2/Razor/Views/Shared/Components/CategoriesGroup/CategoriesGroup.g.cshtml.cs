#pragma checksum "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\CategoriesGroup\CategoriesGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e301127be65e151d1e9678367afdae075b9a78d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoriesGroup_CategoriesGroup), @"mvc.1.0.view", @"/Views/Shared/Components/CategoriesGroup/CategoriesGroup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CategoriesGroup/CategoriesGroup.cshtml", typeof(AspNetCore.Views_Shared_Components_CategoriesGroup_CategoriesGroup))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e301127be65e151d1e9678367afdae075b9a78d1", @"/Views/Shared/Components/CategoriesGroup/CategoriesGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4e093d822daafdf308d3c1333c67e734a645eb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoriesGroup_CategoriesGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HaViBlog.Service.ViewModels.CategoriesGroupViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\CategoriesGroup\CategoriesGroup.cshtml"
  
    foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(118, 69, true);
            WriteLiteral("        <div class=\"item d-flex justify-content-between\"><a href=\"#\">");
            EndContext();
            BeginContext(188, 17, false);
#line 5 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\CategoriesGroup\CategoriesGroup.cshtml"
                                                                Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(205, 10, true);
            WriteLiteral("</a><span>");
            EndContext();
            BeginContext(216, 15, false);
#line 5 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\CategoriesGroup\CategoriesGroup.cshtml"
                                                                                            Write(item.GroupCount);

#line default
#line hidden
            EndContext();
            BeginContext(231, 15, true);
            WriteLiteral("</span></div>\r\n");
            EndContext();
#line 6 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\CategoriesGroup\CategoriesGroup.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HaViBlog.Service.ViewModels.CategoriesGroupViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
