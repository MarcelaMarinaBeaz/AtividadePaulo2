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
        void AdicionarVeiculo(Veiculo veiculo);

        List<Veiculo> ListarVeiculo();

        void EditarVeiculo(Veiculo veiculo);

        void DeletarVeiculo(int id);
        Veiculo BuscarPorId(int id);
    }
}
