using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sb_ceak.Repositorio.Migrations
{
    public partial class AdicionaDadosTipoObra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "ds_Prazo_Dia_Obra",
                table: "TipoObra");

            migrationBuilder.AddColumn<string>(
                name: "ds_Prazo_Dia_Acervo",
                table: "TipoAcervo",
                type: "character(2)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "tipo_acervo_id",
                table: "Obra",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "TipoObra",
                columns: new[] { "tipo_obra_id", "alterou_Registro_id", "criou_Registro_id", "ds_Nome_Tipo_Obra", "dt_Data_Alteracao", "dt_Data_Criacao", "in_Situacao_Registro" },
                values: new object[,]
                {
                    { 1, 0, 1, "AUTOAJUDA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 21, 0, 1, "RÁDIO NOVELA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 20, 0, 1, "REFLEXÃO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 19, 0, 1, "PALESTRA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 18, 0, 1, "PRECE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 17, 0, 1, "POESIA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 16, 0, 1, "OUTRA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 15, 0, 1, "PERGUNTAS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 14, 0, 1, "MENSAGEM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 13, 0, 1, "MEDITAÇÃO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 22, 0, 1, "SEMINÁRIO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 12, 0, 1, "HISTÓRIA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 10, 0, 1, "ENTREVISTA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 9, 0, 1, "ESTUDO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 8, 0, 1, "DOCUMENTÁRIO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 7, 0, 1, "CONFERÊNCIA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 6, 0, 1, "CRÔNICA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 5, 0, 1, "CITAÇÕES", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 4, 0, 1, "CARTAS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 3, 0, 1, "BIOGRAFIA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 2, 0, 1, "BIBLIOGRAFIA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 11, 0, 1, "FILME", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 23, 0, 1, "SEMINÁRIO MUSICAL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TipoObra",
                keyColumn: "tipo_obra_id",
                keyValue: 23);

            migrationBuilder.DropColumn(
                name: "ds_Prazo_Dia_Acervo",
                table: "TipoAcervo");

            migrationBuilder.DropColumn(
                name: "tipo_acervo_id",
                table: "Obra");

            migrationBuilder.AddColumn<string>(
                name: "ds_Prazo_Dia_Obra",
                table: "TipoObra",
                type: "character(2)",
                nullable: false,
                defaultValue: "");

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
    }
}
