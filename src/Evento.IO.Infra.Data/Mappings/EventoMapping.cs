using Eventos.IO.Domain.EventoRoot;
using Eventos.IO.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventos.IO.Infra.Data.Mappings
{
    public class EventoMapping : EntityTypeConfiguration<Evento>
    {
        public override void Map(EntityTypeBuilder<Evento> builder)
        {
            builder.Property(e => e.Titulo)
               .HasColumnType("varchar(150)")
               .IsRequired();

            builder.Property(e => e.DataInicio)
                .HasColumnType("Date");

            builder.Property(e => e.HoraInicio)
                .HasColumnType("time");

            builder.Property(e => e.Descricao)
                .HasColumnType("varchar(max)");

            builder.Ignore(e => e.ValidationResult);

            builder.Ignore(e => e.Tags);

            builder.Ignore(e => e.CascadeMode);

            builder.ToTable("Eventos");

            builder.HasOne(e => e.Categoria)
                .WithMany(o => o.Eventos)
                .HasForeignKey(e => e.CategoriaId)
                .IsRequired(true);

            
        }
    }
}