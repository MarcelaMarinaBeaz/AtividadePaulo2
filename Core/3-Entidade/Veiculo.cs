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
        public int id;
        public string Tipo;
        public string Modelo;
        public int Ano;
        public int CapacidadeTanque;
        public int ConsumoPorKm;
        public int DistanciaPercorrida;
        public int ConsumoEstimado;
        public int AutomovelId;

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
