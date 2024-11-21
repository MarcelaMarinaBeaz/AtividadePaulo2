using Atividade_Veiculo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entidade
{
    public class Veiculo : IVeiculo
    {
        public int id { get; set; }
        public string Tipo { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int CapacidadeTanque { get; set; }
        public int ConsumoPorKm { get; set; }
        public int DistanciaPercorrida { get; set; }
        public int ConsumoEstimado { get; set; }
        public int AutomovelId { get; set; }

        public virtual string ExibirDetalhes()
        {
           string msg =($"Tipo: {Tipo}+" +
                $"\nModelo: {Modelo}" +
                $"\nAno: {Ano}" +
                $"\nCapacidade do Tanque: {CapacidadeTanque}" +
                $"\nConsumo Por Km: {ConsumoPorKm}" +
                $"\nDistancia Percorrida: {DistanciaPercorrida}" +
                $"\nConsumo Estimado: {ConsumoEstimado}");
            return msg;
        }
        public virtual double CalcularConsumo(double distancia)
        {
            return distancia / ConsumoPorKm;

        }
    }
}
