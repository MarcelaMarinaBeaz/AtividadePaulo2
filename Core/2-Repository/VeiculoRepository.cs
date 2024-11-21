using Atividade_Veiculo.Interface;
using Core._2_Repository.Interface;
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
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly string ConnectionString;
       
        public VeiculoRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Veiculo>(veiculo);
        }

        public List<Veiculo> ListarVeiculo()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Veiculo>().ToList();
        }

        public void EditarVeiculo(Veiculo veiculo)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Veiculo>(veiculo);
        }

        public void DeletarVeiculo(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Veiculo veiculo = BuscarPorId(id);
            connection.Delete<Veiculo>(veiculo);
        }
        public Veiculo BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Veiculo>(id);
        }
    }
}
