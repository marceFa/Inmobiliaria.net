#pragma checksum "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01549f360c5c1839292f5bbc3224949039c5d696"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privado), @"mvc.1.0.view", @"/Views/Home/Privado.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01549f360c5c1839292f5bbc3224949039c5d696", @"/Views/Home/Privado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf381669dde6995b9201d231bb8643b95e5b7cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inmobiliaria.Models.Inmuebles>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
   ViewData["Title"] = "Privado"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Mis Propiedades</h2>\n\n<h4>\n    <b>\n");
#nullable restore
#line 8 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
         foreach (var u in User.Claims)
        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
Write(u.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />");
#nullable restore
#line 10 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </b>\n</h4>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n\n            <th>\n                ");
#nullable restore
#line 19 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
           Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
           Write(Html.DisplayNameFor(model => model.Uso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 28 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
           Write(Html.DisplayNameFor(model => model.CantAmbientes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 31 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
           Write(Html.DisplayNameFor(model => model.Costo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 34 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
           Write(Html.DisplayNameFor(model => model.Disponible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 40 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n\n    <td>\n        ");
#nullable restore
#line 45 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
   Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 48 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
   Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 51 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
   Write(Html.DisplayFor(modelItem => item.Uso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 54 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
   Write(Html.DisplayFor(modelItem => item.CantAmbientes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 57 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
   Write(Html.DisplayFor(modelItem => item.Costo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 60 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
   Write(Html.DisplayFor(modelItem => item.Disponible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 63 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
   Write(Html.ActionLink("Editar", "EditDeUs","Inmuebles", new { id = item.IdInm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n</tr>");
#nullable restore
#line 65 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Home\Privado.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n\n\n<li><a class=\"nav-link\" href=\"../Usuarios/Logout\">Cerrar Sesion</a></li>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Inmobiliaria.Models.Inmuebles>> Html { get; private set; }
    }
}
#pragma warning restore 1591
