#pragma checksum "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "864976c95947d7701bb5882d1905cbf2cb380336"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inmuebles_Disponibles), @"mvc.1.0.view", @"/Views/Inmuebles/Disponibles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"864976c95947d7701bb5882d1905cbf2cb380336", @"/Views/Inmuebles/Disponibles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf381669dde6995b9201d231bb8643b95e5b7cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Inmuebles_Disponibles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inmobiliaria.Models.Inmuebles>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
   ViewData["Title"] = "Inmuebles"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
#nullable restore
#line 7 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
 if (User.IsInRole("Administrador") || User.IsInRole("Empleado"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "864976c95947d7701bb5882d1905cbf2cb3803363920", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\n    <h2>Inmuebles Disponibles</h2>\n</p>");
#nullable restore
#line 12 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Ver Inmuebles</h2>\n<table class=\"table\">\n    <thead>\n        <tr>\n");
#nullable restore
#line 17 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
             if (User.IsInRole("Permitidos"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<th>\n    ");
#nullable restore
#line 20 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
Write(Html.DisplayNameFor(model => model.IdInm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</th>\n             <th>\n                ");
#nullable restore
#line 23 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
           Write(Html.DisplayNameFor(model => model.Propietarios));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n             </th>           \n");
#nullable restore
#line 25 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>\n                ");
#nullable restore
#line 27 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
           Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 30 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 33 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
           Write(Html.DisplayNameFor(model => model.Uso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 36 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
           Write(Html.DisplayNameFor(model => model.CantAmbientes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 39 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
           Write(Html.DisplayNameFor(model => model.Costo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 46 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n\n");
#nullable restore
#line 50 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
     if (User.IsInRole("Permitidos"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>\n    ");
#nullable restore
#line 53 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
Write(Html.DisplayFor(modelItem => item.IdInm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</td>\n<td>\n    ");
#nullable restore
#line 56 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
Write(item.Propietarios.Nombre + " " + item.Propietarios.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</td>               \n");
#nullable restore
#line 58 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <td>\n        ");
#nullable restore
#line 61 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
   Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 64 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
   Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 67 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
   Write(Html.DisplayFor(modelItem => item.Uso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 70 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
   Write(Html.DisplayFor(modelItem => item.CantAmbientes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 73 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
   Write(Html.DisplayFor(modelItem => item.Costo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n\n    <td>\n");
#nullable restore
#line 77 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
         if (User.IsInRole("Permitidos"))
        {


#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
Write(Html.ActionLink("Editar", "Edit", new { id = item.IdInm }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
               Write(Html.ActionLink("Nuevo Contrato", "../Contratos/Create", new { id = item.IdInm }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
                                                                                                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
         if (User.IsInRole("Administrador"))
        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
Write(Html.ActionLink("Eliminar", "Delete", new { id = item.IdInm }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n</tr>");
#nullable restore
#line 87 "C:\Users\Usuario\source\repos\Inmobiliaria\Views\Inmuebles\Disponibles.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Inmobiliaria.Models.Inmuebles>> Html { get; private set; }
    }
}
#pragma warning restore 1591
