#pragma checksum "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da2fd7bcd232709fc91a40b2adf8cc1a4271dfc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Delete), @"mvc.1.0.view", @"/Views/Admin/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Delete.cshtml", typeof(AspNetCore.Views_Admin_Delete))]
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
#line 1 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\_ViewImports.cshtml"
using MisterRobotoArigato;

#line default
#line hidden
#line 5 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\_ViewImports.cshtml"
using MisterRobotoArigato.Models;

#line default
#line hidden
#line 3 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\_ViewImports.cshtml"
using MisterRobotoArigato.Models.ViewModel;

#line default
#line hidden
#line 4 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da2fd7bcd232709fc91a40b2adf8cc1a4271dfc5", @"/Views/Admin/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8ae2ccbb7e94b73188ce3e6eb3a1d410ddbaed", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\Delete.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(44, 71, true);
            WriteLiteral("\n<h2>Delete A Product</h2>\n<dl class=\"dl-horizontal\">\n    <dt>\n        ");
            EndContext();
            BeginContext(116, 38, false);
#line 9 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(154, 28, true);
            WriteLiteral("\n    </dt>\n    <dd>\n        ");
            EndContext();
            BeginContext(183, 34, false);
#line 12 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\Delete.cshtml"
   Write(Html.DisplayFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(217, 28, true);
            WriteLiteral("\n    </dd>\n    <dt>\n        ");
            EndContext();
            BeginContext(246, 40, false);
#line 15 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(286, 28, true);
            WriteLiteral("\n    </dt>\n    <dd>\n        ");
            EndContext();
            BeginContext(315, 36, false);
#line 18 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\Delete.cshtml"
   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(351, 28, true);
            WriteLiteral("\n    </dd>\n    <dt>\n        ");
            EndContext();
            BeginContext(380, 39, false);
#line 21 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.SKU));

#line default
#line hidden
            EndContext();
            BeginContext(419, 28, true);
            WriteLiteral("\n    </dt>\n    <dd>\n        ");
            EndContext();
            BeginContext(448, 35, false);
#line 24 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\Delete.cshtml"
   Write(Html.DisplayFor(model => model.SKU));

#line default
#line hidden
            EndContext();
            BeginContext(483, 28, true);
            WriteLiteral("\n    </dd>\n    <dt>\n        ");
            EndContext();
            BeginContext(512, 41, false);
#line 27 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(553, 28, true);
            WriteLiteral("\n    </dt>\n    <dd>\n        ");
            EndContext();
            BeginContext(582, 37, false);
#line 30 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\Delete.cshtml"
   Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(619, 28, true);
            WriteLiteral("\n    </dd>\n    <dt>\n        ");
            EndContext();
            BeginContext(648, 47, false);
#line 33 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(695, 28, true);
            WriteLiteral("\n    </dt>\n    <dd>\n        ");
            EndContext();
            BeginContext(724, 43, false);
#line 36 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\Delete.cshtml"
   Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(767, 28, true);
            WriteLiteral("\n    </dd>\n    <dt>\n        ");
            EndContext();
            BeginContext(796, 42, false);
#line 39 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.ImgUrl));

#line default
#line hidden
            EndContext();
            BeginContext(838, 32, true);
            WriteLiteral("\n    </dt>\n    <dd>\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 870, "\"", 915, 1);
#line 42 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\Delete.cshtml"
WriteAttributeValue("", 876, Html.DisplayFor(model => model.ImgUrl), 876, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(916, 21, true);
            WriteLiteral(" />\n    </dd>\n</dl>\n\n");
            EndContext();
            BeginContext(937, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc1d9766877545c8969318bacd2274aa", async() => {
                BeginContext(963, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(968, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "059363455a1747b89b4324eeaf4e574c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 47 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1004, 72, true);
                WriteLiteral("\n    <input type=\"submit\" value=\"Delete\" class=\"btn btn-primary\" />\n    ");
                EndContext();
                BeginContext(1076, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9579c36995e344cca60c92c60fa8bae7", async() => {
                    BeginContext(1100, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1116, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
