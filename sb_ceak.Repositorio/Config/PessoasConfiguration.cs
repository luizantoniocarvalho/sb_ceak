using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class PessoasConfiguration : IEntityTypeConfiguration<Pessoas>
    {
        public void Configure(EntityTypeBuilder<Pessoas> builder)
        {
            //Chave primária.
            builder.HasKey(ps => ps.pessoa_id);

            //Builder utiliza o padrão Fluent.
            builder
                .Property(ps => ps.perfil_id)
                .IsRequired()
                .HasColumnType("integer");

            builder
                .Property(ps => ps.telefone_id)
                .IsRequired()
                .HasColumnType("integer");

            builder
                .Property(ps => ps.ds_Nome_Pessoa)
                .IsRequired()
                .HasColumnType("character(200)");

            builder
                .Property(ps => ps.ds_Endereco_Pessoa)
                .IsRequired()
                .HasColumnType("character(200)");

            builder
                .Property(ps => ps.ds_CEP_Pessoa)
                .IsRequired()
                .HasColumnType("character(10)");

            builder
                .Property(ps => ps.uf_id)
                .IsRequired()
                .HasColumnType("integer");

            builder
                .Property(ps => ps.ds_Email_Pessoa)
                .IsRequired()
                .HasColumnType("character(200)");

            builder
                .Property(ps => ps.ds_Senha_Pessoa)
                .IsRequired()
                .HasColumnType("character(10)");

            builder
                .Property(ps => ps.dt_Data_Cadastro_Pessoa)
                .IsRequired()
                .HasColumnType("timestamp with time zone");

            builder
                .Property(ps => ps.in_Situacao_Registro)
                .IsRequired()
                .HasColumnType("boolean");

            builder
                .Property(ps => ps.criou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(ps => ps.dt_Data_Criacao)
                .HasColumnType("timestamp with time zone");

            builder
                .Property(ps => ps.alterou_Registro_id)
                .HasColumnType("integer");

            builder
                .Property(ps => ps.dt_Data_Alteracao)
                .HasColumnType("timestamp with time zone");

            //builder.Property(a => a.Pessoas)
        }
    }
}
