#pragma checksum "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "989d6d020b347f417c029b2dd48c3083057333a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Activos_Index), @"mvc.1.0.view", @"/Views/Activos/Index.cshtml")]
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
#line 1 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\_ViewImports.cshtml"
using GestionActivos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\_ViewImports.cshtml"
using GestionActivos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"989d6d020b347f417c029b2dd48c3083057333a9", @"/Views/Activos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06ccbeb79ff2b4b65a11fbe06774575f7ba5dbea", @"/Views/_ViewImports.cshtml")]
    public class Views_Activos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaActivos.Common.Model.ActivosViewmodel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("collapse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#CollapseCrear"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-expanded", new global::Microsoft.AspNetCore.Html.HtmlString("false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-controls", new global::Microsoft.AspNetCore.Html.HtmlString("collapseExample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#CollapseActualizar , #CollapseTabla"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css\" crossorigin=\"anonymous\" />\r\n\r\n<h1>Index</h1>\r\n<p>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "989d6d020b347f417c029b2dd48c3083057333a96412", async() => {
                WriteLiteral("Nuevo<i class=\"fas fa-plus\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</p>\r\n\r\n\r\n<div class=\"collapse\" id=\"CollapseCrear\">\r\n    <div class=\"card card-body\">\r\n        ");
#nullable restore
#line 18 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
   Write(Html.Partial("Create", new SistemaActivos.Common.Model.ActivosViewmodel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n<div class=\"collapse\" id=\"CollapseActualizar\">\r\n    <div class=\"card card-body\">\r\n        ");
#nullable restore
#line 24 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
   Write(Html.Partial("_Update", new SistemaActivos.Common.Model.ActivosViewmodel()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>
<table class=""table table-striped table-bordered"" id=""activosTable"">
    <thead>
        <tr>
            <th>
                Categoría
            </th>
            <th>
                Descripción
            </th>
            <th>
                Precio
            </th>
            <th>
                Marca
            </th>
            <th>
                Modelo
            </th>
            <th>
                Número de Serie
            </th>
            <th>
                Fecha de Adquisición
            </th>
            <th>
                Encargado
            </th>
            <th>
                Vida Estimada
            </th>
            <th>
                Acciones
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 63 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cate_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Acti_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Acti_Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Acti_Marca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Acti_Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 82 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Acti_NoSerio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 85 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Acti_FechaAdquisicion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 88 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Encargado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 91 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.VidU_VidaEstimada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "989d6d020b347f417c029b2dd48c3083057333a913228", async() => {
                WriteLiteral("<i class=\"fas fa-edit btn btn-primary mr-2\">Editar</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
                                           WriteLiteral(item.Acti_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3024, "LLenarCollapse(\'", 3024, 16, true);
#nullable restore
#line 94 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
AddHtmlAttributeValue("", 3040, item.Acti_Id, 3040, 13, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3053, "\')", 3053, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("|\r\n\r\n                    <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 3163, "\"", 3219, 1);
#nullable restore
#line 96 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
WriteAttributeValue("", 3170, Url.Action("Details", new { id = item.Acti_Id }), 3170, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fas fa-info-circle\"></i> Detalles\r\n                    </a>\r\n                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 3363, "\"", 3418, 1);
#nullable restore
#line 99 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
WriteAttributeValue("", 3370, Url.Action("Delete", new { id = item.Acti_Id }), 3370, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fas fa-trash-alt\"></i> Eliminar\r\n                    </a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 104 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<script>\r\n    $(document).ready(function () {\r\n        var successMessage = \'");
#nullable restore
#line 109 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
                         Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        var errorMessage = \'");
#nullable restore
#line 110 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
                       Write(TempData["ErrorMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n          var warningMessage = \'");
#nullable restore
#line 111 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Index.cshtml"
                           Write(TempData["WarningMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

        //if (warningMessage) {
        //    toastr.warning(warningMessage);
        //}

        //if (successMessage) {
        //    toastr.success(successMessage);
        //}

        //if (errorMessage) {
        //    toastr.error(errorMessage);
        //}
    });
</script>


<!-- CSS de Toastr -->
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css"">

<!-- jQuery (necesario para Toastr) -->
<script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>

<!-- Toastr -->
<script src=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js""></script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemaActivos.Common.Model.ActivosViewmodel>> Html { get; private set; }
    }
}
#pragma warning restore 1591