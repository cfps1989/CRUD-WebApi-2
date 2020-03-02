using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models.Participante
{
    public class ParticipanteConsultaViewModel
    {
        public int IdParticipante { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Atividade { get; set; }
        
        public EventoConsultaViewModel Evento { get; set; }
    }
}