using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models
{
    public class EventoEdicaoViewModel
    {
        [Required(ErrorMessage = "Id do Evento obrigatório")]
        public int IdEvento { get; set; }

        [Required(ErrorMessage = " Nome obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Data/Hora obrigatório")]
        public DateTime DataHora { get; set; }
    }
}