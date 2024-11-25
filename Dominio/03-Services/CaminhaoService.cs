using Dominio._01_Core.Interfaces.Repository;
using Dominio._01_Core.Interfaces.Services;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio._03_Services
{
    public class CaminhaoService : ICaminhaoService
    {
        private readonly ICaminhaoRepository _repository;
        public CaminhaoService(ICaminhaoRepository repository)
        {
            _repository = repository;
        }
        public void Adicionar(Caminhao caminhao)
        {
            _repository.Adicionar(caminhao);
        }
        public void Remover(int id)
        {
            _repository.Remover(id);
        }
        public void Editar(Caminhao caminhao)
        {
            _repository.Editar(caminhao);
        }
        public List<Caminhao> Listar()
        {
            return _repository.Listar();
        }
        public Caminhao BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }
    }
}
