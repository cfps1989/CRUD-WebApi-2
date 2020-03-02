using Projeto.DAL.Context;
using Projeto.DAL.Contract;
using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DAL.Repositories
{
    public class ParticipanteRepository : BaseRepository<Participante>, IParticipanteRepository
    {
        public Participante SelectByEmail(string email)
        {
            using(var context = new DataContext())
            {
                return context.Participante.SingleOrDefault(p => p.Email.Equals(email));
            }
        }
    }
}
