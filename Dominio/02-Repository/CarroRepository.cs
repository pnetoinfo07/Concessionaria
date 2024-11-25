using Dapper.Contrib.Extensions;
using Dominio._01_Core.Interfaces.Repository;
using Dominio.Entidades;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;

namespace Dominio._02_Repository
{
    public class CarroRepository : ICarroRespository
    {
        private readonly string ConnectionString;
        public CarroRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
        public void Adicionar(Carro carro)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Carro>(carro);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Carro carro = BuscarPorId(id);
            connection.Delete<Carro>(carro);
        }
        public void Editar(Carro carro)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Carro>(carro);
        }
        public List<Carro> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Carro>().ToList();
        }
        public Carro BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Carro>(id);
        }
    }
}
