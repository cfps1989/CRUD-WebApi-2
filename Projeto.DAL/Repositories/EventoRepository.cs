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
    public class EventoRepository : BaseRepository<Evento>, IEventoRepository
    {
        public List<Evento> SelectByNome(string nome)
        {
            using(var context = new DataContext())
            {
                return context.Evento
                    .Where(e => e.Nome.Contains(nome))
                    .OrderBy(e => e.Nome)
                    .ToList();
            }
        }

        public List<Evento> SelectByData(DateTime dataMin, DateTime dataMax)
        {
            using (var context = new DataContext())
            {
                return context.Evento
                .Where(e => e.DataHora >= dataMin && e.DataHora <= dataMax)
                .OrderByDescending(e => e.DataHora)
                .ToList();
            }
        }      
    }
}
