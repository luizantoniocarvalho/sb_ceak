using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace sb_ceak.Repositorio.Migrations
{
    public partial class CargaDadosuNIDADEfEDERATIVA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipoTelefone",
                keyColumn: "tipo_telefone_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoTelefone",
                keyColumn: "tipo_telefone_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoTelefone",
                keyColumn: "tipo_telefone_id",
                keyValue: 3);

            migrationBuilder.CreateTable(
                name: "Unidade_Federativas",
                columns: table => new
                {
                    uf_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ds_Nome_UF = table.Column<string>(type: "character(100)", nullable: false),
                    ds_Sigla_UF = table.Column<string>(type: "character(2)", nullable: false),
                    in_Situacao_Registro = table.Column<bool>(type: "boolean", nullable: false),
                    criou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Criacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    alterou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Alteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidade_Federativas", x => x.uf_id);
                });

            migrationBuilder.InsertData(
                table: "Unidade_Federativas",
                columns: new[] { "uf_id", "alterou_Registro_id", "criou_Registro_id", "ds_Nome_UF", "ds_Sigla_UF", "dt_Data_Alteracao", "dt_Data_Criacao", "in_Situacao_Registro" },
                values: new object[,]
                {
                    { 1, 0, 1, "ACRE", "AC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 25, 0, 1, "SERGIPE", "SE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 24, 0, 1, "SANTA CATARINA", "SC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 23, 0, 1, "RIO GRANDE DO SUL", "RS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 22, 0, 1, "RORAIMA", "RR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 21, 0, 1, "RONDÔNIA", "EO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 20, 0, 1, "RIO GRANDE DO NORTE", "RN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 19, 0, 1, "RIO DE JANEIRO", "RJ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 18, 0, 1, "PARANÁ", "PR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 17, 0, 1, "PIAUÍ", "PI", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 16, 0, 1, "PERNAMBUCO", "PE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 15, 0, 1, "PARAÍBA", "PB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 26, 0, 1, "SÃO PAULO", "SP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 14, 0, 1, "PARÁ", "PA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 12, 0, 1, "MATO GROSSO DO SUL", "MS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 11, 0, 1, "MINAS GERAIS", "MG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 10, 0, 1, "MARANHÃO", "MA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 9, 0, 1, "GOIÁS", "GO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 8, 0, 1, "ESPÍRITO SANTO", "ES", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 7, 0, 1, "DISTRITO FEDERAL", "DF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 6, 0, 1, "CEARÁ", "CE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 5, 0, 1, "BAHIA", "BA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 4, 0, 1, "AMAPÁ", "AP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 3, 0, 1, "AMAZONAS", "AM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 2, 0, 1, "ALAGOAS", "AL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 13, 0, 1, "MATO GROSSO", "MT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 27, 0, 1, "TOCANTINS", "TO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Unidade_Federativas");

            migrationBuilder.InsertData(
                table: "TipoTelefone",
                columns: new[] { "tipo_telefone_id", "alterou_Registro_id", "criou_Registro_id", "ds_Tipo_Telefone", "dt_Data_Alteracao", "dt_Data_Criacao", "in_Situacao_Registro" },
                values: new object[,]
                {
                    { 1, 0, 1, "CELULAR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 2, 0, 1, "COMERCIAL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 3, 0, 1, "RESIDENCIAL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true }
                });
        }
    }
}
