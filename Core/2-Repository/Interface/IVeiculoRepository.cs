using Core.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._2_Repository.Interface
{
    public interface IVeiculoRepository
    {
        void AdicionarVeiculo(Veiculo veiculo);

        List<Veiculo> ListarVeiculo();

        void EditarVeiculo(Veiculo veiculo);

        void DeletarVeiculo(int id);
        Veiculo BuscarPorId(int id);
    }
}
