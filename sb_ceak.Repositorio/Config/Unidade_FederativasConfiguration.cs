using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class Unidade_FederativasConfiguration : IEntityTypeConfiguration<Unidade_Federativas>
    {
        public void Configure(EntityTypeBuilder<Unidade_Federativas> builder)
        {
            //Chave primária.
            builder.HasKey(uf => uf.uf_id);

            //Builder utiliza o padrão Fluent.
            builder
                .Property(uf => uf.ds_Nome_UF)
                .IsRequired()
                .HasColumnType("character(100)");

            builder
                .Property(uf => uf.ds_Sigla_UF)
                .IsRequired()
                .HasColumnType("character(2)");

            builder
                .Property(uf => uf.in_Situacao_Registro)
                .IsRequired()
                .HasColumnType("boolean");

            builder
                .Property(uf => uf.criou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(uf => uf.dt_Data_Criacao)
                .HasColumnType("timestamp with time zone");

            builder
                .Property(uf => uf.alterou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(uf => uf.dt_Data_Alteracao)
                .HasColumnType("timestamp with time zone");

            //builder.Property(a => a.Pessoas)
        }
    }
}
