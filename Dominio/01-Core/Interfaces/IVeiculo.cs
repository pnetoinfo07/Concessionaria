namespace Dominio.Interfaces
{
    public interface IVeiculo
    {
        string ExibirDetalhes();
        double CalcularConsumo(double distancia);
    }

}
