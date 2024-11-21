using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entidade
{
    public class Carro : Veiculo
    {
        public string tipo { get; set; }
        public int AutomovelId { get; set; }

        public override string ExibirDetalhes()
        {
            Console.WriteLine("------------------------Carro----------------------------");
            string msgcarro = base.ExibirDetalhes();
            msgcarro += $"Tipo: {tipo}";
            return msgcarro;          
        }
        public override double CalcularConsumo(double distancia)
        {
            double gasto = base.CalcularConsumo(distancia);
            if (tipo == "Híbrido")
            {
                gasto *= 0.5;
            }
            return gasto;
        }
    }
}
