#pragma checksum "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2b29099317d528d99cbba75097a156211c87a10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Confirmed), @"mvc.1.0.view", @"/Views/Checkout/Confirmed.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Checkout/Confirmed.cshtml", typeof(AspNetCore.Views_Checkout_Confirmed))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2b29099317d528d99cbba75097a156211c87a10", @"/Views/Checkout/Confirmed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8ae2ccbb7e94b73188ce3e6eb3a1d410ddbaed", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_Confirmed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
  
    ViewData["Title"] = "Checkout";
    Layout = "_Layout";


#line default
#line hidden
            BeginContext(79, 500, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""py-5 text-center"">
        <h2>Order Confirmed</h2>
        <p class=""lead"">Congratulations! You have succesfully made an order.</p>
    </div>

    <div class=""row"">
        <div class=""col-md-4 order-md-2 mb-4"">
            <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                <span class=""text-muted"">Your checkout bag</span>
                <span class=""badge badge-secondary badge-pill""><i class=""fas fa-shopping-bag""></i>  ");
            EndContext();
            BeginContext(580, 18, false);
#line 17 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
                                                                                               Write(Model.TotalItemQty);

#line default
#line hidden
            EndContext();
            BeginContext(598, 68, true);
            WriteLiteral("</span>\n\n            </h4>\n            <ul class=\"list-group mb-3\">\n");
            EndContext();
#line 21 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
                  
                    decimal orderTotal = 0;
                

#line default
#line hidden
            BeginContext(747, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 24 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
                 foreach (var orderItem in Model.OrderItems)
                {
                    var totalItemPrice = orderItem.UnitPrice * orderItem.Quantity;
                    orderTotal += totalItemPrice;

#line default
#line hidden
            BeginContext(959, 187, true);
            WriteLiteral("                    <li class=\"list-group-item d-flex justify-content-between lh-condensed\">\n                        <div class=\"float-left\">\n                            <h6 class=\"my-0\">");
            EndContext();
            BeginContext(1147, 21, false);
#line 30 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
                                        Write(orderItem.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1168, 70, true);
            WriteLiteral("</h6>\n                            <small class=\"text-muted\">Quantity: ");
            EndContext();
            BeginContext(1239, 18, false);
#line 31 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
                                                           Write(orderItem.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1257, 68, true);
            WriteLiteral("</small>\n                        </div>\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1325, "\"", 1348, 1);
#line 33 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
WriteAttributeValue("", 1331, orderItem.ImgUrl, 1331, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1349, 72, true);
            WriteLiteral(" class=\"checkout-img\">\n                        <span class=\"text-muted\">");
            EndContext();
            BeginContext(1422, 14, false);
#line 34 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
                                            Write(totalItemPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1436, 34, true);
            WriteLiteral("</span>\n                    </li>\n");
            EndContext();
#line 36 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
                }

#line default
#line hidden
            BeginContext(1488, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 38 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
                 if (Model.DiscountPercent != 0)
                {
                    decimal discountAmt = (Model.DiscountPercent / 100) * orderTotal;

#line default
#line hidden
            BeginContext(1642, 175, true);
            WriteLiteral("                    <li class=\"list-group-item d-flex justify-content-between bg-light\">\n                        <h6 class=\"my-0\">Subtotal</h6>\n                        <span>$");
            EndContext();
            BeginContext(1818, 14, false);
#line 43 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
                          Write(Model.Subtotal);

#line default
#line hidden
            EndContext();
            BeginContext(1832, 270, true);
            WriteLiteral(@"</span>
                    </li>
                    <li class=""list-group-item d-flex justify-content-between bg-light"">
                        <div class=""text-success"">
                            <h6 class=""my-0"">Promo code</h6>
                            <small>");
            EndContext();
            BeginContext(2103, 18, false);
#line 48 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
                              Write(Model.DiscountName);

#line default
#line hidden
            EndContext();
            BeginContext(2121, 93, true);
            WriteLiteral("</small>\n                        </div>\n                        <span class=\"text-success\">-$");
            EndContext();
            BeginContext(2215, 32, false);
#line 50 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
                                                Write(Math.Round(Model.DiscountAmt, 2));

#line default
#line hidden
            EndContext();
            BeginContext(2247, 34, true);
            WriteLiteral("</span>\n                    </li>\n");
            EndContext();
#line 52 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
                }

#line default
#line hidden
            BeginContext(2299, 121, true);
            WriteLiteral("                <li class=\"list-group-item d-flex justify-content-between\">\n                    <span>Total (USD)</span>\n");
            EndContext();
            BeginContext(2443, 33, true);
            WriteLiteral("                        <strong>$");
            EndContext();
            BeginContext(2477, 11, false);
#line 56 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
                            Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(2488, 10, true);
            WriteLiteral("</strong>\n");
            EndContext();
            BeginContext(2520, 205, true);
            WriteLiteral("                </li>\n            </ul>\n        </div>\n        <div class=\"col-md-8 order-md-1\">\n            <h4 class=\"mb-3\">Shipping address</h4>\n            <div class=\"d-inline-block\">\n                ");
            EndContext();
            BeginContext(2726, 23, false);
#line 64 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
           Write(Model.Address.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2749, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2751, 22, false);
#line 64 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
                                    Write(Model.Address.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2773, 23, true);
            WriteLiteral("<br />\n                ");
            EndContext();
            BeginContext(2797, 20, false);
#line 65 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
           Write(Model.Address.Street);

#line default
#line hidden
            EndContext();
            BeginContext(2817, 7, true);
            WriteLiteral("<br />\n");
            EndContext();
#line 66 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
                 if (Model.Address.Street2 != null)
                {
                    

#line default
#line hidden
            BeginContext(2915, 21, false);
#line 68 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
               Write(Model.Address.Street2);

#line default
#line hidden
            EndContext();
            BeginContext(2936, 7, true);
            WriteLiteral("<br />\n");
            EndContext();
#line 69 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
                }

#line default
#line hidden
            BeginContext(2961, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2978, 18, false);
#line 70 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
           Write(Model.Address.City);

#line default
#line hidden
            EndContext();
            BeginContext(2996, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2998, 19, false);
#line 70 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
                               Write(Model.Address.State);

#line default
#line hidden
            EndContext();
            BeginContext(3017, 23, true);
            WriteLiteral("<br />\n                ");
            EndContext();
            BeginContext(3041, 17, false);
#line 71 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
           Write(Model.Address.Zip);

#line default
#line hidden
            EndContext();
            BeginContext(3058, 23, true);
            WriteLiteral("<br />\n                ");
            EndContext();
            BeginContext(3082, 21, false);
#line 72 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
           Write(Model.Address.Country);

#line default
#line hidden
            EndContext();
            BeginContext(3103, 158, true);
            WriteLiteral("\n            </div>\n            <hr class=\"mb-4\">\n            <h4 class=\"mb-3\">Shipping method:</h4>\n            <div class=\"d-inline-block\">\n                ");
            EndContext();
            BeginContext(3262, 14, false);
#line 77 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Checkout\Confirmed.cshtml"
           Write(Model.Shipping);

#line default
#line hidden
            EndContext();
            BeginContext(3276, 62, true);
            WriteLiteral("\n            </div>\n            <hr class=\"mb-4\">\n            ");
            EndContext();
            BeginContext(3338, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1752fd8262ce4f229dec625b07405b8a", async() => {
                BeginContext(3385, 121, true);
                WriteLiteral("\n                <button class=\"btn btn-success btn-lg btn-block\" type=\"submit\">Return to shopping!</button>\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3513, 34, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
