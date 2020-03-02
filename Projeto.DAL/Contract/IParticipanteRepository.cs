using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DAL.Contract
{
    public interface IParticipanteRepository : IBaseRepository<Participante>
    {
        Participante SelectByEmail(string email);
    }
}
