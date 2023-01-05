using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace sb_ceak.Repositorio.Migrations
{
    public partial class AcertoBaseDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoAcervo",
                columns: table => new
                {
                    tipo_acervo_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ds_Nome_Tipo_Acervo = table.Column<string>(type: "character(100)", nullable: false),
                    in_Situacao_Registro = table.Column<bool>(type: "boolean", nullable: false),
                    criou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Criacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    alterou_Registro_id = table.Column<int>(type: "integer", nullable: false),
                    dt_Data_Alteracao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAcervo", x => x.tipo_acervo_id);
                });

            migrationBuilder.InsertData(
                table: "TipoAutor",
                columns: new[] { "tipo_autor_id", "alterou_Registro_id", "criou_Registro_id", "ds_Nome_Tipo_Autor", "dt_Data_Alteracao", "dt_Data_Criacao", "in_Situacao_Registro" },
                values: new object[,]
                {
                    { 1, 0, 1, "ESPIRITUAL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 2, 0, 1, "INTUÍDO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 3, 0, 1, "OUTRO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 4, 0, 1, "PSCICOGRÁFICO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoAcervo");

            migrationBuilder.DeleteData(
                table: "TipoAutor",
                keyColumn: "tipo_autor_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoAutor",
                keyColumn: "tipo_autor_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoAutor",
                keyColumn: "tipo_autor_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoAutor",
                keyColumn: "tipo_autor_id",
                keyValue: 4);
        }
    }
}
