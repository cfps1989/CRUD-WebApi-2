using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Evento
    {
        public int IdEvento { get; set; }
        public string Nome { get; set; }
        public DateTime DataHora { get; set; }

        public List<Participante> Participantes { get; set; }
    }
}
