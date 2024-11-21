using Core._1_Service.Interface;
using Core._3_Entidade.DTOs;
using Core.Entidade;
using Core.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._1_Service
{
    public class CarroService
    {
        private readonly IVeiculoService _service;
        private readonly CarroRepository repositorio;

        public CarroService(IVeiculoService service, IConfiguration config)
        {
            _service = service;
            repositorio = new CarroRepository(config);
        }

        public void AdicionarCarro(Carro c)
        {
            Veiculo veiculo = new Veiculo()
            {
                Ano = c.Ano,
                Tipo = c.Tipo,
                Modelo =c.Modelo
            };
            long IdVeiculo = _service.AdicionarVeiculo(veiculo);
            CreateCarroDTO dto = new CreateCarroDTO()
            {
                AutomovelId = (int)IdVeiculo,
                Tipo = c.Tipo,
            };
            repositorio.AdicionarVeiculo(dto);

        }
    }
}
