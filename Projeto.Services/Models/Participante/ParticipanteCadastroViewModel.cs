using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models.Participante
{
    public class ParticipanteCadastroViewModel
    {
        [Required(ErrorMessage = "Nome obrigatório")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Email obrigatório")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Atividade obrigatório")]
        public string Atividade { get; set; }
        
        [Required(ErrorMessage = "Id do Evento obrigatório")]
        public int IdEvento { get; set; }
    }
}