using Dominio.Interfaces;

namespace Dominio.Entidades
{
    public abstract class Veiculo : IVeiculo
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double CapacidadeTanque { get; set; }
        public double ConsumoPorKm { get; set; }
        public virtual string ExibirDetalhes()
        {
            string mensagemExibirDetalhes = $"Modelo: {Modelo}" +
                $"\nAno: {Ano}" +
                $"\nCapacidade do Tanque: {CapacidadeTanque} litros" +
                $"\nConsumo por Km: {ConsumoPorKm} km/l";

            return mensagemExibirDetalhes;
        }

        public virtual double CalcularConsumo(double distancia)
        {
            return distancia / ConsumoPorKm;
        }
    }

}
