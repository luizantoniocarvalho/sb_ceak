using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class AutoresConfiguration : IEntityTypeConfiguration<Autores>
    {
        public void Configure(EntityTypeBuilder<Autores> builder)
        {
            //Chave primária.
            builder.HasKey(a => a.autor_id);

            //Builder utiliza o padrão Fluent.
            builder
                .Property(a => a.ds_Nome_Autor)
                .IsRequired()
                .HasColumnType("character")
                .HasMaxLength(200);

            builder
                .Property(a => a.tipo_autor_id)
                .IsRequired()
                .HasColumnType("integer");

            builder
                .Property(a => a.in_Situacao_Registro)
                .IsRequired()
                .HasColumnType("boolean");

            builder
                .Property(a => a.criou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(a => a.dt_Data_Criacao)
                .HasColumnType("timestamp with time zone");

            builder
                .Property(a => a.alterou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(a => a.dt_Data_Alteracao)
                .HasColumnType("timestamp with time zone");

            //builder.Property(a => a.Pessoas)
                
        }
    }
}
