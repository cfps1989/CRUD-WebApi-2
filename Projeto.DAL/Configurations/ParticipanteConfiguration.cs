using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DAL.Configurations
{
    public class ParticipanteConfiguration : EntityTypeConfiguration<Participante>
    {
        public ParticipanteConfiguration()
        {
            ToTable("Participante");

            HasKey(p => p.IdParticipante);

            Property(p => p.IdParticipante)
                .HasColumnName("IdParticpante");

            Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(150)
                .IsRequired();

            Property(p => p.Email)
                .HasColumnName("Email")
                .HasMaxLength(150)
                .IsRequired();

            Property(p => p.Atividade)
                .HasColumnName("Atividade")
                .HasMaxLength(150)
                .IsRequired();

            Property(p => p.IdEvento)
                .HasColumnName("IdEvento")
                .IsRequired();

            HasRequired(p => p.Evento)
                .WithMany(e => e.Participantes)
                .HasForeignKey(p => p.IdEvento)
                .WillCascadeOnDelete(true);
        }
    }
}
