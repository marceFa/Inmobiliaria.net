#pragma checksum "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\AlgoRestringido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a6de629595338b549c9f8c5756fd08cf4b44296"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AlgoRestringido), @"mvc.1.0.view", @"/Views/Home/AlgoRestringido.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\_ViewImports.cshtml"
using Inmobiliaria;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\_ViewImports.cshtml"
using Inmobiliaria.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a6de629595338b549c9f8c5756fd08cf4b44296", @"/Views/Home/AlgoRestringido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf381669dde6995b9201d231bb8643b95e5b7cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AlgoRestringido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\AlgoRestringido.cshtml"
   ViewData["Title"] = "AlgoRestringido"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>\r\n    <b>\r\n");
#nullable restore
#line 6 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\AlgoRestringido.cshtml"
         foreach (var u in User.Claims)
        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\AlgoRestringido.cshtml"
Write(u.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />");
#nullable restore
#line 8 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\AlgoRestringido.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </b>\r\n");
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
