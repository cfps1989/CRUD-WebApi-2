using AutoMapper;
using Projeto.Entities;
using Projeto.Services.Models;
using Projeto.Services.Models.Participante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Services.Mappings
{
    public class ViewModelToEntityMap : Profile
    {
        public ViewModelToEntityMap()
        {
            CreateMap<EventoCadastroViewModel, Evento>();
            CreateMap<EventoEdicaoViewModel, Evento>();

            CreateMap<ParticipanteCadastroViewModel, Participante>();
            CreateMap<ParticipanteEdicaoViewModel, Participante>();
        }  
    }
}