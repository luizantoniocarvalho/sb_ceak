using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class TipoTelefonesConfiguration : IEntityTypeConfiguration<TipoTelefones>
    {
        public void Configure(EntityTypeBuilder<TipoTelefones> builder)
        {
            //Chave primária.
            builder.HasKey(tt => tt.tipo_telefone_id);

            //Builder utiliza o padrão Fluent.
            builder
                .Property(tt => tt.ds_Tipo_Telefone)
                .IsRequired()
                .HasColumnType("character(30)");

            builder
                .Property(tt => tt.in_Situacao_Registro)
                .IsRequired()
                .HasColumnType("boolean");

            builder
                .Property(tt => tt.criou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(tt => tt.dt_Data_Criacao)
                .HasColumnType("timestamp with time zone");

            builder
                .Property(tt => tt.alterou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(tt => tt.dt_Data_Alteracao)
                .HasColumnType("timestamp with time zone");

            //builder.Property(a => a.Pessoas)
        }
    }
}
