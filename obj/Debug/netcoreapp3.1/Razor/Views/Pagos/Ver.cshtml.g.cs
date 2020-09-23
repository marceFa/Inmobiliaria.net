#pragma checksum "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Pagos\Ver.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83afa60f572ab5b49ba0182250d82cdbe200d1dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pagos_Ver), @"mvc.1.0.view", @"/Views/Pagos/Ver.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83afa60f572ab5b49ba0182250d82cdbe200d1dc", @"/Views/Pagos/Ver.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf381669dde6995b9201d231bb8643b95e5b7cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagos_Ver : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inmobiliaria.Models.Pagos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Pagos\Ver.cshtml"
   ViewData["Title"] = "Ver"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Ver</h2>\n\n<p>\n    <h4>Contrato:");
#nullable restore
#line 8 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Pagos\Ver.cshtml"
            Write(ViewBag.Contratos.IdContr);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -- Inquilino: ");
#nullable restore
#line 8 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Pagos\Ver.cshtml"
                                                     Write(ViewBag.Contratos.Inquilinos.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 8 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Pagos\Ver.cshtml"
                                                                                           Write(ViewBag.Contratos.Inquilinos.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    <h4>Inmueble: ");
#nullable restore
#line 9 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Pagos\Ver.cshtml"
             Write(ViewBag.Contratos.Inmuebles.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -- Direccion: ");
#nullable restore
#line 9 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Pagos\Ver.cshtml"
                                                             Write(ViewBag.Contratos.Inmuebles.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                <label>ID Pago</label>
            </th>
            <th>
                <label>Numero De Pago</label>
            </th>
            <th>
                <label>Contrato</label>
            </th>
            <th>
                <label>Fecha De Pago</label>
            </th>
            <th>
                <label>Importe</label>
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 33 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Pagos\Ver.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 37 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Pagos\Ver.cshtml"
   Write(Html.DisplayFor(modelItem => item.IdPago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 40 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Pagos\Ver.cshtml"
   Write(Html.DisplayFor(modelItem => item.NumPago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 43 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Pagos\Ver.cshtml"
   Write(Html.DisplayFor(modelItem => item.IdContr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 46 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Pagos\Ver.cshtml"
   Write(Html.DisplayFor(modelItem => item.FechaPago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 49 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Pagos\Ver.cshtml"
   Write(Html.DisplayFor(modelItem => item.Importe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 52 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Pagos\Ver.cshtml"
   Write(Html.ActionLink("Editar", "Edit", new { id = item.IdPago }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n\n        ");
#nullable restore
#line 54 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Pagos\Ver.cshtml"
   Write(Html.ActionLink("Eliminar", "Delete", new { id = item.IdPago }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n    </td>\n\n</tr>");
#nullable restore
#line 57 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Pagos\Ver.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("       ");
#nullable restore
#line 57 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Pagos\Ver.cshtml"
        Write(Html.ActionLink("Realizar Pago", "Create", "Pagos", new { id = @ViewBag.Contratos.IdInm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</tbody>\n</table>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83afa60f572ab5b49ba0182250d82cdbe200d1dc8121", async() => {
                WriteLiteral("Volver");
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
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Inmobiliaria.Models.Pagos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
