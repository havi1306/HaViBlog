#pragma checksum "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\TopMenu\Categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aae1f606a7b1ce540a39da13b343b255640e8f0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopMenu_Categories), @"mvc.1.0.view", @"/Views/Shared/Components/TopMenu/Categories.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TopMenu/Categories.cshtml", typeof(AspNetCore.Views_Shared_Components_TopMenu_Categories))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aae1f606a7b1ce540a39da13b343b255640e8f0d", @"/Views/Shared/Components/TopMenu/Categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4e093d822daafdf308d3c1333c67e734a645eb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopMenu_Categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HaViBlog.Service.ViewModels.CategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\TopMenu\Categories.cshtml"
  
    foreach (var item in Model)
    {

        var childItems = Model.Where(p => p.ParentId == item.Id).ToList();
        var url = "/" + item.Url;
        if (childItems.Count() > 0 && item.IsParent == true)
        {


#line default
#line hidden
            BeginContext(301, 166, true);
            WriteLiteral("            <li class=\"nav-item dropdown\">\r\n                <a class=\"nav-link dropdown-toggle\" href=\"#\" id=\"navbardrop\" data-toggle=\"dropdown\">\r\n                    ");
            EndContext();
            BeginContext(468, 17, false);
#line 14 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\TopMenu\Categories.cshtml"
               Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(485, 71, true);
            WriteLiteral("\r\n                </a>\r\n\r\n                <div class=\"dropdown-menu\">\r\n");
            EndContext();
#line 18 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\TopMenu\Categories.cshtml"
                      
                        foreach (var subItem in childItems)
                        {

#line default
#line hidden
            BeginContext(668, 52, true);
            WriteLiteral("                            <a class=\"dropdown-item\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 720, "\"", 740, 2);
            WriteAttributeValue("", 727, "/", 727, 1, true);
#line 21 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\TopMenu\Categories.cshtml"
WriteAttributeValue("", 728, subItem.Url, 728, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(741, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(743, 20, false);
#line 21 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\TopMenu\Categories.cshtml"
                                                                     Write(subItem.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(763, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 22 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\TopMenu\Categories.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(819, 43, true);
            WriteLiteral("                </div>\r\n            </li>\r\n");
            EndContext();
#line 26 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\TopMenu\Categories.cshtml"
        }
        else
        {
            if (item.IsParent == true)
            {

#line default
#line hidden
            BeginContext(953, 61, true);
            WriteLiteral("                <li class=\"nav-item\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1014, "\"", 1025, 1);
#line 32 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\TopMenu\Categories.cshtml"
WriteAttributeValue("", 1021, url, 1021, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1026, 18, true);
            WriteLiteral(" class=\"nav-link\">");
            EndContext();
            BeginContext(1045, 17, false);
#line 32 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\TopMenu\Categories.cshtml"
                                               Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(1062, 29, true);
            WriteLiteral("</a>\r\n                </li>\r\n");
            EndContext();
#line 34 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Views\Shared\Components\TopMenu\Categories.cshtml"
            }

        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HaViBlog.Service.ViewModels.CategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
