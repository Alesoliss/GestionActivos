#pragma checksum "C:\Users\LAB1\Desktop\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33887bffd110d8a9203872fc93b038e8ac52b979"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departamentos_Details), @"mvc.1.0.view", @"/Views/Departamentos/Details.cshtml")]
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
#line 1 "C:\Users\LAB1\Desktop\GestionActivos\SistemaActivosFront\GestionActivos\Views\_ViewImports.cshtml"
using GestionActivos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LAB1\Desktop\GestionActivos\SistemaActivosFront\GestionActivos\Views\_ViewImports.cshtml"
using GestionActivos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33887bffd110d8a9203872fc93b038e8ac52b979", @"/Views/Departamentos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06ccbeb79ff2b4b65a11fbe06774575f7ba5dbea", @"/Views/_ViewImports.cshtml")]
    public class Views_Departamentos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemasActivos.API.Model.DepartamentosViewmodel>>
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\LAB1\Desktop\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Details.cshtml"
 foreach (var depa in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h4>DepartamentosViewmodel</h4>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 12 "C:\Users\LAB1\Desktop\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Details.cshtml"
           Write(Html.DisplayNameFor(model => depa.Depa_Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 15 "C:\Users\LAB1\Desktop\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Details.cshtml"
           Write(Html.DisplayFor(model => depa.Depa_Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 18 "C:\Users\LAB1\Desktop\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Details.cshtml"
           Write(Html.DisplayNameFor(model => depa.Depa_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 21 "C:\Users\LAB1\Desktop\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Details.cshtml"
           Write(Html.DisplayFor(model => depa.Depa_Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n        </dl>\r\n    </div>\r\n    <table class=\"table table-bordered table-striped\" id=\"example\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 30 "C:\Users\LAB1\Desktop\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Details.cshtml"
               Write(Html.DisplayNameFor(model => depa.Uuno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 33 "C:\Users\LAB1\Desktop\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Details.cshtml"
               Write(Html.DisplayNameFor(model => depa.Depa_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 36 "C:\Users\LAB1\Desktop\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Details.cshtml"
               Write(Html.DisplayNameFor(model => depa.Udos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 39 "C:\Users\LAB1\Desktop\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Details.cshtml"
               Write(Html.DisplayNameFor(model => depa.Depa_FechaModificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\LAB1\Desktop\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Details.cshtml"
               Write(Html.DisplayFor(model => depa.Uuno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\LAB1\Desktop\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Details.cshtml"
               Write(Html.DisplayFor(model => depa.Depa_FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\LAB1\Desktop\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Details.cshtml"
               Write(Html.DisplayFor(model => depa.Udos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\LAB1\Desktop\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Details.cshtml"
               Write(Html.DisplayFor(model => depa.Depa_FechaModificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n\r\n    </table>\r\n");
#nullable restore
#line 61 "C:\Users\LAB1\Desktop\GestionActivos\SistemaActivosFront\GestionActivos\Views\Departamentos\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33887bffd110d8a9203872fc93b038e8ac52b9798782", async() => {
                WriteLiteral("Regresar");
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
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
