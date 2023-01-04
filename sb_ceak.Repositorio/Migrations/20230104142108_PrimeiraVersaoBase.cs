using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sb_ceak.Repositorio.Migrations
{
    public partial class PrimeiraVersaoBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    autor_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    tipo_autor_id = table.Column<int>(type: "integer", nullable: false),
                    ds_Nome_Autor = table.Column<string>(type: "character", maxLength: 200, nullable: false),
                    in_Situacao_Registro = table.Column<bool>(type: "boolean", nullable: false),
                    criou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Criacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    alterou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Alteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.autor_id);
                });

            migrationBuilder.CreateTable(
                name: "EmprestimoDevolucao",
                columns: table => new
                {
                    emp_dev_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    tipo_obra_id = table.Column<int>(type: "integer", nullable: false),
                    pessoa_id = table.Column<int>(type: "integer", nullable: false),
                    obra_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Emprestimo = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dt_Prevista_Devolucao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dt_Data_Devolucao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmprestimoDevolucao", x => x.emp_dev_id);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    log_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    pessoa_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Log = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ds_Log_Realizado = table.Column<string>(type: "character", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.log_id);
                });

            migrationBuilder.CreateTable(
                name: "Obra",
                columns: table => new
                {
                    obra_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    tipo_obra_id = table.Column<int>(type: "integer", nullable: false),
                    autor_id = table.Column<int>(type: "integer", nullable: false),
                    prazo_id = table.Column<int>(type: "integer", nullable: false),
                    ds_Nome_Obra = table.Column<string>(type: "character", maxLength: 200, nullable: false),
                    ds_Codigo_Obra = table.Column<string>(type: "character", maxLength: 30, nullable: false),
                    ds_Duracao_Obra = table.Column<string>(nullable: true),
                    ds_Divulgadora_Obra = table.Column<string>(type: "character", maxLength: 30, nullable: true),
                    ds_Edicao_Obra = table.Column<string>(type: "character", maxLength: 30, nullable: true),
                    ds_Mes_Ano_Publicacao_Obra = table.Column<string>(type: "character", maxLength: 30, nullable: true),
                    ds_Ano_Publicacao_Obra = table.Column<string>(type: "character", maxLength: 30, nullable: true),
                    ds_Editora_Obra = table.Column<string>(type: "character", maxLength: 50, nullable: true),
                    qtd_Pagina_Obra = table.Column<int>(type: "integer", nullable: false),
                    ds_CDU_Obra = table.Column<string>(type: "character", maxLength: 30, nullable: true),
                    ds_CDD_Obra = table.Column<string>(type: "character", maxLength: 30, nullable: true),
                    dt_Data_Cadastro_Obra = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    in_Situacao_Registro = table.Column<bool>(type: "boolean", nullable: false),
                    criou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Criacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    alterou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Alteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obra", x => x.obra_id);
                });

            migrationBuilder.CreateTable(
                name: "Parametro",
                columns: table => new
                {
                    parametro_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    telefone_id = table.Column<int>(type: "integer", nullable: false),
                    ds_Nome_Parametro = table.Column<string>(type: "character", maxLength: 200, nullable: false),
                    ds_CNPJ_Parametro = table.Column<string>(type: "character", maxLength: 20, nullable: false),
                    ds_Endereco_Parametro = table.Column<string>(type: "character", maxLength: 200, nullable: false),
                    ds_CEP_Parametro = table.Column<string>(type: "character", maxLength: 10, nullable: false),
                    uf_id = table.Column<int>(type: "integer", nullable: false),
                    ds_Site_Parametro = table.Column<string>(type: "character", maxLength: 200, nullable: false),
                    ds_Email_Parametro = table.Column<string>(type: "character", maxLength: 200, nullable: false),
                    ds_Presidente_Parametro = table.Column<string>(type: "character", maxLength: 100, nullable: false),
                    ds_Tesoureiro_Parametro = table.Column<string>(type: "character", maxLength: 100, nullable: false),
                    in_Situacao_Registro = table.Column<bool>(type: "boolean", nullable: false),
                    criou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Criacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    alterou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Alteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametro", x => x.parametro_id);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    perfil_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ds_Nome_Perfil = table.Column<string>(type: "character", maxLength: 100, nullable: false),
                    in_Situacao_Registro = table.Column<bool>(type: "boolean", nullable: false),
                    criou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Criacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    alterou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Alteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.perfil_id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    pessoa_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    perfil_id = table.Column<int>(type: "integer", nullable: false),
                    telefone_id = table.Column<int>(type: "integer", nullable: false),
                    ds_Nome_Pessoa = table.Column<string>(type: "character", maxLength: 200, nullable: false),
                    ds_Endereco_Pessoa = table.Column<string>(type: "character", maxLength: 200, nullable: false),
                    ds_CEP_Pessoa = table.Column<string>(type: "character", maxLength: 10, nullable: false),
                    uf_id = table.Column<int>(type: "integer", nullable: false),
                    ds_Email_Pessoa = table.Column<string>(type: "character", maxLength: 200, nullable: false),
                    ds_Senha_Pessoa = table.Column<string>(type: "character", maxLength: 10, nullable: false),
                    dt_Data_Cadastro_Pessoa = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    in_Situacao_Registro = table.Column<bool>(type: "boolean", nullable: false),
                    criou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Criacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    alterou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Alteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.pessoa_id);
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    reserva_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    pessoa_id = table.Column<int>(type: "integer", nullable: false),
                    obra_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Reserva = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.reserva_id);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    telefone_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    tipo_telefone_id = table.Column<int>(type: "integer", nullable: false),
                    ds_DDD_Telefone = table.Column<string>(type: "character", maxLength: 10, nullable: false),
                    ds_Numero_Telefone = table.Column<string>(type: "character", maxLength: 10, nullable: false),
                    in_Situacao_Registro = table.Column<bool>(type: "boolean", nullable: false),
                    criou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Criacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    alterou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Alteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.telefone_id);
                });

            migrationBuilder.CreateTable(
                name: "Funcao",
                columns: table => new
                {
                    funcao_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ds_Nome_Funcao = table.Column<string>(type: "character", maxLength: 100, nullable: false),
                    perfil_id = table.Column<int>(nullable: false),
                    in_Situacao_Registro = table.Column<bool>(type: "boolean", nullable: false),
                    criou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Criacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    alterou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Alteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcao", x => x.funcao_id);
                    table.ForeignKey(
                        name: "FK_Funcao_Perfil_perfil_id",
                        column: x => x.perfil_id,
                        principalTable: "Perfil",
                        principalColumn: "perfil_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Operacao",
                columns: table => new
                {
                    operacao_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ds_Nome_Operacao = table.Column<string>(type: "character", maxLength: 100, nullable: false),
                    funcao_id = table.Column<int>(nullable: false),
                    in_Situacao_Registro = table.Column<bool>(type: "boolean", nullable: false),
                    criou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Criacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    alterou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Alteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operacao", x => x.operacao_id);
                    table.ForeignKey(
                        name: "FK_Operacao_Funcao_funcao_id",
                        column: x => x.funcao_id,
                        principalTable: "Funcao",
                        principalColumn: "funcao_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcao_perfil_id",
                table: "Funcao",
                column: "perfil_id");

            migrationBuilder.CreateIndex(
                name: "IX_Operacao_funcao_id",
                table: "Operacao",
                column: "funcao_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropTable(
                name: "EmprestimoDevolucao");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Obra");

            migrationBuilder.DropTable(
                name: "Operacao");

            migrationBuilder.DropTable(
                name: "Parametro");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "Funcao");

            migrationBuilder.DropTable(
                name: "Perfil");
        }
    }
}
