#pragma checksum "C:\Users\LAB2\Documents\GitHub\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c5265288029981a547ac1b7390a3bdcc1ecf0d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departamentos_Index), @"mvc.1.0.view", @"/Views/Departamentos/Index.cshtml")]
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
#line 1 "C:\Users\LAB2\Documents\GitHub\GestionActivos\SistemaActivosFront\GestionActivos\Views\_ViewImports.cshtml"
using GestionActivos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LAB2\Documents\GitHub\GestionActivos\SistemaActivosFront\GestionActivos\Views\_ViewImports.cshtml"
using GestionActivos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c5265288029981a547ac1b7390a3bdcc1ecf0d7", @"/Views/Departamentos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06ccbeb79ff2b4b65a11fbe06774575f7ba5dbea", @"/Views/_ViewImports.cshtml")]
    public class Views_Departamentos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemasActivos.API.Model.DepartamentosViewmodel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("collapse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#CollapseCrear"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-expanded", new global::Microsoft.AspNetCore.Html.HtmlString("false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-controls", new global::Microsoft.AspNetCore.Html.HtmlString("collapseExample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#CollapseActualizar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Eliminar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#ModalEliminar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\LAB2\Documents\GitHub\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c5265288029981a547ac1b7390a3bdcc1ecf0d77345", async() => {
                WriteLiteral("Nuevo");
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
            WriteLiteral("\r\n\r\n</p>\r\n<div class=\"collapse\" id=\"CollapseCrear\">\r\n    <div class=\"card card-body\">\r\n        ");
#nullable restore
#line 16 "C:\Users\LAB2\Documents\GitHub\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Index.cshtml"
   Write(Html.Partial("_Create", new SistemasActivos.API.Model.DepartamentosViewmodel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"collapse\" id=\"CollapseActualizar\">\r\n    <div class=\"card card-body\">\r\n        ");
#nullable restore
#line 22 "C:\Users\LAB2\Documents\GitHub\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Index.cshtml"
   Write(Html.Partial("_Update", new SistemasActivos.API.Model.DepartamentosViewmodel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<table class=\"table table-bordered table-striped\" id=\"example\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\LAB2\Documents\GitHub\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Depa_Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\LAB2\Documents\GitHub\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Depa_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>Acciones</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\LAB2\Documents\GitHub\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\LAB2\Documents\GitHub\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Depa_Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\LAB2\Documents\GitHub\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Depa_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c5265288029981a547ac1b7390a3bdcc1ecf0d711842", async() => {
                WriteLiteral("<i class=\"mdi mdi-pencil btn btn-primary mr-2\">Editar</i>");
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
#line 52 "C:\Users\LAB2\Documents\GitHub\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Index.cshtml"
                                           WriteLiteral(item.Depa_Codigo);

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
            AddHtmlAttributeValue("", 1891, "LLenarCollapse(\'", 1891, 16, true);
#nullable restore
#line 52 "C:\Users\LAB2\Documents\GitHub\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Index.cshtml"
AddHtmlAttributeValue("", 1907, item.Depa_Codigo, 1907, 17, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1924, "\')", 1924, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 2351, "\"", 2435, 1);
#nullable restore
#line 56 "C:\Users\LAB2\Documents\GitHub\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Index.cshtml"
WriteAttributeValue("", 2358, Url.Action("Details", "Departamentos", new {Depa_Codigo = item.Depa_Codigo}), 2358, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mdi mdi-eye btn btn-warning mr-2\">detalle</a>\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c5265288029981a547ac1b7390a3bdcc1ecf0d715702", async() => {
                WriteLiteral("<i class=\"mdi mdi-trash-can btn btn-danger \">Eliminar</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\LAB2\Documents\GitHub\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Index.cshtml"
                                               WriteLiteral(item.Depa_Codigo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2727, "ObtenerDelete(\'", 2727, 15, true);
#nullable restore
#line 58 "C:\Users\LAB2\Documents\GitHub\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Index.cshtml"
AddHtmlAttributeValue("", 2742, item.Depa_Codigo, 2742, 17, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2759, "\')", 2759, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 62 "C:\Users\LAB2\Documents\GitHub\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div class=""modal fade"" id=""ModalEliminar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h3 class=""modal-title"" id=""exampleModalLabel"">Eliminar</h3>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""form-group"">
                    <h3>Esta seguro de eliminar este registro?</h3>
                </div>
                <div class=""modal-body"">
                    ");
#nullable restore
#line 80 "C:\Users\LAB2\Documents\GitHub\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Index.cshtml"
               Write(Html.Partial("_Delete", new SistemasActivos.API.Model.DepartamentosViewmodel()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>


<script>

    var table = new DataTable('#myTable', {
        language: {
            url: '//cdn.datatables.net/plug-ins/2.0.3/i18n/es-ES.json',
        },
    });
</script>




<script>

    function LLenarCollapse(id) {
        //$("".editar-depa"").click(function () {
        console.log(""entra?"");
        //var id = $(this).data(""depa-id"");
        var url = ""https://localhost:44311/API/Departamento/LlenarDepartamentos/"" + id;
        console.log(url);
        fetch(url).then(function (result) {
            if (result.ok) {
                console.log(""entra?"");
                return result.json();
            }
            else {
                console.log(""No entra"");
            }
        }).then(function (data) {
            console.log(""data = "" + data);
            var descripcion = data.descripcion;

            console.log(""Id="" + id);
            console.log(""des="" + data.descri");
            WriteLiteral(@"pcion);

            $(""#Depa_Cod"").val(id);
            $(""#txtDescripcion"").val(descripcion);

        });
    }

    //$("".detalle-depa"").click(function () {
    //    console.log(""entra?"");
    //    var id = $(this).data(""depa-id"");
    //    var url = ""https://localhost:44311/API/Departamento/Detalles/"" + id;
    //    fetch(url).then(function (result) {
    //        if (result.ok) {
    //            console.log(""entra?"");
    //            return result.json();
    //        }
    //        else {
    //            console.log(""No entra"");
    //        }
    //    }).then(function (data) {
    //        console.log(""data = "" + data);
    //        var descripcion = data.descripcion;

    //        console.log(""Id="" + id);
    //        console.log(""des="" + data.descripcion);
    //        console.log(""uc="" + data.usuacrea);
    //        console.log(""um="" + data.usuamodi);
    //        console.log(""fc="" + data.fechacrea);
    //        console.log(""fm="" + data.fechamodi");
            WriteLiteral(@");

    //        $(""#Depa_Cod"").val(id);
    //        $(""#txtDescripcion"").val(descripcion);
    //        $(""#txtUsuacrea"").val(data.usuacrea);
    //        $(""#txtfechacrea"").val(data.fechacrea);
    //        $(""#txtUsuaModi"").val(data.usuamodi);
    //        $(""#fechamodi"").val(data.fechamodi);

    //    });
    //})

    function ObtenerDelete(id) {
        $(""#Depa_Codi"").val(id);
        console.log(""id"" + id);
        sessionStorage.setItem('sess', id);
    }
    function validarId() {
        var valor = sessionStorage.getItem('sess');
        if (valor != $(""#id"").val()) {
            $(""#btnEliminar"").attr(""name"", ""invalido"")
        }
        sessionStorage.clear();
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemasActivos.API.Model.DepartamentosViewmodel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
