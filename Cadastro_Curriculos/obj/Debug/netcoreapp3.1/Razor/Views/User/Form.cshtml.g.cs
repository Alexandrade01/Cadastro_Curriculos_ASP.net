#pragma checksum "C:\Users\alexb\OneDrive - Fundação Salvador Arena\5 SEMESTRE\Linguagem de Programação I\prova n2b1\Cadastro_Curriculos\Cadastro_Curriculos\Views\User\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07317319d3a5c7a89bac5bf48f7fe963ed772b61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Form), @"mvc.1.0.view", @"/Views/User/Form.cshtml")]
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
#line 1 "C:\Users\alexb\OneDrive - Fundação Salvador Arena\5 SEMESTRE\Linguagem de Programação I\prova n2b1\Cadastro_Curriculos\Cadastro_Curriculos\Views\_ViewImports.cshtml"
using Cadastro_Curriculos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alexb\OneDrive - Fundação Salvador Arena\5 SEMESTRE\Linguagem de Programação I\prova n2b1\Cadastro_Curriculos\Cadastro_Curriculos\Views\_ViewImports.cshtml"
using Cadastro_Curriculos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07317319d3a5c7a89bac5bf48f7fe963ed772b61", @"/Views/User/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75b2f904ee6ac20c343317f72b3c76be0032e583", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\alexb\OneDrive - Fundação Salvador Arena\5 SEMESTRE\Linguagem de Programação I\prova n2b1\Cadastro_Curriculos\Cadastro_Curriculos\Views\User\Form.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Cadastro de Currículos</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07317319d3a5c7a89bac5bf48f7fe963ed772b614449", async() => {
                WriteLiteral("\r\n    <label for=\"Id\" class=\"form-label\">Id</label>\r\n    <input type=\"number\" Name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 230, "\"", 247, 1);
#nullable restore
#line 8 "C:\Users\alexb\OneDrive - Fundação Salvador Arena\5 SEMESTRE\Linguagem de Programação I\prova n2b1\Cadastro_Curriculos\Cadastro_Curriculos\Views\User\Form.cshtml"
WriteAttributeValue("", 238, Model.Id, 238, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    <label for=\"CPF\" class=\"form-label\">CPF</label>\r\n    <input type=\"text\" Name=\"CPF\"");
                BeginWriteAttribute("value", " value=\"", 351, "\"", 369, 1);
#nullable restore
#line 11 "C:\Users\alexb\OneDrive - Fundação Salvador Arena\5 SEMESTRE\Linguagem de Programação I\prova n2b1\Cadastro_Curriculos\Cadastro_Curriculos\Views\User\Form.cshtml"
WriteAttributeValue("", 359, Model.CPF, 359, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    <label for=\"Nome\" class=\"form-label\">Nome do usuário</label>\r\n    <input type=\"text\" Name=\"Nome\"");
                BeginWriteAttribute("value", " value=\"", 487, "\"", 506, 1);
#nullable restore
#line 14 "C:\Users\alexb\OneDrive - Fundação Salvador Arena\5 SEMESTRE\Linguagem de Programação I\prova n2b1\Cadastro_Curriculos\Cadastro_Curriculos\Views\User\Form.cshtml"
WriteAttributeValue("", 495, Model.Nome, 495, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n\r\n    <input type=\"submit\" value=\"Salvar dados\" />\r\n    <br />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
