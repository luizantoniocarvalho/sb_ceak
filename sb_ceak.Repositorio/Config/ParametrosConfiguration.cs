using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class ParametrosConfiguration : IEntityTypeConfiguration<Parametros>
    {
        public void Configure(EntityTypeBuilder<Parametros> builder)
        {
            //Chave primária.
            builder.HasKey(p => p.parametro_id);

            //Builder utiliza o padrão Fluent.
            builder
                .Property(p => p.telefone_id)
                .IsRequired()
                .HasColumnType("integer");

            builder
                .Property(p => p.ds_Nome_Parametro)
                .IsRequired()
                .HasColumnType("character")
                .HasMaxLength(200);

            builder
                .Property(p => p.ds_CNPJ_Parametro)
                .IsRequired()
                .HasColumnType("character")
                .HasMaxLength(20);

            builder
                .Property(p => p.ds_Endereco_Parametro)
                .IsRequired()
                .HasColumnType("character")
                .HasMaxLength(200);

            builder
                .Property(p => p.ds_CEP_Parametro)
                .IsRequired()
                .HasColumnType("character")
                .HasMaxLength(10);

            builder
                .Property(p => p.uf_id)
                .IsRequired()
                .HasColumnType("integer");

            builder
                .Property(p => p.ds_Site_Parametro)
                .IsRequired()
                .HasColumnType("character")
                .HasMaxLength(200);

            builder
                .Property(p => p.ds_Email_Parametro)
                .IsRequired()
                .HasColumnType("character")
                .HasMaxLength(200);

            builder
                .Property(p => p.ds_Presidente_Parametro)
                .IsRequired()
                .HasColumnType("character")
                .HasMaxLength(100);

            builder
                .Property(p => p.ds_Tesoureiro_Parametro)
                .IsRequired()
                .HasColumnType("character")
                .HasMaxLength(100);

            builder
                .Property(p => p.in_Situacao_Registro)
                .IsRequired()
                .HasColumnType("boolean");

            builder
                .Property(p => p.criou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(p => p.dt_Data_Criacao)
                .HasColumnType("timestamp with time zone");

            builder
                .Property(p => p.alterou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(p => p.dt_Data_Alteracao)
                .HasColumnType("timestamp with time zone");

            //builder.Property(a => a.Pessoas)
        }
    }
}
