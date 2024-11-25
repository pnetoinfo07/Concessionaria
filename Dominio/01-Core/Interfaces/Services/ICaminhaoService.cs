using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio._01_Core.Interfaces.Services
{
    public interface ICaminhaoService
    {
        void Adicionar(Caminhao carro);
        void Remover(int id);
        void Editar(Caminhao carro);
        List<Caminhao> Listar();
        Caminhao BuscarPorId(int id);
    }
}
