#pragma checksum "/home/yago/Downloads/UC07-ATV1/Biblioteca/Views/Usuarios/CadastroRealizado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a578e4e43c51666360bb8071129a1cb424282a9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_CadastroRealizado), @"mvc.1.0.view", @"/Views/Usuarios/CadastroRealizado.cshtml")]
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
#line 1 "/home/yago/Downloads/UC07-ATV1/Biblioteca/Views/_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/yago/Downloads/UC07-ATV1/Biblioteca/Views/_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a578e4e43c51666360bb8071129a1cb424282a9d", @"/Views/Usuarios/CadastroRealizado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_CadastroRealizado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Listagem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "/home/yago/Downloads/UC07-ATV1/Biblioteca/Views/Usuarios/CadastroRealizado.cshtml"
  
    ViewData["Title"] = "Cadastro Realizado";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""row justify-content-md-center"">Usuário Cadastrado!</h1>
<div class=""row text-center"" >
    <table class=""table"">
                <thead>
                    <tr>
                        <th colspan=""2"">Dados do Usuário</th>
                        </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Id:</td>
                        <td>");
#nullable restore
#line 17 "/home/yago/Downloads/UC07-ATV1/Biblioteca/Views/Usuarios/CadastroRealizado.cshtml"
                       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <td>Nome:</td>\n                        <td>");
#nullable restore
#line 21 "/home/yago/Downloads/UC07-ATV1/Biblioteca/Views/Usuarios/CadastroRealizado.cshtml"
                       Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <td>Login:</td>\n                        <td>");
#nullable restore
#line 25 "/home/yago/Downloads/UC07-ATV1/Biblioteca/Views/Usuarios/CadastroRealizado.cshtml"
                       Write(Model.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <td>Tipo:</td>\n");
#nullable restore
#line 29 "/home/yago/Downloads/UC07-ATV1/Biblioteca/Views/Usuarios/CadastroRealizado.cshtml"
                         if (Model.Tipo == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Administrador</td>\n");
#nullable restore
#line 32 "/home/yago/Downloads/UC07-ATV1/Biblioteca/Views/Usuarios/CadastroRealizado.cshtml"
                        }else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Padrão</td>\n");
#nullable restore
#line 35 "/home/yago/Downloads/UC07-ATV1/Biblioteca/Views/Usuarios/CadastroRealizado.cshtml"
                        }                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\n                    \n                </tbody>\n                \n        </table>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a578e4e43c51666360bb8071129a1cb424282a9d6915", async() => {
                WriteLiteral("Listar Usuários");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    \n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
