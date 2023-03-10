using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sb_ceak.Repositorio.Migrations
{
    public partial class CargaTodasTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TipoAcervo",
                columns: new[] { "tipo_acervo_id", "alterou_Registro_id", "criou_Registro_id", "ds_Nome_Tipo_Acervo", "ds_Prazo_Dia_Acervo", "dt_Data_Alteracao", "dt_Data_Criacao", "in_Situacao_Registro" },
                values: new object[,]
                {
                    { 1, 0, 1, "CD VÍDEO", "15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 2, 0, 1, "DVD", "15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 3, 0, 1, "FITA K7", "15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 4, 0, 1, "LIVRO", "30", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 5, 0, 1, "OUTRO", "30", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 6, 0, 1, "PERIÓDICO", "30", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true }
                });

            migrationBuilder.InsertData(
                table: "TipoAutor",
                columns: new[] { "tipo_autor_id", "alterou_Registro_id", "criou_Registro_id", "ds_Nome_Tipo_Autor", "dt_Data_Alteracao", "dt_Data_Criacao", "in_Situacao_Registro" },
                values: new object[,]
                {
                    { 1, 0, 1, "ESPIRITUAL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 2, 0, 1, "INTUÍDO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 3, 0, 1, "OUTRO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 4, 0, 1, "PSICOGRÁFICO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true }
                });

            migrationBuilder.InsertData(
                table: "TipoObra",
                columns: new[] { "tipo_obra_id", "alterou_Registro_id", "criou_Registro_id", "ds_Nome_Tipo_Obra", "dt_Data_Alteracao", "dt_Data_Criacao", "in_Situacao_Registro" },
                values: new object[,]
                {
                    { 14, 0, 1, "MENSAGEM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 15, 0, 1, "PERGUNTAS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 16, 0, 1, "OUTRA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 17, 0, 1, "POESIA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 23, 0, 1, "SEMINÁRIO MUSICAL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 19, 0, 1, "PALESTRA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 20, 0, 1, "REFLEXÃO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 21, 0, 1, "RÁDIO NOVELA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 13, 0, 1, "MEDITAÇÃO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 18, 0, 1, "PRECE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 12, 0, 1, "HISTÓRIA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 22, 0, 1, "SEMINÁRIO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 10, 0, 1, "ENTREVISTA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 1, 0, 1, "AUTOAJUDA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 2, 0, 1, "BIBLIOGRAFIA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 3, 0, 1, "BIOGRAFIA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 4, 0, 1, "CARTAS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 11, 0, 1, "FILME", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 6, 0, 1, "CRÔNICA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 7, 0, 1, "CONFERÊNCIA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 8, 0, 1, "DOCUMENTÁRIO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 9, 0, 1, "ESTUDO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 5, 0, 1, "CITAÇÕES", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true }
                });

            migrationBuilder.InsertData(
                table: "TipoTelefone",
                columns: new[] { "tipo_telefone_id", "alterou_Registro_id", "criou_Registro_id", "ds_Tipo_Telefone", "dt_Data_Alteracao", "dt_Data_Criacao", "in_Situacao_Registro" },
                values: new object[,]
                {
                    { 1, 0, 1, "CELULAR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 2, 0, 1, "COMERCIAL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true },
                    { 3, 0, 1, "RESIDENCIAL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), true }
                });

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 1,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 2,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 3,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 4,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 5,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 6,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 7,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 8,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 9,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 10,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 11,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 12,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 13,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 14,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 15,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 16,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 17,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 18,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 19,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 20,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 21,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 22,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 23,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 24,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 25,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 26,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 27,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 1,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 2,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 3,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 4,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 5,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 6,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 7,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 8,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 9,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 10,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 11,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 12,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 13,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 14,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 15,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 16,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 17,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 18,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 19,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 20,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 21,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 22,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 23,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 24,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 25,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 26,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 27,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
