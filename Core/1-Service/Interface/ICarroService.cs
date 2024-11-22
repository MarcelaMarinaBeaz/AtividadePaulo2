using Core.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._1_Service.Interface
{
    public interface ICarroService
    {
        long AdicionarCarro(Carro c);
        List<Carro> ListarCarro();
        void EditarCarro(Carro carro);
        void DeletarCarro(int id);
        Carro BuscarPorId(int id);
    }
}
