using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DAL.Contract
{
    public interface IEventoRepository : IBaseRepository<Evento>
    {
        List<Evento> SelectByNome(string nome);
        List<Evento> SelectByData(DateTime dataMin, DateTime dataMax);
    }
}
