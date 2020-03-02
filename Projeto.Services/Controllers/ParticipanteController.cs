using AutoMapper;
using Projeto.BLL.Contract;
using Projeto.Entities;
using Projeto.Services.Models.Participante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Projeto.Services.Controllers
{
    [RoutePrefix("api/participante")]
    public class ParticipanteController : ApiController
    {
        private readonly IParticipanteBusiness business;

        public ParticipanteController(IParticipanteBusiness business)
        {
            this.business = business;
        }

        [HttpPost]
        [Route("cadastrar")]
        public HttpResponseMessage Post(ParticipanteCadastroViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var participante = Mapper.Map<Participante>(model);
                    business.Cadastrar(participante);

                    return Request.CreateResponse(HttpStatusCode.OK, $" Participante {participante.Nome}, cadastrado com sucesso.");
                }
                catch (Exception e)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [HttpPut]
        [Route("atualizar")]
        public HttpResponseMessage Put(ParticipanteEdicaoViewModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var participante = Mapper.Map<Participante>(model);
                    business.Atualizar(participante);

                    return Request.CreateResponse(HttpStatusCode.OK, 
                        $" Participante {participante.Nome}, atualizado com sucesso.");
                }
                catch(Exception e)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [HttpDelete]
        [Route("excluir")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var participante = business.ConsultarPorId(id);
                business.Excluir(participante);

                return Request.CreateResponse(HttpStatusCode.OK, $" Participante {participante.Nome}, excluido com sucesso.");
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("consultatodos")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var participantes = business.ConsultarTodos();
                var model = Mapper.Map<List<ParticipanteConsultaViewModel>>(participantes);

                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("Consultaporid")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var participante = business.ConsultarPorId(id);
                var model = Mapper.Map<ParticipanteConsultaViewModel>(participante);

                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
