#pragma checksum "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7462203b42ac09670b4965f677fb734755a880b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Post_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Post/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Post/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Post_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7462203b42ac09670b4965f677fb734755a880b", @"/Areas/Admin/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HaViBlog.Service.ViewModels.PostViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Role", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\Post\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(97, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(160, 230, true);
            WriteLiteral("\n<div class=\"card shadow mb-4\">\n    <div class=\"container-fluid\">\n        <div class=\"card-header py-3\">\n            <div class=\"card-header py-3\">\n                <p class=\"m-0 font-weight-bold text-primary\">\n                    ");
            EndContext();
            BeginContext(390, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7462203b42ac09670b4965f677fb734755a880b5209", async() => {
                BeginContext(413, 15, true);
                WriteLiteral("Create New Post");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(432, 588, true);
            WriteLiteral(@"
                </p>
            </div>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered dataTable"" id=""dataTable"" cellspacing=""0"" role=""grid"" aria-describedby=""dataTable_info""
                       style=""width: 100%;"">
                    <thead>
                        <tr role=""row"">
                            <th tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1""
                                style=""width: 100px;"" aria-sort=""descending"">
                                ");
            EndContext();
            BeginContext(1021, 38, false);
#line 26 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\Post\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1059, 217, true);
            WriteLiteral("\n                            </th>\n                            <th tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\"\n                                style=\"width: 200px;\">\n                                ");
            EndContext();
            BeginContext(1277, 41, false);
#line 30 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\Post\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 217, true);
            WriteLiteral("\n                            </th>\n                            <th tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\"\n                                style=\"width: 300px;\">\n                                ");
            EndContext();
            BeginContext(1536, 47, false);
#line 34 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\Post\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1583, 217, true);
            WriteLiteral("\n                            </th>\n                            <th tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\"\n                                style=\"width: 100px;\">\n                                ");
            EndContext();
            BeginContext(1801, 46, false);
#line 38 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\Post\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(1847, 217, true);
            WriteLiteral("\n                            </th>\n                            <th tabindex=\"0\" aria-controls=\"dataTable\" rowspan=\"1\" colspan=\"1\"\n                                style=\"width: 100px;\">\n                                ");
            EndContext();
            BeginContext(2065, 42, false);
#line 42 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\Post\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2107, 277, true);
            WriteLiteral(@"
                            </th>
                            <th tabindex=""0"" aria-controls=""dataTable"" rowspan=""1"" colspan=""1""
                                style=""width: 123px;""></th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 49 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\Post\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2463, 117, true);
            WriteLiteral("                            <tr role=\"row\">\n                                <td>\n                                    ");
            EndContext();
            BeginContext(2581, 37, false);
#line 53 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\Post\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2618, 112, true);
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(2731, 40, false);
#line 56 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\Post\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(2771, 112, true);
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(2884, 46, false);
#line 59 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\Post\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2930, 112, true);
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(3043, 45, false);
#line 62 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\Post\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(3088, 112, true);
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(3201, 41, false);
#line 65 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\Post\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3242, 112, true);
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(3354, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7462203b42ac09670b4965f677fb734755a880b13389", async() => {
                BeginContext(3438, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\Post\Index.cshtml"
                                                                                                  WriteLiteral(item.Id);

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
            BeginContext(3446, 39, true);
            WriteLiteral(" |\n                                    ");
            EndContext();
            BeginContext(3485, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7462203b42ac09670b4965f677fb734755a880b16236", async() => {
                BeginContext(3571, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\Post\Index.cshtml"
                                                                                                    WriteLiteral(item.Id);

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
            BeginContext(3581, 73, true);
            WriteLiteral("\n                                </td>\n                            </tr>\n");
            EndContext();
#line 72 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\Post\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3680, 88, true);
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n");
            EndContext();
            BeginContext(3797, 19, true);
            WriteLiteral("    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HaViBlog.Service.ViewModels.PostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
