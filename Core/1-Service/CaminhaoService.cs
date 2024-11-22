using Core._1_Service.Interface;
using Core._2_Repository.Interface;
using Core._3_Entidade.DTOs;
using Core.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._1_Service
{
    public class CaminhaoService : ICaminhaoService
    {
        private readonly IVeiculoService _service;
        private readonly ICaminhaoRepository _repositorio;

        public CaminhaoService(IVeiculoService service, ICaminhaoRepository repository)
        {
            _service = service;
            _repositorio = repository;
        }

        public long AdicionarCaminhao(Caminhao c)
        {
            Caminhao caminhao = new Caminhao()
            {
                Tipo = c.Tipo,
                Modelo = c.Modelo,
                Ano = c.Ano,
                CapacidadeTanque = c.CapacidadeTanque,
                ConsumoPorKm = c.ConsumoPorKm,
                DistanciaPercorrida = c.DistanciaPercorrida,
                ConsumoEstimado = c.ConsumoEstimado
            };
            long IdVeiculo = _service.AdicionarVeiculo(caminhao);
            CreateCaminhaoDTO dto = new CreateCaminhaoDTO()
            {
                AutomovelId = (int)IdVeiculo,
                carro = c.carro,
            };
            return _repositorio.AdicionarCaminhao(dto);
        }
        public List<Caminhao> ListarCaminhao()
        {
            return _repositorio.ListarCaminhao();
        }

        public void EditarCaminhao(Caminhao caminhao)
        {
            _repositorio.EditarCaminhao(caminhao);
        }

        public void DeletarCaminhao(int id)
        {
            _repositorio.DeletarCaminhao(id);
        }
        public Caminhao BuscarPorId(int id)
        {
            return _repositorio.BuscarPorId(id);
        }
    }
}
