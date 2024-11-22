using Core.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._1_Service.Interface
{
    public interface ICaminhaoService
    {
        long AdicionarCaminhao(Caminhao c);
        List<Caminhao> ListarCaminhao();
        void EditarCaminhao(Caminhao caminhao);
        void DeletarCaminhao(int id);
        Caminhao BuscarPorId(int id);
    }
}
