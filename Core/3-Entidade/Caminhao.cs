using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entidade
{
    public class Caminhao : Veiculo
    {
        public double carro { get; set; }
        public int AutomovelId { get; set; }    

        public override string ExibirDetalhes()
        {
            Console.WriteLine("------------------------Caminhao----------------------------");
            string msgCaminhao = base.ExibirDetalhes();
            msgCaminhao += $"Tipo: {carro}";
            return msgCaminhao;
         
        }
        public override double CalcularConsumo(double distancia)
        {
            double gasto = base.CalcularConsumo(distancia);
            if (carro > 10)
            {
                gasto *= 0.10;
            }
            return gasto;
        }
    }
}
