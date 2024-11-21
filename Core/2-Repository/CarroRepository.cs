using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public class CarroRepository
    {
        private readonly string ConnectionString;

        public CarroRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void AdicionarVeiculo()
        {

        }

        public void ListarVeiculo()
        {

        }

        public void EditarVeiculo()
        {

        }

        public void DeletarVeiculo()
        {

        }
    }
}
