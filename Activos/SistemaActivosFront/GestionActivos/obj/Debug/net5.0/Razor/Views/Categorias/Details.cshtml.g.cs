#pragma checksum "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Categorias\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e824c7a792e40934c83bfd8f2aeb0d57c6e301c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorias_Details), @"mvc.1.0.view", @"/Views/Categorias/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e824c7a792e40934c83bfd8f2aeb0d57c6e301c8", @"/Views/Categorias/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06ccbeb79ff2b4b65a11fbe06774575f7ba5dbea", @"/Views/_ViewImports.cshtml")]
    public class Views_Categorias_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemasActivos.API.Model.CategoriasViewmodel>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Categorias\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n");
#nullable restore
#line 9 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Categorias\Details.cshtml"
 foreach (var cate in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h4>CategoriasViewmodel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        \r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Categorias\Details.cshtml"
       Write(Html.DisplayNameFor(model => cate.Cate_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Categorias\Details.cshtml"
       Write(Html.DisplayFor(model => cate.Cate_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n       \r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Categorias\Details.cshtml"
       Write(Html.DisplayNameFor(model => cate.Cate_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Categorias\Details.cshtml"
       Write(Html.DisplayFor(model => cate.Cate_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        \r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Categorias\Details.cshtml"
       Write(Html.DisplayNameFor(model => cate.Cate_FechaModificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Categorias\Details.cshtml"
       Write(Html.DisplayFor(model => cate.Cate_FechaModificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Categorias\Details.cshtml"
       Write(Html.DisplayNameFor(model => cate.Uuno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Categorias\Details.cshtml"
       Write(Html.DisplayFor(model => cate.Uuno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Categorias\Details.cshtml"
       Write(Html.DisplayNameFor(model => cate.Udos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Categorias\Details.cshtml"
       Write(Html.DisplayFor(model => cate.Udos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
#nullable restore
#line 50 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Categorias\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 52 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Categorias\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e824c7a792e40934c83bfd8f2aeb0d57c6e301c88277", async() => {
                WriteLiteral("Back to List");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemasActivos.API.Model.CategoriasViewmodel>> Html { get; private set; }
    }
}
#pragma warning restore 1591