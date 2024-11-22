using Core._1_Service.Interface;
using Core._2_Repository.Interface;
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
    public class CarroService : ICarroService
    {
        private readonly IVeiculoService _service;
        private readonly ICarroRepositoey _repositorio;

        public CarroService(IVeiculoService service, ICarroRepositoey repository)
        {
            _service = service;
            _repositorio = repository;
        }

        public long AdicionarCarro(Carro c)
        {
            Veiculo veiculo = new Veiculo()
            {             
                Tipo = c.Tipo,
                Modelo =c.Modelo,
                Ano = c.Ano,
                CapacidadeTanque= c.CapacidadeTanque,
                ConsumoPorKm= c.ConsumoPorKm,
                DistanciaPercorrida= c.DistanciaPercorrida,
                ConsumoEstimado= c.ConsumoEstimado
            };
            long IdVeiculo = _service.AdicionarVeiculo(veiculo);
            CreateCarroDTO dto = new CreateCarroDTO()
            {
                AutomovelId = (int)IdVeiculo,
                Tipo = c.Tipo,
            };
           return _repositorio.AdicionarCarro(dto);
        }
        public List<Carro> ListarCarro()
        {
            return _repositorio.ListarCarro();
        }

        public void EditarCarro(Carro carro)
        {
            _repositorio.EditarCarro(carro);
        }

        public void DeletarCarro(int id)
        {
            _repositorio.DeletarCarro(id);
        }
        public Carro BuscarPorId(int id)
        {
            return _repositorio.BuscarPorId(id);
        }
    }
}
