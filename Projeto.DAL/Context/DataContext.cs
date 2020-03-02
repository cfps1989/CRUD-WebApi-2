using Projeto.DAL.Configurations;
using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DAL.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base(ConfigurationManager.ConnectionStrings["projeto"].ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EventoConfiguration());
            modelBuilder.Configurations.Add(new ParticipanteConfiguration());
        }

        public DbSet<Evento> Evento { get; set; }
        public DbSet<Participante> Participante { get; set; }
    }
}
