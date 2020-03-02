using Projeto.BLL.Contract;
using Projeto.DAL.Contract;
using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.BLL.Business
{
    public class EventoBusiness : IEventoBusiness
    {
        private readonly IEventoRepository repository;

        public EventoBusiness(IEventoRepository repository)
        {
            this.repository = repository;
        }

        public void Cadastrar(Evento obj)
        {
            repository.Insert(obj);
        }

        public void Atualizar(Evento obj)
        {
            repository.Update(obj);
        }

        public void Excluir(Evento obj)
        {
            repository.Delete(obj);
        }

        public List<Evento> ConsultarTodos()
        {
            return repository.SelectAll();
        }

        public Evento ConsultarPorId(int id)
        {
            return repository.SelectById(id);
        }

        public List<Evento> ConsultarPorNome(string nome)
        {
            return repository.SelectByNome(nome);
        }

        public List<Evento> ConsultarPorData(DateTime dataMin, DateTime dataMax)
        {
            return repository.SelectByData(dataMin, dataMax);
        }
    }
}
