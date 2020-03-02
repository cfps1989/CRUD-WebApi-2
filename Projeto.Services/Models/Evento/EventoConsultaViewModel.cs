using Projeto.Services.Models.Participante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models
{
    public class EventoConsultaViewModel
    {
        public int IdEvento { get; set; }
        public string Nome { get; set; }
        public DateTime DataHora { get; set; }
        
        public List<ParticipanteConsultaViewModel> Participantes { get; set; }
    }
}