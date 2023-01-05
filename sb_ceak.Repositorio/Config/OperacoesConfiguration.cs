using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class OperacoesConfiguration : IEntityTypeConfiguration<Operacoes>
    {
        public void Configure(EntityTypeBuilder<Operacoes> builder)
        {
            //Chave primária.
            builder.HasKey(op => op.operacao_id);

            //Builder utiliza o padrão Fluent.
            builder
                .Property(op => op.ds_Nome_Operacao)
                .IsRequired()
                .HasColumnType("character(100)");

            builder
                .Property(op => op.in_Situacao_Registro)
                .IsRequired()
                .HasColumnType("boolean");

            builder
                .Property(op => op.criou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(op => op.dt_Data_Criacao)
                .HasColumnType("timestamp with time zone");

            builder
                .Property(op => op.alterou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(op => op.dt_Data_Alteracao)
                .HasColumnType("timestamp with time zone");

            //builder.Property(a => a.Pessoas)
        }
    }
}
