#pragma checksum "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Doge\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08e3da3e370acce41ccc210213e8ffac6a7c7e6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doge_Index), @"mvc.1.0.view", @"/Views/Doge/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Doge/Index.cshtml", typeof(AspNetCore.Views_Doge_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08e3da3e370acce41ccc210213e8ffac6a7c7e6f", @"/Views/Doge/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8ae2ccbb7e94b73188ce3e6eb3a1d410ddbaed", @"/Views/_ViewImports.cshtml")]
    public class Views_Doge_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Doge\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 907, true);
            WriteLiteral(@"
<h2 class=""text-center"">Welcome to the Secret Doge Page!</h2>
<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-6 text-center mb-4"">
            <img class=""doge-img"" src=""http://www.slate.com/content/dam/slate/articles/news_and_politics/the_slate_quiz/authorPortraits/pronounce_doge4.jpg.CROP.promovar-mediumlarge.jpg"" />
        </div>
        <div class=""col-lg-6 text-center mb-4"">
            <img class=""doge-img"" src=""https://i.ytimg.com/vi/Yj7ja6BANLM/maxresdefault.jpg"" />
        </div>
        <div class=""col-lg-6 text-center mb-4"">
            <img class=""doge-img"" src=""https://images4.sw-cdn.net/product/picture/710x528_7480816_1496035_1459325206.jpg"" />
        </div>
        <div class=""col-lg-6 text-center mb-4"">
            <img class=""doge-img"" src=""https://upload.wikimedia.org/wikipedia/commons/d/df/Doge_homemade_meme.jpg"" />
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591