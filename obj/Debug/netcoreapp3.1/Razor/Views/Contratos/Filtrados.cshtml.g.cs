#pragma checksum "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Contratos\Filtrados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "009f0e213d8460a04f00605938ba42c71ceb0ca7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contratos_Filtrados), @"mvc.1.0.view", @"/Views/Contratos/Filtrados.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"009f0e213d8460a04f00605938ba42c71ceb0ca7", @"/Views/Contratos/Filtrados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf381669dde6995b9201d231bb8643b95e5b7cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Contratos_Filtrados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inmobiliaria.Models.Contratos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Contratos\Filtrados.cshtml"
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
                <label>ID Contrato</label>
            </th>
            <th>
                <label>Inquilino</label>
            </th>
            <th>
                <label>Direccion Inmueble</label>
            </th>
            <th>
                <label>Tipo Inmueble</label>
            </th>
            <th>
                <label>Fecha Inicio</label>
            </th>
            <th>
                <label>Fecha Cierre</label>
            </th>
            <th>
                <label>Importe</label>
            </th>
            <th>
                <label>Vigente</label>
            </th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 39 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Contratos\Filtrados.cshtml"
         foreach (var item in (IList<Contratos>)ViewBag.Filtrados)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 43 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Contratos\Filtrados.cshtml"
   Write(item.IdContr);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 46 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Contratos\Filtrados.cshtml"
    Write(item.Inquilinos.Nombre + " " + item.Inquilinos.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </td>\n    <td>\n        ");
#nullable restore
#line 50 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Contratos\Filtrados.cshtml"
   Write(item.Inmuebles.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 53 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Contratos\Filtrados.cshtml"
   Write(item.Inmuebles.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 56 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Contratos\Filtrados.cshtml"
   Write(item.FechaInicio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 59 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Contratos\Filtrados.cshtml"
   Write(item.FechaCierre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 62 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Contratos\Filtrados.cshtml"
   Write(item.Monto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 65 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Contratos\Filtrados.cshtml"
   Write(item.Vigente);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 68 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Contratos\Filtrados.cshtml"
   Write(Html.ActionLink("Edit", "Editar", new { id = item.IdContr }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n        \n        ");
#nullable restore
#line 70 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Contratos\Filtrados.cshtml"
   Write(Html.ActionLink("Delete", "Eliminar", new { id = item.IdContr }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                \n    </td>\n</tr>");
#nullable restore
#line 72 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Contratos\Filtrados.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Inmobiliaria.Models.Contratos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
