using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.BLL.Contract
{
    public interface IEventoBusiness : IBaseBusiness<Evento>
    {
        List<Evento> ConsultarPorNome(string nome);
        List<Evento> ConsultarPorData(DateTime dataMin, DateTime dataMax);
    }
}
