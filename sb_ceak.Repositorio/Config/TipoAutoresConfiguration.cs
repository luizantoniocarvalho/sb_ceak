using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class TipoAutoresConfiguration : IEntityTypeConfiguration<TipoAutores>
    {
        public void Configure(EntityTypeBuilder<TipoAutores> builder)
        {
            //Chave primária.
            builder.HasKey(tp => tp.tipo_autor_id);

            //Builder utiliza o padrão Fluent.
            builder
                .Property(tp => tp.ds_Nome_Tipo_Autor)
                .IsRequired()
                .HasColumnType("character(100)");

            builder
                .Property(tp => tp.in_Situacao_Registro)
                .IsRequired()
                .HasColumnType("boolean");

            builder
                .Property(tp => tp.criou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(tp => tp.dt_Data_Criacao)
                .HasColumnType("timestamp with time zone");

            builder
                .Property(tp => tp.alterou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(tp => tp.dt_Data_Alteracao)
                .HasColumnType("timestamp with time zone");
        }
    }
}
