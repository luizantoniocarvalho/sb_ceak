using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class TipoObrasConfiguration : IEntityTypeConfiguration<TipoObras>
    {
        public void Configure(EntityTypeBuilder<TipoObras> builder)
        {
            //Chave primária.
            builder.HasKey(to => to.tipo_obra_id);

            //Builder utiliza o padrão Fluent.
            builder
                .Property(to => to.ds_Nome_Tipo_Obra)
                .IsRequired()
                .HasColumnType("character(100)");

            builder
                .Property(to => to.in_Situacao_Registro)
                .IsRequired()
                .HasColumnType("boolean");

            builder
                .Property(to => to.criou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(to => to.dt_Data_Criacao)
                .HasColumnType("timestamp with time zone");

            builder
                .Property(to => to.alterou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(to => to.dt_Data_Alteracao)
                .HasColumnType("timestamp with time zone");


            //builder.Property(a => a.Pessoas)
        }
    }
}
