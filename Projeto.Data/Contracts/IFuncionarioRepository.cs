using Projeto.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Contracts
{
    public interface IFuncionarioRepository : IBaseRepository<Funcionario>
    {
        List<Funcionario> ObterPorIdCargo(int id);
        List<Funcionario> ObterPorIdDepartamento(int id);

        List<Funcionario> ConsultarPorNome(string nome);

    }
}
