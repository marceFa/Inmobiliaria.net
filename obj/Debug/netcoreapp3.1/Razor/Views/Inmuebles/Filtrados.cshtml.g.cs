#pragma checksum "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Filtrados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce0d331032823ca0fc4ee8a3be518a4171bedc3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inmuebles_Filtrados), @"mvc.1.0.view", @"/Views/Inmuebles/Filtrados.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce0d331032823ca0fc4ee8a3be518a4171bedc3a", @"/Views/Inmuebles/Filtrados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf381669dde6995b9201d231bb8643b95e5b7cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Inmuebles_Filtrados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inmobiliaria.Models.Inmuebles>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Filtrados.cshtml"
   ViewData["Title"] = "Filtrados"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Filtrados</h2>

<table class=""table"">
    <thead>
        <tr>

            <th>
                <label>Id Inmueble</label>
            </th>
            <th>
                <label>Propietario</label>
            </th>
            <th>
                <label>Direccion</label>
            </th>
            <th>
                <label>Tipo</label>
            </th>
            <th>
                <label>Uso</label>

            </th>
            <th>
                <label>Cantidad de Ambientes</label>

            </th>
            <th>
                <label>Costo</label>
            </th>
            <th>
                <label>Disponible</label>

            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 41 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Filtrados.cshtml"
         foreach (var item in (IList<Inmuebles>)ViewBag.Filtrados)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 45 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Filtrados.cshtml"
   Write(item.IdInm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 48 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Filtrados.cshtml"
    Write(item.Propietarios.Nombre + " " + item.Propietarios.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 51 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Filtrados.cshtml"
   Write(item.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 54 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Filtrados.cshtml"
   Write(item.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 57 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Filtrados.cshtml"
   Write(item.Uso);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 60 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Filtrados.cshtml"
   Write(item.CantAmbientes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 63 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Filtrados.cshtml"
   Write(item.Costo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 66 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Filtrados.cshtml"
   Write(Html.DisplayFor(modelItem => item.Disponible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n</tr>");
#nullable restore
#line 68 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Filtrados.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n");
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