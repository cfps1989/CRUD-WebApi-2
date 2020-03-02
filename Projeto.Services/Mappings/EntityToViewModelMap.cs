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
    public class EntityToViewModelMap : Profile
    {
        public EntityToViewModelMap()
        {
            CreateMap<Evento, EventoConsultaViewModel>();
            CreateMap<Participante, ParticipanteConsultaViewModel>();
        }
    }
}