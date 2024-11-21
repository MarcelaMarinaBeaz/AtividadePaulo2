using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public class InicializadorBd
    {
        private const string ConnectionString = "Data Source=Automoveis.db";

        public static void Inicializar()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string commandoSQL = @"   
                 CREATE TABLE IF NOT EXISTS Veiculos(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Tipo TEXT NOT NULL,
                 Modelo REAL NOT NULL,
                 Ano INTEGER NOT NULL,
                 CapacidadeTanque INTEGER NOT NULL,
                 ConsumoPorKm INTEGER NOT NULL,
                 DistanciaPercorrida INTEGER NOT NULL,
                 ConsumoEstimado INTEGER NOT NULL,
                 AutomovelId INTERGE 
                );";

                commandoSQL += @"
                 CREATE TABLE IF NOT EXISTS Carros(
                 Id  INTEGER PRIMARY KEY AUTOINCREMENT,
                 Tipo TEXT NOT NULL,
                 AutomovelId INTERGE NOT NULL
                  );";

                commandoSQL += @"
                 CREATE TABLE IF NOT EXISTS Caminhoes(
                 Id  INTEGER PRIMARY KEY AUTOINCREMENT,
                 carro Real NOT NULL,
                  AutomovelId INTERGE NOT NULL
                  );";

                connection.Execute(commandoSQL);
            }
        }
    }
}

