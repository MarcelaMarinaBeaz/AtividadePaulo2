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
    public class CaminhaoRepository : ICaminhaoRepository
    {
        private readonly string ConnectionString;

        public CaminhaoRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public long AdicionarCaminhao(CreateCaminhaoDTO caminhao)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Insert<CreateCaminhaoDTO>(caminhao);
        }

        public List<Caminhao> ListarCaminhao()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Caminhao>().ToList();
        }

        public void EditarCaminhao(Caminhao caminhao)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Caminhao>(caminhao);
        }

        public void DeletarCaminhao(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Caminhao caminhao = BuscarPorId(id);
            connection.Delete<Caminhao>(caminhao);
        }
        public Caminhao BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Caminhao>(id);
        }
    }
}
