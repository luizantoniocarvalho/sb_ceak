using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class FuncoesConfiguration : IEntityTypeConfiguration<Funcoes>
    {
        public void Configure(EntityTypeBuilder<Funcoes> builder)
        {
            //Chave primária.
            builder.HasKey(f => f.funcao_id);

            //Builder utiliza o padrão Fluent.
            builder
                .Property(f => f.ds_Nome_Funcao)
                .IsRequired()
                .HasColumnType("character")
                .HasMaxLength(100);

            builder
                .Property(f => f.in_Situacao_Registro)
                .IsRequired()
                .HasColumnType("boolean");

            builder
                .Property(f => f.criou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(f => f.dt_Data_Criacao)
                .HasColumnType("timestamp with time zone");

            builder
                .Property(f => f.alterou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(f => f.dt_Data_Alteracao)
                .HasColumnType("timestamp with time zone");

            //builder.Property(a => a.Pessoas)
        }
    }
}
