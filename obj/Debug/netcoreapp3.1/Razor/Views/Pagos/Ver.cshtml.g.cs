#pragma checksum "C:\Users\Usuario\Source\Repos\Inmobiliaria.net\Views\Pagos\Ver.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc8590a6ff2a4287e886e42e1a0f4f4a8b218fa5"
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
#line 1 "C:\Users\Usuario\Source\Repos\Inmobiliaria.net\Views\_ViewImports.cshtml"
using Inmobiliaria;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\Source\Repos\Inmobiliaria.net\Views\_ViewImports.cshtml"
using Inmobiliaria.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc8590a6ff2a4287e886e42e1a0f4f4a8b218fa5", @"/Views/Pagos/Ver.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf381669dde6995b9201d231bb8643b95e5b7cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagos_Ver : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inmobiliaria.Models.Pagos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Usuario\Source\Repos\Inmobiliaria.net\Views\Pagos\Ver.cshtml"
   ViewData["Title"] = "Ver"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Ver Pagos</h2>\r\n\r\n<p>\r\n    <h6 class=\"alert alert-success\">\r\n        Pagos correspondientes al Contrato Nº: ");
#nullable restore
#line 9 "C:\Users\Usuario\Source\Repos\Inmobiliaria.net\Views\Pagos\Ver.cshtml"
                                          Write(ViewBag.Contratos.IdContr);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Inquilino: ");
#nullable restore
#line 9 "C:\Users\Usuario\Source\Repos\Inmobiliaria.net\Views\Pagos\Ver.cshtml"
                                                                                Write(ViewBag.Contratos.Inquilinos.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 9 "C:\Users\Usuario\Source\Repos\Inmobiliaria.net\Views\Pagos\Ver.cshtml"
                                                                                                                      Write(ViewBag.Contratos.Inquilinos.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        del Inmueble de tipo: ");
#nullable restore
#line 10 "C:\Users\Usuario\Source\Repos\Inmobiliaria.net\Views\Pagos\Ver.cshtml"
                         Write(ViewBag.Contratos.Inmuebles.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" con Direccion: ");
#nullable restore
#line 10 "C:\Users\Usuario\Source\Repos\Inmobiliaria.net\Views\Pagos\Ver.cshtml"
                                                                          Write(ViewBag.Contratos.Inmuebles.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </h6>
</p>

<table height=""100"" width=""100"" background=""../imagenes/inmo.png"" class=""table"">
    <thead>
        <tr>
            <th bgcolor=""#4CAF50"">
                <label>Numero De Pago</label>
            </th>
            <th bgcolor=""#4CAF50"">
                <label>Nº Contrato</label>
            </th>
            <th bgcolor=""#4CAF50"">
                <label>Fecha De Pago</label>
            </th>
            <th bgcolor=""#4CAF50"">
                <label>Importe</label>
            </th>
            <th bgcolor=""#4CAF50""></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 33 "C:\Users\Usuario\Source\Repos\Inmobiliaria.net\Views\Pagos\Ver.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 37 "C:\Users\Usuario\Source\Repos\Inmobiliaria.net\Views\Pagos\Ver.cshtml"
   Write(Html.DisplayFor(modelItem => item.NumPago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 40 "C:\Users\Usuario\Source\Repos\Inmobiliaria.net\Views\Pagos\Ver.cshtml"
   Write(Html.DisplayFor(modelItem => item.IdContr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 43 "C:\Users\Usuario\Source\Repos\Inmobiliaria.net\Views\Pagos\Ver.cshtml"
   Write(Html.DisplayFor(modelItem => item.FechaPago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 46 "C:\Users\Usuario\Source\Repos\Inmobiliaria.net\Views\Pagos\Ver.cshtml"
   Write(Html.DisplayFor(modelItem => item.Importe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 49 "C:\Users\Usuario\Source\Repos\Inmobiliaria.net\Views\Pagos\Ver.cshtml"
   Write(Html.ActionLink("Editar", "Edit", new { id = item.IdPago }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\r\n        ");
#nullable restore
#line 51 "C:\Users\Usuario\Source\Repos\Inmobiliaria.net\Views\Pagos\Ver.cshtml"
   Write(Html.ActionLink("Eliminar", "Delete", new { id = item.IdPago }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    </td>\r\n\r\n</tr>\r\n");
#nullable restore
#line 55 "C:\Users\Usuario\Source\Repos\Inmobiliaria.net\Views\Pagos\Ver.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("       ");
#nullable restore
#line 55 "C:\Users\Usuario\Source\Repos\Inmobiliaria.net\Views\Pagos\Ver.cshtml"
   Write(Html.ActionLink("Realizar Pago", "Create", "Pagos", new { id = @ViewBag.Contratos.IdInm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</tbody>\r\n</table>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc8590a6ff2a4287e886e42e1a0f4f4a8b218fa58653", async() => {
                WriteLiteral("Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
