#pragma checksum "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\Empleados\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb7bf852f808e81bc50c4bfd9e6b6665be5e7a48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleados_Delete), @"mvc.1.0.view", @"/Views/Empleados/Delete.cshtml")]
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
#line 1 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\_ViewImports.cshtml"
using BENT1A.Grupo2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\_ViewImports.cshtml"
using BENT1A.Grupo2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\_ViewImports.cshtml"
using Reserva_Cine.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\_ViewImports.cshtml"
using BENT1A.Grupo2.Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb7bf852f808e81bc50c4bfd9e6b6665be5e7a48", @"/Views/Empleados/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cc7d9fcd0cc4bb9fc1f881649988c977314b0ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Reserva_Cine.Models.Empleado>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\Empleados\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>ELIMINAR</h2>\r\n\r\n<h3>Quiere Realmente eliminar?</h3>\r\n<div>\r\n    <h4>Empleado</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Legajo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Legajo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\Empleados\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb7bf852f808e81bc50c4bfd9e6b6665be5e7a4811177", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cb7bf852f808e81bc50c4bfd9e6b6665be5e7a4811444", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 60 "E:\ORT\TERCER CUATRIMESTRE\JUEVES - NUEVAS TECNOLOGIAS 2\CINE MVC\2020-2-BENT1A-2\BENT1A.Grupo2\Views\Empleados\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-danger\" /> |\r\n         ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb7bf852f808e81bc50c4bfd9e6b6665be5e7a4813280", async() => {
                    WriteLiteral("Cancelar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Reserva_Cine.Models.Empleado> Html { get; private set; }
    }
}
#pragma warning restore 1591
