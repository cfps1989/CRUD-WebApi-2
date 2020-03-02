using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DAL.Configurations
{
    public class EventoConfiguration : EntityTypeConfiguration<Evento>
    {
        public EventoConfiguration()
        {
            ToTable("Evento");

            HasKey(e => e.IdEvento);

            Property(e => e.IdEvento)
                .HasColumnName("IdEvento");

            Property(e => e.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(150)
                .IsRequired();

            Property(e => e.DataHora)
                .HasColumnName("DataHora")
                .IsRequired();
        }
    }
}
