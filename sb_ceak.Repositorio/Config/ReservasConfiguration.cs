using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class ReservasConfiguration : IEntityTypeConfiguration<Reservas>
    {
        public void Configure(EntityTypeBuilder<Reservas> builder)
        {
            //Chave primária.
            builder.HasKey(r => r.reserva_id);

            //Builder utiliza o padrão Fluent.
            builder
                .Property(r => r.pessoa_id)
                .IsRequired()
                .HasColumnType("integer");

            builder
                .Property(r => r.obra_id)
                .IsRequired()
                .HasColumnType("integer");

            builder
                .Property(r => r.dt_Data_Reserva)
                .IsRequired()
                .HasColumnType("timestamp with time zone");

            //builder.Property(a => a.Pessoas)
        }
    }
}
