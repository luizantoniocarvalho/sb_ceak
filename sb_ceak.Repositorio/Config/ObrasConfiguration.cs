using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class ObrasConfiguration : IEntityTypeConfiguration<Obras>
    {
        public void Configure(EntityTypeBuilder<Obras> builder)
        {
            //Chave primária.
            builder.HasKey(o => o.obra_id);

            //Builder utiliza o padrão Fluent.
            builder
                .Property(o => o.tipo_obra_id)
                .IsRequired()
                .HasColumnType("integer");

            builder
                .Property(o => o.autor_id)
                .IsRequired()
                .HasColumnType("integer");

            builder
                .Property(o => o.prazo_id)
                .IsRequired()
                .HasColumnType("integer");

            builder
                .Property(o => o.ds_Nome_Obra)
                .IsRequired()
                .HasColumnType("character")
                .HasMaxLength(200);

            builder
                .Property(o => o.ds_Codigo_Obra)
                .IsRequired()
                .HasColumnType("character")
                .HasMaxLength(30);

            builder
                .Property(o => o.ds_Divulgadora_Obra)
                .HasColumnType("character")
                .HasMaxLength(30);

            builder
                .Property(o => o.ds_Edicao_Obra)
                .HasColumnType("character")
                .HasMaxLength(30);

            builder
                .Property(o => o.ds_Mes_Ano_Publicacao_Obra)
                .HasColumnType("character")
                .HasMaxLength(30);

            builder
                .Property(o => o.ds_Ano_Publicacao_Obra)
                .HasColumnType("character")
                .HasMaxLength(30);

            builder
                .Property(o => o.ds_Editora_Obra)
                .HasColumnType("character")
                .HasMaxLength(50);

            builder
                .Property(o => o.qtd_Pagina_Obra)
                .HasColumnType("integer");

            builder
                .Property(o => o.ds_CDU_Obra)
                .HasColumnType("character")
                .HasMaxLength(30);

            builder
                .Property(o => o.ds_CDD_Obra)
                .HasColumnType("character")
                .HasMaxLength(30);

            builder
                .Property(o => o.dt_Data_Cadastro_Obra)
                .IsRequired()
                .HasColumnType("timestamp with time zone");

            builder
                .Property(o => o.in_Situacao_Registro)
                .IsRequired()
                .HasColumnType("boolean");

            builder
                .Property(o => o.criou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(o => o.dt_Data_Criacao)
                .HasColumnType("timestamp with time zone");

            builder
                .Property(o => o.alterou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(o => o.dt_Data_Alteracao)
                .HasColumnType("timestamp with time zone");

            //builder.Property(a => a.Pessoas)
        }
    }
}
