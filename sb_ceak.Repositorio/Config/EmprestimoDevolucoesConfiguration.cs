using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class EmprestimoDevolucoesConfiguration : IEntityTypeConfiguration<EmprestimoDevolucoes>
    {
        public void Configure(EntityTypeBuilder<EmprestimoDevolucoes> builder)
        {
            //Chave primária.
            builder.HasKey(ed => ed.emp_dev_id);

            //Builder utiliza o padrão Fluent.
            builder
                .Property(ed => ed.tipo_obra_id)
                .IsRequired()
                .HasColumnType("integer");

            builder
                .Property(ed => ed.pessoa_id)
                .IsRequired()
                .HasColumnType("integer");

            builder
                .Property(ed => ed.obra_id)
                .IsRequired()
                .HasColumnType("integer");

            builder
                .Property(ed => ed.dt_Data_Emprestimo)
                .HasColumnType("timestamp with time zone");

            builder
                .Property(ed => ed.dt_Prevista_Devolucao)
                .HasColumnType("timestamp with time zone");

            builder
                .Property(ed => ed.dt_Data_Devolucao)
                .HasColumnType("timestamp with time zone");

            //builder.Property(a => a.Pessoas)
        }
    }
}
