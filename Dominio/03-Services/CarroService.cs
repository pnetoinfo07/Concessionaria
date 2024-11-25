using Dominio._01_Core.Interfaces.Repository;
using Dominio._01_Core.Interfaces.Services;
using Dominio.Entidades;

namespace Dominio._03_Services;

public class CarroService : ICarroService
{
    private readonly ICarroRespository _repository;
    public CarroService(ICarroRespository repository)
    {
        _repository = repository;
    }
    public void Adicionar(Carro carro)
    {
        _repository.Adicionar(carro);
    }
    public void Remover(int id)
    {
        _repository.Remover(id);
    }
    public void Editar(Carro carro)
    {
        _repository.Editar(carro);
    }
    public List<Carro> Listar()
    {
       return _repository.Listar();
    }
    public Carro BuscarPorId(int id)
    {
        return _repository.BuscarPorId(id);
    }
}
