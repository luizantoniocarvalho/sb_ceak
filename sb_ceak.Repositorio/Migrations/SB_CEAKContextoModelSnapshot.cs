﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using sb_ceak.Repositorio.Contexto;

namespace sb_ceak.Repositorio.Migrations
{
    [DbContext(typeof(SB_CEAKContexto))]
    partial class SB_CEAKContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("sb_ceak.Dominio.Entidade.Autores", b =>
                {
                    b.Property<int>("autor_id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("alterou_Registro_id")
                        .HasColumnType("integer");

                    b.Property<int>("criou_Registro_id")
                        .HasColumnType("integer");

                    b.Property<string>("ds_Nome_Autor")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(200);

                    b.Property<DateTime>("dt_Data_Alteracao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("dt_Data_Criacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("in_Situacao_Registro")
                        .HasColumnType("boolean");

                    b.Property<int>("tipo_autor_id")
                        .HasColumnType("integer");

                    b.HasKey("autor_id");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("sb_ceak.Dominio.Entidade.EmprestimoDevolucoes", b =>
                {
                    b.Property<int>("emp_dev_id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("dt_Data_Devolucao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("dt_Data_Emprestimo")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("dt_Prevista_Devolucao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("obra_id")
                        .HasColumnType("integer");

                    b.Property<int>("pessoa_id")
                        .HasColumnType("integer");

                    b.Property<int>("tipo_obra_id")
                        .HasColumnType("integer");

                    b.HasKey("emp_dev_id");

                    b.ToTable("EmprestimoDevolucao");
                });

            modelBuilder.Entity("sb_ceak.Dominio.Entidade.Funcoes", b =>
                {
                    b.Property<int>("funcao_id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("alterou_Registro_id")
                        .HasColumnType("integer");

                    b.Property<int>("criou_Registro_id")
                        .HasColumnType("integer");

                    b.Property<string>("ds_Nome_Funcao")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(100);

                    b.Property<DateTime>("dt_Data_Alteracao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("dt_Data_Criacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("in_Situacao_Registro")
                        .HasColumnType("boolean");

                    b.Property<int>("perfil_id");

                    b.HasKey("funcao_id");

                    b.HasIndex("perfil_id");

                    b.ToTable("Funcao");
                });

            modelBuilder.Entity("sb_ceak.Dominio.Entidade.Logs", b =>
                {
                    b.Property<int>("log_id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ds_Log_Realizado")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(200);

                    b.Property<DateTime>("dt_Data_Log")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("pessoa_id")
                        .HasColumnType("integer");

                    b.HasKey("log_id");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("sb_ceak.Dominio.Entidade.Obras", b =>
                {
                    b.Property<int>("obra_id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("alterou_Registro_id")
                        .HasColumnType("integer");

                    b.Property<int>("autor_id")
                        .HasColumnType("integer");

                    b.Property<int>("criou_Registro_id")
                        .HasColumnType("integer");

                    b.Property<string>("ds_Ano_Publicacao_Obra")
                        .HasColumnType("character")
                        .HasMaxLength(30);

                    b.Property<string>("ds_CDD_Obra")
                        .HasColumnType("character")
                        .HasMaxLength(30);

                    b.Property<string>("ds_CDU_Obra")
                        .HasColumnType("character")
                        .HasMaxLength(30);

                    b.Property<string>("ds_Codigo_Obra")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(30);

                    b.Property<string>("ds_Divulgadora_Obra")
                        .HasColumnType("character")
                        .HasMaxLength(30);

                    b.Property<string>("ds_Duracao_Obra");

                    b.Property<string>("ds_Edicao_Obra")
                        .HasColumnType("character")
                        .HasMaxLength(30);

                    b.Property<string>("ds_Editora_Obra")
                        .HasColumnType("character")
                        .HasMaxLength(50);

                    b.Property<string>("ds_Mes_Ano_Publicacao_Obra")
                        .HasColumnType("character")
                        .HasMaxLength(30);

                    b.Property<string>("ds_Nome_Obra")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(200);

                    b.Property<DateTime>("dt_Data_Alteracao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("dt_Data_Cadastro_Obra")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("dt_Data_Criacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("in_Situacao_Registro")
                        .HasColumnType("boolean");

                    b.Property<int>("prazo_id")
                        .HasColumnType("integer");

                    b.Property<int>("qtd_Pagina_Obra")
                        .HasColumnType("integer");

                    b.Property<int>("tipo_obra_id")
                        .HasColumnType("integer");

                    b.HasKey("obra_id");

                    b.ToTable("Obra");
                });

            modelBuilder.Entity("sb_ceak.Dominio.Entidade.Operacoes", b =>
                {
                    b.Property<int>("operacao_id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("alterou_Registro_id")
                        .HasColumnType("integer");

                    b.Property<int>("criou_Registro_id")
                        .HasColumnType("integer");

                    b.Property<string>("ds_Nome_Operacao")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(100);

                    b.Property<DateTime>("dt_Data_Alteracao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("dt_Data_Criacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("funcao_id");

                    b.Property<bool>("in_Situacao_Registro")
                        .HasColumnType("boolean");

                    b.HasKey("operacao_id");

                    b.HasIndex("funcao_id");

                    b.ToTable("Operacao");
                });

            modelBuilder.Entity("sb_ceak.Dominio.Entidade.Parametros", b =>
                {
                    b.Property<int>("parametro_id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("alterou_Registro_id")
                        .HasColumnType("integer");

                    b.Property<int>("criou_Registro_id")
                        .HasColumnType("integer");

                    b.Property<string>("ds_CEP_Parametro")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(10);

                    b.Property<string>("ds_CNPJ_Parametro")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(20);

                    b.Property<string>("ds_Email_Parametro")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(200);

                    b.Property<string>("ds_Endereco_Parametro")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(200);

                    b.Property<string>("ds_Nome_Parametro")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(200);

                    b.Property<string>("ds_Presidente_Parametro")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(100);

                    b.Property<string>("ds_Site_Parametro")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(200);

                    b.Property<string>("ds_Tesoureiro_Parametro")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(100);

                    b.Property<DateTime>("dt_Data_Alteracao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("dt_Data_Criacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("in_Situacao_Registro")
                        .HasColumnType("boolean");

                    b.Property<int>("telefone_id")
                        .HasColumnType("integer");

                    b.Property<int>("uf_id")
                        .HasColumnType("integer");

                    b.HasKey("parametro_id");

                    b.ToTable("Parametro");
                });

            modelBuilder.Entity("sb_ceak.Dominio.Entidade.Perfis", b =>
                {
                    b.Property<int>("perfil_id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("alterou_Registro_id")
                        .HasColumnType("integer");

                    b.Property<int>("criou_Registro_id")
                        .HasColumnType("integer");

                    b.Property<string>("ds_Nome_Perfil")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(100);

                    b.Property<DateTime>("dt_Data_Alteracao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("dt_Data_Criacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("in_Situacao_Registro")
                        .HasColumnType("boolean");

                    b.HasKey("perfil_id");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("sb_ceak.Dominio.Entidade.Pessoas", b =>
                {
                    b.Property<int>("pessoa_id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("alterou_Registro_id")
                        .HasColumnType("integer");

                    b.Property<int>("criou_Registro_id")
                        .HasColumnType("integer");

                    b.Property<string>("ds_CEP_Pessoa")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(10);

                    b.Property<string>("ds_Email_Pessoa")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(200);

                    b.Property<string>("ds_Endereco_Pessoa")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(200);

                    b.Property<string>("ds_Nome_Pessoa")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(200);

                    b.Property<string>("ds_Senha_Pessoa")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(10);

                    b.Property<DateTime>("dt_Data_Alteracao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("dt_Data_Cadastro_Pessoa")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("dt_Data_Criacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("in_Situacao_Registro")
                        .HasColumnType("boolean");

                    b.Property<int>("perfil_id")
                        .HasColumnType("integer");

                    b.Property<int>("telefone_id")
                        .HasColumnType("integer");

                    b.Property<int>("uf_id")
                        .HasColumnType("integer");

                    b.HasKey("pessoa_id");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("sb_ceak.Dominio.Entidade.Reservas", b =>
                {
                    b.Property<int>("reserva_id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("dt_Data_Reserva")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("obra_id")
                        .HasColumnType("integer");

                    b.Property<int>("pessoa_id")
                        .HasColumnType("integer");

                    b.HasKey("reserva_id");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("sb_ceak.Dominio.Entidade.Telefones", b =>
                {
                    b.Property<int>("telefone_id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("alterou_Registro_id")
                        .HasColumnType("integer");

                    b.Property<int>("criou_Registro_id")
                        .HasColumnType("integer");

                    b.Property<string>("ds_DDD_Telefone")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(10);

                    b.Property<string>("ds_Numero_Telefone")
                        .IsRequired()
                        .HasColumnType("character")
                        .HasMaxLength(10);

                    b.Property<DateTime>("dt_Data_Alteracao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("dt_Data_Criacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("in_Situacao_Registro")
                        .HasColumnType("boolean");

                    b.Property<int>("tipo_telefone_id")
                        .HasColumnType("integer");

                    b.HasKey("telefone_id");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("sb_ceak.Dominio.Entidade.Funcoes", b =>
                {
                    b.HasOne("sb_ceak.Dominio.Entidade.Perfis", "Perfil")
                        .WithMany("Funcao")
                        .HasForeignKey("perfil_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("sb_ceak.Dominio.Entidade.Operacoes", b =>
                {
                    b.HasOne("sb_ceak.Dominio.Entidade.Funcoes", "Funcao")
                        .WithMany("Operacao")
                        .HasForeignKey("funcao_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
