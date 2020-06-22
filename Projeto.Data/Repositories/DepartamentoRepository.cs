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
    public class DepartamentoRepository : IDepartamentoRepository
    {
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExMVC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public void Alterar(Departamento obj)
        {
            var query = "update Departamento set Nome = @Nome, Descricao = @Descricao where IdDepartamento = @IdDepartamento";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public List<Departamento> Consultar()
        {
            var query = "select * from Departamento";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Departamento>(query).ToList();
            }
        }

        public void Excluir(Departamento obj)
        {
            var query = "delete from Departamento where IdDepartamento = @IdDepartamento";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public void Inserir(Departamento obj)
        {
            var query = "insert into Departamento(Nome, Descricao) values(@Nome, @Descricao)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public Departamento ObterPorId(int id)
        {
            var query = "select * from Departamento where IdDepartamento = @IdDepartamento";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Departamento>(query, new { IdDepartamento = id }).FirstOrDefault();
            }
        }
    }
}
