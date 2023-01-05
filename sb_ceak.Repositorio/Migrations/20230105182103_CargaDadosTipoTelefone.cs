using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sb_ceak.Repositorio.Migrations
{
    public partial class CargaDadosTipoTelefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipoAcervo",
                keyColumn: "tipo_acervo_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoAcervo",
                keyColumn: "tipo_acervo_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoAcervo",
                keyColumn: "tipo_acervo_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoAcervo",
                keyColumn: "tipo_acervo_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TipoAcervo",
                keyColumn: "tipo_acervo_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TipoAcervo",
                keyColumn: "tipo_acervo_id",
                keyValue: 6);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "TipoAcervo",
                columns: new[] { "tipo_acervo_id", "alterou_Registro_id", "criou_Registro_id", "ds_Nome_Tipo_Acervo", "ds_Prazo_Dia_Acervo", "dt_Data_Alteracao", "dt_Data_Criacao", "in_Situacao_Registro" },
                values: new object[,]
                {
                    { 1, 0, 1, "CD VÍDEO", "15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 2, 0, 1, "DVD", "15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 3, 0, 1, "FITA K7", "15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 4, 0, 1, "LIVRO", "30", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 5, 0, 1, "OUTRO", "15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 6, 0, 1, "PERIÓDICO", "30", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local), true }
                });
        }
    }
}
