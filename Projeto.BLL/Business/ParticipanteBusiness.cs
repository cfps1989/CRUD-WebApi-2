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
    public class ParticipanteBusiness : IParticipanteBusiness
    {
        public readonly IParticipanteRepository repository;

        public ParticipanteBusiness(IParticipanteRepository repository)
        {
            this.repository = repository;
        }

        public void Cadastrar(Participante obj)
        {
            var participante = repository.SelectByEmail(obj.Email);
            if (participante == null)
            {
                repository.Insert(obj);
            }
            else
            {
                throw new Exception($"Erro: O e-mail {obj.Email} já encontra-se cadastrado.");
            }
        }

        public void Atualizar(Participante obj)
        {
            repository.Update(obj);
        }

        public void Excluir(Participante obj)
        {
            repository.Delete(obj);
        }      

        public List<Participante> ConsultarTodos()
        {
            return repository.SelectAll();
        }

        public Participante ConsultarPorId(int id)
        {
            return repository.SelectById(id);
        }
    }
}
