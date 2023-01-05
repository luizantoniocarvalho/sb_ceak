using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class TelefonesConfiguration : IEntityTypeConfiguration<Telefones>
    {
        public void Configure(EntityTypeBuilder<Telefones> builder)
        {
            //Chave primária.
            builder.HasKey(t => t.telefone_id);

            //Builder utiliza o padrão Fluent.
            builder
                .Property(t => t.tipo_telefone_id)
                .IsRequired()
                .HasColumnType("integer");

            builder
                .Property(t => t.ds_DDD_Telefone)
                .IsRequired()
                .HasColumnType("character(10)");

            builder
                .Property(t => t.ds_Numero_Telefone)
                .IsRequired()
                .HasColumnType("character(10)");

            builder
                .Property(t => t.in_Situacao_Registro)
                .IsRequired()
                .HasColumnType("boolean");

            builder
                .Property(t => t.criou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(t => t.dt_Data_Criacao)
                .HasColumnType("timestamp with time zone");

            builder
                .Property(t => t.alterou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(t => t.dt_Data_Alteracao)
                .HasColumnType("timestamp with time zone");

            //builder.Property(a => a.Pessoas)
        }
    }
}
