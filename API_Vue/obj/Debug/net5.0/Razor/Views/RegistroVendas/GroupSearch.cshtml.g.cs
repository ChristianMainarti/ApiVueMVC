#pragma checksum "C:\Users\SAGATECH\Desktop\.net vue.js\WebApi_MVC\API_Vue\Views\RegistroVendas\GroupSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b589b7f1748cb4976a8427c30c6b033c69750426"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistroVendas_GroupSearch), @"mvc.1.0.view", @"/Views/RegistroVendas/GroupSearch.cshtml")]
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
#line 1 "C:\Users\SAGATECH\Desktop\.net vue.js\WebApi_MVC\API_Vue\Views\_ViewImports.cshtml"
using API_Vue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SAGATECH\Desktop\.net vue.js\WebApi_MVC\API_Vue\Views\_ViewImports.cshtml"
using API_Vue.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b589b7f1748cb4976a8427c30c6b033c69750426", @"/Views/RegistroVendas/GroupSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"028966980b85b235a47bca8c94a708d032164e10", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistroVendas_GroupSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<Departamento, RegistroVenda>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-from navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\SAGATECH\Desktop\.net vue.js\WebApi_MVC\API_Vue\Views\RegistroVendas\GroupSearch.cshtml"
  
    ViewData["Title"] = "Group Search";
    DateTime minDate = DateTime.Parse(ViewData["minDate"] as string);
    DateTime maxDate = DateTime.Parse(ViewData["maxDate"] as string);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 9 "C:\Users\SAGATECH\Desktop\.net vue.js\WebApi_MVC\API_Vue\Views\RegistroVendas\GroupSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b589b7f1748cb4976a8427c30c6b033c697504264789", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <label for=""minDate"">Min Date</label>
                <input type=""date"" class=""form-control"" name=""minDate"" />
            </div>
            <div class=""form-group"">
                <label for=""maxDate"">Max Date</label>
                <input type=""date"" class=""form-control"" name=""maxDate"" />
            </div>
            <button type=""submit"" class=""btn btn-primary"">Filtro</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n");
#nullable restore
#line 28 "C:\Users\SAGATECH\Desktop\.net vue.js\WebApi_MVC\API_Vue\Views\RegistroVendas\GroupSearch.cshtml"
 foreach (var departamentoGrupo in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"panel panel-primary\">\r\n        <div class=\"panel-heading\">\r\n            <h3 class=\"panel-title\">Departamento ");
#nullable restore
#line 32 "C:\Users\SAGATECH\Desktop\.net vue.js\WebApi_MVC\API_Vue\Views\RegistroVendas\GroupSearch.cshtml"
                                            Write(departamentoGrupo.Key.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Vendas Totais = ");
#nullable restore
#line 32 "C:\Users\SAGATECH\Desktop\.net vue.js\WebApi_MVC\API_Vue\Views\RegistroVendas\GroupSearch.cshtml"
                                                                                         Write(departamentoGrupo.Key.TotalVendas(minDate, maxDate).ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
        </div>
        <div class=""panel-body"">
            <table class=""table table-striped table-hover"">
                <thead>
                    <tr class=""success"">
                        <th>
                            Id
                        </th>
                        <th>
                           Montante
                        </th>
                        <th>
                            Data
                        </th>
                        <th>
                            Nome do Vendedor
                        </th>
                        <th>
                           Status da Venda
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 56 "C:\Users\SAGATECH\Desktop\.net vue.js\WebApi_MVC\API_Vue\Views\RegistroVendas\GroupSearch.cshtml"
                     foreach (var item in departamentoGrupo)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 60 "C:\Users\SAGATECH\Desktop\.net vue.js\WebApi_MVC\API_Vue\Views\RegistroVendas\GroupSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 63 "C:\Users\SAGATECH\Desktop\.net vue.js\WebApi_MVC\API_Vue\Views\RegistroVendas\GroupSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Montante));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 66 "C:\Users\SAGATECH\Desktop\.net vue.js\WebApi_MVC\API_Vue\Views\RegistroVendas\GroupSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 69 "C:\Users\SAGATECH\Desktop\.net vue.js\WebApi_MVC\API_Vue\Views\RegistroVendas\GroupSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Vendedor.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 72 "C:\Users\SAGATECH\Desktop\.net vue.js\WebApi_MVC\API_Vue\Views\RegistroVendas\GroupSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 75 "C:\Users\SAGATECH\Desktop\.net vue.js\WebApi_MVC\API_Vue\Views\RegistroVendas\GroupSearch.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 80 "C:\Users\SAGATECH\Desktop\.net vue.js\WebApi_MVC\API_Vue\Views\RegistroVendas\GroupSearch.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<Departamento, RegistroVenda>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
