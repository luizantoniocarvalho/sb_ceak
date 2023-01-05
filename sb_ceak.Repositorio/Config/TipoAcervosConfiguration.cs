using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class TipoAcervosConfiguration : IEntityTypeConfiguration<TipoAcervos>
    {
        public void Configure(EntityTypeBuilder<TipoAcervos> builder)
        {
            //Chave primária.
            builder.HasKey(ta => ta.tipo_acervo_id);

            //Builder utiliza o padrão Fluent.
            builder
                .Property(ta => ta.ds_Nome_Tipo_Acervo)
                .IsRequired()
                .HasColumnType("character(100)");

            builder
                .Property(ta => ta.ds_Prazo_Dia_Acervo)
                .IsRequired()
                .HasColumnType("character(2)");

            builder
                .Property(ta => ta.in_Situacao_Registro)
                .IsRequired()
                .HasColumnType("boolean");

            builder
                .Property(ta => ta.criou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(ta => ta.dt_Data_Criacao)
                .HasColumnType("timestamp with time zone");

            builder
                .Property(ta => ta.alterou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(ta => ta.dt_Data_Alteracao)
                .HasColumnType("timestamp with time zone");

        }
    }
}
