using AutoMapper;
using Projeto.BLL.Contract;
using Projeto.Entities;
using Projeto.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Projeto.Services.Controllers
{
    [RoutePrefix("api/evento")]
    public class EventoController : ApiController
    {
        private readonly IEventoBusiness business;

        public EventoController(IEventoBusiness business)
        {
            this.business = business;
        }

        [HttpPost]
        [Route("cadastrar")]
        public HttpResponseMessage Post(EventoCadastroViewModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var evento = Mapper.Map<Evento>(model);
                    business.Cadastrar(evento);

                    return Request.CreateResponse(HttpStatusCode.OK,
                        $"Evento {evento.Nome}, cadastrado com sucesso.");
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

        [HttpPut]
        [Route("atualizar")]
        public HttpResponseMessage Put(EventoEdicaoViewModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var evento = Mapper.Map<Evento>(model);
                    business.Atualizar(evento);

                    return Request.CreateResponse(HttpStatusCode.OK, $" Evento {evento.Nome}, atualizado com sucesso.");
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
                var evento = business.ConsultarPorId(id);
                business.Excluir(evento);

                return Request.CreateResponse(HttpStatusCode.OK, $" Evento {evento.Nome}, excluído com sucesso.");
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("ConsultarTodos")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var eventos = business.ConsultarTodos();
                var model = Mapper.Map<List<EventoConsultaViewModel>>(eventos);

                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("Consultarpornome")]
        public HttpResponseMessage GetByNome(string nome)
        {
            try
            {
                var eventos = business.ConsultarPorNome(nome);
                var model = Mapper.Map<List<EventoConsultaViewModel>>(eventos);

                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("Consultarpordatas")]
        public HttpResponseMessage GetByDatas(DateTime dataMin, DateTime dataMax)
        {
            try
            {
                var eventos = business.ConsultarPorData(dataMin, dataMax);
                var model = Mapper.Map<List<EventoConsultaViewModel>>(eventos);

                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("Consultarporid")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var eventos = business.ConsultarPorId(id);
                var model = Mapper.Map<List<EventoConsultaViewModel>>(eventos);

                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }   
}
