using Core._1_Service.Interface;
using Core._2_Repository.Interface;
using Core._3_Entidade.DTOs;
using Core.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._1_Service
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepository _repository;

        public VeiculoService(IVeiculoRepository repository)
        {
            _repository = repository;   
        }

        public long AdicionarVeiculo(Veiculo veiculo)
        {
            return _repository.AdicionarVeiculo(veiculo);
        }

        public List<Veiculo> ListarVeiculo()
        {
          return _repository.ListarVeiculo();
        }

        public void EditarVeiculo(Veiculo veiculo)
        {
            _repository.EditarVeiculo(veiculo);
        }

        public void DeletarVeiculo(int id)
        {
          _repository.DeletarVeiculo(id);
        }
        public Veiculo BuscarPorId(int id)
        {
          return _repository.BuscarPorId(id);
        }
    }
}
