#pragma checksum "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d05d4ce21bbc390971888f0827514933c074ad39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/User/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_User_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05d4ce21bbc390971888f0827514933c074ad39", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HaViBlog.Service.ViewModels.UserViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(97, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 8 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\User\Index.cshtml"
  
    if (Model.Count() <= 0 || Model == null)
    {

#line default
#line hidden
            BeginContext(214, 427, true);
            WriteLiteral(@"        <div class=""card shadow mb-4"">

            <div class=""container-fluid"">
                <div class=""card-header py-3"">
                    <div class=""card-header py-3"">
                        <p class=""m-0 font-weight-bold text-primary"">
                            <h3>Không có người dùng con ơi</h3>
                        </p>
                    </div>
                </div>
            </div>
        </div>
");
            EndContext();
#line 23 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\User\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(662, 418, true);
            WriteLiteral(@"        <div class=""card shadow mb-4"">
            <div class=""container-fluid"">
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-bordered"" id=""dataTable"" cellspacing=""0"">
                            <thead>
                                <tr>
                                    <th>
                                        ");
            EndContext();
            BeginContext(1081, 38, false);
#line 34 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\User\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 124, true);
            WriteLiteral("\n                                    </th>\n                                    <th>\n                                        ");
            EndContext();
            BeginContext(1244, 44, false);
#line 37 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\User\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 200, true);
            WriteLiteral("\n                                    </th>\n                                    <th></th>\n                                </tr>\n                            </thead>\n                            <tbody>\n");
            EndContext();
#line 43 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\User\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
            BeginContext(1583, 130, true);
            WriteLiteral("                                    <tr>\n                                        <td>\n                                            ");
            EndContext();
            BeginContext(1714, 37, false);
#line 47 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\User\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1751, 136, true);
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
            EndContext();
            BeginContext(1888, 43, false);
#line 50 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\User\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1931, 136, true);
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
            EndContext();
            BeginContext(2067, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d05d4ce21bbc390971888f0827514933c074ad399285", async() => {
                BeginContext(2151, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\User\Index.cshtml"
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
            BeginContext(2159, 47, true);
            WriteLiteral(" |\n                                            ");
            EndContext();
            BeginContext(2206, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d05d4ce21bbc390971888f0827514933c074ad3912148", async() => {
                BeginContext(2295, 16, true);
                WriteLiteral("Grant Permission");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\User\Index.cshtml"
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
            BeginContext(2315, 47, true);
            WriteLiteral(" |\n                                            ");
            EndContext();
            BeginContext(2362, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d05d4ce21bbc390971888f0827514933c074ad3915029", async() => {
                BeginContext(2448, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\User\Index.cshtml"
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
            BeginContext(2458, 89, true);
            WriteLiteral("\n                                        </td>\n                                    </tr>\n");
            EndContext();
#line 58 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\User\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2581, 120, true);
            WriteLiteral("                            </tbody>\n                        </table>\n                    </div>\n                </div>\n");
            EndContext();
            BeginContext(2738, 34, true);
            WriteLiteral("            </div>\n        </div>\n");
            EndContext();
#line 66 "C:\Users\viha1306\Desktop\HaViBlog\HaViBlog\HaViBlog\HaViBlog\Areas\Admin\Views\User\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HaViBlog.Service.ViewModels.UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591