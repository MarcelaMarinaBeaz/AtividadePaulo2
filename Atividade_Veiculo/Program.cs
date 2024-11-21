using Atividade_Veiculo;
using Atividade_Veiculo.Interface;
using Core.Entidade;

Carro carro = new Carro { Modelo = "fusca", Ano = 1996, CapacidadeTanque = 12 , ConsumoPorKm = 10, Tipo = "Híbrido" };

Caminhao caminhao = new Caminhao { Modelo = "vw 9150", Ano = 2008, CapacidadeTanque = 80, ConsumoPorKm = 10};

List<Veiculo> veiculos = new List<Veiculo>{carro, caminhao};
foreach(Veiculo v in veiculos)
{
    v.ExibirDetalhes();
    double distancia = 200;
    double consumo = v.CalcularConsumo(distancia);
    Console.WriteLine($"Consumo Por Km: {distancia} km" +
                   $"\nConsumo Por Litro: {consumo} litros");
}