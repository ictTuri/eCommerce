#pragma checksum "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72c41426126db76d8fc29d404dc9523a7fdf5ded"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DeleteOrder), @"mvc.1.0.view", @"/Views/Admin/DeleteOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/DeleteOrder.cshtml", typeof(AspNetCore.Views_Admin_DeleteOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72c41426126db76d8fc29d404dc9523a7fdf5ded", @"/Views/Admin/DeleteOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8ae2ccbb7e94b73188ce3e6eb3a1d410ddbaed", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DeleteOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteOrderConfirmed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-lg btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RecentOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(62, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
  
    ViewData["Title"] = "Orders";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(126, 543, true);
            WriteLiteral(@"
<div class=""py-5 text-center"">
    <h2>Delete Order</h2>
    <img class=""d-block mx-auto mb-4"" src=""http://worldartsme.com/images/delete-clipart-1.jpg""  alt=""delete icon"" width=""72"" height=""72""/>
</div>
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-4 order-md-2 mb-4"">
            <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                <span class=""text-muted"">Your checkout bag</span>
                <span class=""badge badge-secondary badge-pill""><i class=""fas fa-shopping-bag""></i>  ");
            EndContext();
            BeginContext(670, 18, false);
#line 18 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                                                                               Write(Model.TotalItemQty);

#line default
#line hidden
            EndContext();
            BeginContext(688, 68, true);
            WriteLiteral("</span>\n\n            </h4>\n            <ul class=\"list-group mb-3\">\n");
            EndContext();
#line 22 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                  
                    decimal orderTotal = 0;
                

#line default
#line hidden
            BeginContext(837, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 25 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                 foreach (var orderItem in Model.OrderItems)
                {
                    var totalItemPrice = orderItem.UnitPrice * orderItem.Quantity;
                    orderTotal += totalItemPrice;

#line default
#line hidden
            BeginContext(1049, 187, true);
            WriteLiteral("                    <li class=\"list-group-item d-flex justify-content-between lh-condensed\">\n                        <div class=\"float-left\">\n                            <h6 class=\"my-0\">");
            EndContext();
            BeginContext(1237, 21, false);
#line 31 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                        Write(orderItem.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1258, 70, true);
            WriteLiteral("</h6>\n                            <small class=\"text-muted\">Quantity: ");
            EndContext();
            BeginContext(1329, 18, false);
#line 32 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                                           Write(orderItem.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1347, 68, true);
            WriteLiteral("</small>\n                        </div>\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1415, "\"", 1438, 1);
#line 34 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
WriteAttributeValue("", 1421, orderItem.ImgUrl, 1421, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1439, 72, true);
            WriteLiteral(" class=\"checkout-img\">\n                        <span class=\"text-muted\">");
            EndContext();
            BeginContext(1512, 14, false);
#line 35 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                            Write(totalItemPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1526, 34, true);
            WriteLiteral("</span>\n                    </li>\n");
            EndContext();
#line 37 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                }

#line default
#line hidden
            BeginContext(1578, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 39 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                 if (Model.DiscountPercent != 0)
                {
                    decimal discountAmt = (Model.DiscountPercent / 100) * orderTotal;

#line default
#line hidden
            BeginContext(1732, 175, true);
            WriteLiteral("                    <li class=\"list-group-item d-flex justify-content-between bg-light\">\n                        <h6 class=\"my-0\">Subtotal</h6>\n                        <span>$");
            EndContext();
            BeginContext(1908, 14, false);
#line 44 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                          Write(Model.Subtotal);

#line default
#line hidden
            EndContext();
            BeginContext(1922, 270, true);
            WriteLiteral(@"</span>
                    </li>
                    <li class=""list-group-item d-flex justify-content-between bg-light"">
                        <div class=""text-success"">
                            <h6 class=""my-0"">Promo code</h6>
                            <small>");
            EndContext();
            BeginContext(2193, 18, false);
#line 49 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                              Write(Model.DiscountName);

#line default
#line hidden
            EndContext();
            BeginContext(2211, 93, true);
            WriteLiteral("</small>\n                        </div>\n                        <span class=\"text-success\">-$");
            EndContext();
            BeginContext(2305, 17, false);
#line 51 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                                Write(Model.DiscountAmt);

#line default
#line hidden
            EndContext();
            BeginContext(2322, 34, true);
            WriteLiteral("</span>\n                    </li>\n");
            EndContext();
#line 53 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                }

#line default
#line hidden
            BeginContext(2374, 121, true);
            WriteLiteral("                <li class=\"list-group-item d-flex justify-content-between\">\n                    <span>Total (USD)</span>\n");
            EndContext();
            BeginContext(2518, 33, true);
            WriteLiteral("                        <strong>$");
            EndContext();
            BeginContext(2552, 11, false);
#line 57 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                            Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(2563, 10, true);
            WriteLiteral("</strong>\n");
            EndContext();
            BeginContext(2595, 215, true);
            WriteLiteral("                </li>\n            </ul>\n        </div>\n        <div class=\"col-md-8 order-md-1\">\n            <div class=\"row\">\n                <div class=\"col-md-6 mb-3\">\n                    <h4 class=\"mb-3\">Order #");
            EndContext();
            BeginContext(2811, 8, false);
#line 65 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                       Write(Model.ID);

#line default
#line hidden
            EndContext();
            BeginContext(2819, 83, true);
            WriteLiteral("</h4>\n                    <p>\n                        <div class=\"d-inline-block\">\n");
            EndContext();
#line 68 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                              
                                var user = await UserManager.FindByIdAsync(Model.UserID);

#line default
#line hidden
            BeginContext(3023, 59, true);
            WriteLiteral("                                <strong>Customer:</strong> ");
            EndContext();
            BeginContext(3083, 14, false);
#line 70 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                                      Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3099, 13, false);
#line 70 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                                                      Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(3112, 7, true);
            WriteLiteral("<br />\n");
            EndContext();
            BeginContext(3149, 57, true);
            WriteLiteral("                            <strong>Order Date:</strong> ");
            EndContext();
            BeginContext(3207, 15, false);
#line 72 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                                    Write(Model.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(3222, 316, true);
            WriteLiteral(@"<br />
                        </div>
                    </p>
                </div>
            </div>
            <hr class=""mb-4"">
            <div class=""row"">
                <div class=""col-md-6 mb-3"">
                    <h4 class=""mb-3"">Shipping address</h4>
                    <p>
                        ");
            EndContext();
            BeginContext(3539, 23, false);
#line 82 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                   Write(Model.Address.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3562, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3564, 22, false);
#line 82 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                            Write(Model.Address.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(3586, 31, true);
            WriteLiteral("<br />\n                        ");
            EndContext();
            BeginContext(3618, 20, false);
#line 83 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                   Write(Model.Address.Street);

#line default
#line hidden
            EndContext();
            BeginContext(3638, 7, true);
            WriteLiteral("<br />\n");
            EndContext();
#line 84 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                         if (Model.Address.Street2 != null)
                        {
                            

#line default
#line hidden
            BeginContext(3760, 21, false);
#line 86 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                       Write(Model.Address.Street2);

#line default
#line hidden
            EndContext();
            BeginContext(3781, 7, true);
            WriteLiteral("<br />\n");
            EndContext();
#line 87 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                        }

#line default
#line hidden
            BeginContext(3814, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3839, 18, false);
#line 88 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                   Write(Model.Address.City);

#line default
#line hidden
            EndContext();
            BeginContext(3857, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3859, 19, false);
#line 88 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                       Write(Model.Address.State);

#line default
#line hidden
            EndContext();
            BeginContext(3878, 31, true);
            WriteLiteral("<br />\n                        ");
            EndContext();
            BeginContext(3910, 17, false);
#line 89 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                   Write(Model.Address.Zip);

#line default
#line hidden
            EndContext();
            BeginContext(3927, 31, true);
            WriteLiteral("<br />\n                        ");
            EndContext();
            BeginContext(3959, 21, false);
#line 90 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                   Write(Model.Address.Country);

#line default
#line hidden
            EndContext();
            BeginContext(3980, 174, true);
            WriteLiteral("\n                    </p>\n                </div>\n                <div class=\"col-md-6 mb-3\">\n                    <h4 class=\"mb-3\">Shipping Method</h4>\n                    <p>");
            EndContext();
            BeginContext(4155, 14, false);
#line 95 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                  Write(Model.Shipping);

#line default
#line hidden
            EndContext();
            BeginContext(4169, 89, true);
            WriteLiteral("</p>\n                </div>\n            </div>\n            <hr class=\"mb-4\">\n            ");
            EndContext();
            BeginContext(4258, 251, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8b22b997f5545eeb6230b192104d25e", async() => {
                BeginContext(4335, 17, true);
                WriteLiteral("\n                ");
                EndContext();
                BeginContext(4352, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "620ea2039c9748f9b7bb4b2d07c81f15", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 100 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
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
                BeginContext(4388, 114, true);
                WriteLiteral("\n                <input type=\"submit\" value=\"Delete Order\" class=\"btn btn-danger btn-lg btn-block\" />\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4509, 35, true);
            WriteLiteral("\n        </div>\n    </div>\n        ");
            EndContext();
            BeginContext(4544, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28178c6348f049958bb8a4af2b57848d", async() => {
                BeginContext(4634, 19, true);
                WriteLiteral("Return to Order Log");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4657, 14, true);
            WriteLiteral("\n</div>\n<br />");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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
