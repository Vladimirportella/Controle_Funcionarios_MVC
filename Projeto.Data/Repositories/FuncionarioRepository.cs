using Dapper;
using Projeto.Data.Contracts;
using Projeto.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Projeto.Data.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExMVC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public void Alterar(Funcionario obj)
        {
            var query = "update Funcionario set Nome = @Nome, Salario = @Salario, DataAdmissao = @DataAdmissao, IdCargo = @IdCargo, IdDepartamento = @IdDepartamento where IdFuncionario = @IdFuncionario";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public List<Funcionario> Consultar()
        {
            var query = "select * from Funcionario";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Funcionario>(query).ToList();
            }
        }

        public List<Funcionario> ConsultarPorNome(string nome)
        {
            var query = "select * from Funcionario where Nome like @Nome";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Funcionario>(query, new { Nome = "%" + nome + "%" }).ToList();
            }
        }

        public void Excluir(Funcionario obj)
        {
            var query = "delete from Funcionario where IdFuncionario = @IdFuncionario";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public void Inserir(Funcionario obj)
        {
            var query = "insert into Funcionario(Nome, Salario, DataAdmissao, IdCargo, IdDepartamento) values(@Nome, @Salario, @DataAdmissao, @IdCargo, @IdDepartamento)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public Funcionario ObterPorId(int id)
        {
            var query = "select * from Funcionario where IdFuncionario = @IdFuncionario";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Funcionario>(query, new { IdFuncionario = id }).FirstOrDefault();
            }
        }

        public List<Funcionario> ObterPorIdCargo(int id)
        {
            var query = "select * from Funcionario where IdCargo = @IdCargo";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Funcionario>(query, new { IdCargo = id }).ToList();
            }
        }

        public List<Funcionario> ObterPorIdDepartamento(int id)
        {
            var query = "select * from Funcionario where IdDepartamento = @IdDepartamento";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Funcionario>(query, new { IdDepartamento = id }).ToList();
            }
        }
    }
}
