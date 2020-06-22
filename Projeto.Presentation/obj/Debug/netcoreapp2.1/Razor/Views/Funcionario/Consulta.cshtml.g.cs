#pragma checksum "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Funcionario\Consulta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8b54f638a18c440c38d9cb231072a133a2b70c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_Consulta), @"mvc.1.0.view", @"/Views/Funcionario/Consulta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Funcionario/Consulta.cshtml", typeof(AspNetCore.Views_Funcionario_Consulta))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8b54f638a18c440c38d9cb231072a133a2b70c1", @"/Views/Funcionario/Consulta.cshtml")]
    public class Views_Funcionario_Consulta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Projeto.Data.Entities.Funcionario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Funcionario\Consulta.cshtml"
  
    ViewData["Title"] = "Consulta";
    Layout = "~/Views/Templates/Layout.cshtml";

#line default
#line hidden
            BeginContext(141, 512, true);
            WriteLiteral(@"
<h4>Listagem de Funcionários Cadastrados</h4>
<hr />

<form method=""post"" action=""/Funcionario/Consulta"">
    <div class=""row"">
        <div class=""col-md-4"">
            <input type=""text"" class=""form-control"" name=""filtro"" 
                   placeholder=""Informe o nome do funcionário desejado"" />
        </div>
        <div class=""col-md-4"">
            <input type=""submit"" value=""Realizar Pesquisa"" class=""btn btn-success"" />
        </div>
    </div>
</form>
<br />

<div>
    <strong>");
            EndContext();
            BeginContext(654, 20, false);
#line 24 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Funcionario\Consulta.cshtml"
       Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(674, 374, true);
            WriteLiteral(@"</strong>
</div>

<table class=""table table-bordered table-hover table-striped"">
    <thead>
        <tr>
            <th>Código</th>
            <th>Nome</th>
            <th>Salário</th>
            <th>Data de Admissão</th>
            <th>Cargo</th>
            <th>Departamento</th>
            <th>Operações</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 40 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Funcionario\Consulta.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1097, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1136, 18, false);
#line 43 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Funcionario\Consulta.cshtml"
               Write(item.IdFuncionario);

#line default
#line hidden
            EndContext();
            BeginContext(1154, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1182, 9, false);
#line 44 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Funcionario\Consulta.cshtml"
               Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1191, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1219, 12, false);
#line 45 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Funcionario\Consulta.cshtml"
               Write(item.Salario);

#line default
#line hidden
            EndContext();
            BeginContext(1231, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1259, 17, false);
#line 46 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Funcionario\Consulta.cshtml"
               Write(item.DataAdmissao);

#line default
#line hidden
            EndContext();
            BeginContext(1276, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1304, 15, false);
#line 47 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Funcionario\Consulta.cshtml"
               Write(item.Cargo.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1319, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1347, 22, false);
#line 48 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Funcionario\Consulta.cshtml"
               Write(item.Departamento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1369, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1420, "\"", 1469, 2);
            WriteAttributeValue("", 1427, "/Funcionario/Edicao?id=", 1427, 23, true);
#line 50 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Funcionario\Consulta.cshtml"
WriteAttributeValue("", 1450, item.IdFuncionario, 1450, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1470, 69, true);
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Atualizar</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1539, "\"", 1590, 2);
            WriteAttributeValue("", 1546, "/Funcionario/Exclusao?id=", 1546, 25, true);
#line 51 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Funcionario\Consulta.cshtml"
WriteAttributeValue("", 1571, item.IdFuncionario, 1571, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1591, 196, true);
            WriteLiteral("\r\n                       class=\"btn btn-danger btn-sm\"\r\n                       onclick=\"return confirm(\'Deseja excluir esse funcionário?\');\">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 56 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Funcionario\Consulta.cshtml"
        }

#line default
#line hidden
            BeginContext(1798, 109, true);
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"7\">\r\n                Quantidade de cargos: ");
            EndContext();
            BeginContext(1908, 11, false);
#line 61 "C:\Users\windows\Desktop\002\Coti\ListaExercicioMVC\Projeto.Presentation\Views\Funcionario\Consulta.cshtml"
                                 Write(Model.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1919, 58, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tfoot>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Projeto.Data.Entities.Funcionario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
