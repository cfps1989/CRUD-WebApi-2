using Projeto.BLL.Business;
using Projeto.BLL.Contract;
using Projeto.DAL.Contract;
using Projeto.DAL.Repositories;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Projeto.Services.Mappings;
using AutoMapper;

namespace Projeto.Services
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            SimpleInjectorConfig();
            AutoMapperConfig();
        }

        private void SimpleInjectorConfig()
        {

            var container = new Container();
            container.Options.DefaultScopedLifestyle
            = new AsyncScopedLifestyle();

            container.Register<IEventoRepository, EventoRepository>(Lifestyle.Scoped);
            container.Register<IParticipanteRepository, ParticipanteRepository>(Lifestyle.Scoped);

            container.Register<IEventoBusiness, EventoBusiness>(Lifestyle.Scoped);
            container.Register<IParticipanteBusiness, ParticipanteBusiness>(Lifestyle.Scoped);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
            new SimpleInjectorWebApiDependencyResolver(container);
        }

        private void AutoMapperConfig()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<EntityToViewModelMap>();
                cfg.AddProfile<ViewModelToEntityMap>();
            });
        }
    }
}
