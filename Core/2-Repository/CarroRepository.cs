using Atividade_Veiculo.Interface;
using Core._2_Repository.Interface;
using Core._3_Entidade.DTOs;
using Core.Entidade;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public class CarroRepository : ICarroRepositoey
    {
        private readonly string ConnectionString;

        public CarroRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public long AdicionarCarro(CreateCarroDTO carro)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Insert<CreateCarroDTO>(carro);
        }

        public List<Carro> ListarCarro()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Carro>().ToList();
        }

        public void EditarCarro(Carro carro)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Carro>(carro);
        }

        public void DeletarCarro(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Carro carro = BuscarPorId(id);
            connection.Delete<Carro>(carro);
        }
        public Carro BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Carro>(id);
        }
    }
}
