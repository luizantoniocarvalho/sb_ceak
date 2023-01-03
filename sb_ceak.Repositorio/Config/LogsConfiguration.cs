using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class LogsConfiguration : IEntityTypeConfiguration<Logs>
    {
        public void Configure(EntityTypeBuilder<Logs> builder)
        {
            //Chave primária.
            builder.HasKey(l => l.log_id);

            //Builder utiliza o padrão Fluent.
            builder
                .Property(l => l.pessoa_id)
                .IsRequired()
                .HasColumnType("integer");

            builder
                .Property(l => l.dt_Data_Log)
                .IsRequired()
                .HasColumnType("timestamp with time zone");

            builder
                .Property(l => l.ds_Log_Realizado)
                .IsRequired()
                .HasColumnType("character");

            //builder.Property(a => a.Pessoas)
        }
    }
}
