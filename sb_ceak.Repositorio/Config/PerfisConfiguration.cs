using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class PerfisConfiguration : IEntityTypeConfiguration<Perfis>
    {
        public void Configure(EntityTypeBuilder<Perfis> builder)
        {
            //Chave primária.
            builder.HasKey(pf => pf.perfil_id);

            //Builder utiliza o padrão Fluent.
            builder
                .Property(pf => pf.ds_Nome_Perfil)
                .IsRequired()
                .HasColumnType("character")
                .HasMaxLength(100);

            builder
                .Property(pf => pf.in_Situacao_Registro)
                .IsRequired()
                .HasColumnType("boolean");

            builder
                .Property(pf => pf.criou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(pf => pf.dt_Data_Criacao)
                .HasColumnType("timestamp with time zone");

            builder
                .Property(pf => pf.alterou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(pf => pf.dt_Data_Alteracao)
                .HasColumnType("timestamp with time zone");

            //builder.Property(a => a.Pessoas)
        }
    }
}
