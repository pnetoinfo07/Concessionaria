using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio._01_Core.Interfaces.Repository
{
    public interface ICarroRespository
    {
        void Adicionar(Carro carro);
        void Remover(int id);
        void Editar(Carro carro);
        List<Carro> Listar();
        Carro BuscarPorId(int id);
    }
}
