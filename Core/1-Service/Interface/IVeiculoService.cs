using Core._3_Entidade.DTOs;
using Core.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._1_Service.Interface
{
    public interface IVeiculoService
    {
        long AdicionarVeiculo(Veiculo veiculo);

        List<Veiculo> ListarVeiculo();

        void EditarVeiculo(Veiculo veiculo);

        void DeletarVeiculo(int id);
        Veiculo BuscarPorId(int id);
    }
}
