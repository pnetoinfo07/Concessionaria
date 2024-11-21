
namespace Core.Repository
{
    public interface IVeiculoRepository
    {
        void ExibirDetalhes();
        double CalcularConsumo(double distancia);
    }
}
