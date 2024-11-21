using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._3_Entidade.DTOs
{
    public class VeiculoDTO
    {
        public string Tipo { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int CapacidadeTanque { get; set; }
        public int ConsumoPorKm { get; set; }
        public int DistanciaPercorrida { get; set; }
        public int ConsumoEstimado { get; set; }
    }
}
