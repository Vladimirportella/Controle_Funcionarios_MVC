#pragma checksum "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Departamento\Consulta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7ba9d435ba2557a897707e122a3c85a4be98671"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departamento_Consulta), @"mvc.1.0.view", @"/Views/Departamento/Consulta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Departamento/Consulta.cshtml", typeof(AspNetCore.Views_Departamento_Consulta))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7ba9d435ba2557a897707e122a3c85a4be98671", @"/Views/Departamento/Consulta.cshtml")]
    public class Views_Departamento_Consulta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Projeto.Data.Entities.Departamento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Departamento\Consulta.cshtml"
  
    ViewData["Title"] = "Consulta";
    Layout = "~/Views/Templates/Layout.cshtml";

#line default
#line hidden
            BeginContext(144, 79, true);
            WriteLiteral("\r\n<h4>Listagem de Departamentos Cadastrados</h4>\r\n<hr />\r\n\r\n<div>\r\n    <strong>");
            EndContext();
            BeginContext(224, 20, false);
#line 12 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Departamento\Consulta.cshtml"
       Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(244, 315, true);
            WriteLiteral(@"</strong>
</div>

<table class=""table table-bordered table-hover table-striped"">
    <thead>
        <tr>
            <th>Código</th>
            <th>Nome</th>
            <th>Descrição</th>
            <th>Nº de Funcionários</th>
            <th>Operações</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 26 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Departamento\Consulta.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(608, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(647, 19, false);
#line 29 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Departamento\Consulta.cshtml"
               Write(item.IdDepartamento);

#line default
#line hidden
            EndContext();
            BeginContext(666, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(694, 9, false);
#line 30 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Departamento\Consulta.cshtml"
               Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(703, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(731, 14, false);
#line 31 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Departamento\Consulta.cshtml"
               Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(745, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(773, 23, false);
#line 32 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Departamento\Consulta.cshtml"
               Write(item.Funcionarios.Count);

#line default
#line hidden
            EndContext();
            BeginContext(796, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 847, "\"", 898, 2);
            WriteAttributeValue("", 854, "/Departamento/Edicao?id=", 854, 24, true);
#line 34 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Departamento\Consulta.cshtml"
WriteAttributeValue("", 878, item.IdDepartamento, 878, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(899, 69, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Atualizar</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 968, "\"", 1021, 2);
            WriteAttributeValue("", 975, "/Departamento/Exclusao?id=", 975, 26, true);
#line 35 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Departamento\Consulta.cshtml"
WriteAttributeValue("", 1001, item.IdDepartamento, 1001, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1022, 197, true);
            WriteLiteral("\r\n                       class=\"btn btn-danger btn-sm\"\r\n                       onclick=\"return confirm(\'Deseja excluir esse departamento?\');\">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 40 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Departamento\Consulta.cshtml"
        }

#line default
#line hidden
            BeginContext(1230, 111, true);
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"5  \">\r\n                Quantidade de cargos: ");
            EndContext();
            BeginContext(1342, 11, false);
#line 45 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Departamento\Consulta.cshtml"
                                 Write(Model.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1353, 62, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Projeto.Data.Entities.Departamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
