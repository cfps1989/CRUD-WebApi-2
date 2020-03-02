using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Participante
    {
        public int IdParticipante { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Atividade { get; set; }
        public int IdEvento { get; set; }

        public Evento Evento { get; set; }
    }
}
