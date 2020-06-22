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
    
    public class CargoRepository : ICargoRepository
    {
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExMVC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public void Alterar(Cargo obj)
        {
            var query = "update Cargo set Nome = @Nome, Descricao = @Descricao where IdCargo = @IdCargo";

            using(var connection = new SqlConnection(connectionString)) 
            {
                connection.Execute(query, obj);
            }
        }

        public List<Cargo> Consultar()
        {
            var query = "select * from Cargo";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Cargo>(query).ToList();
            }
        }

        public void Excluir(Cargo obj)
        {
            var query = "delete from Cargo where IdCargo = @IdCargo";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public void Inserir(Cargo obj)
        {
            var query = "insert into Cargo(Nome, Descricao) values(@Nome, @Descricao)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, obj);
            }
        }

        public Cargo ObterPorId(int id)
        {
            var query = "select * from Cargo where IdCargo = @IdCargo";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Cargo>(query, new { IdCargo = id }).FirstOrDefault();
            }
        }
    }
}
