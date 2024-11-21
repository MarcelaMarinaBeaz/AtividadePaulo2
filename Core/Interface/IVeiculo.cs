using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Veiculo.Interface
{
    public interface IVeiculo
    {
       string ExibirDetalhes();
       double CalcularConsumo(double distancia);
    }
}
