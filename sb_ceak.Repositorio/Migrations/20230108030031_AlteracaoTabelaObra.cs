using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sb_ceak.Repositorio.Migrations
{
    public partial class AlteracaoTabelaObra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "autor_ps1_id",
                table: "Obra",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "autor_ps2_id",
                table: "Obra",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "autor_sec_id",
                table: "Obra",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "autor_ps1_id",
                table: "Obra");

            migrationBuilder.DropColumn(
                name: "autor_ps2_id",
                table: "Obra");

            migrationBuilder.DropColumn(
                name: "autor_sec_id",
                table: "Obra");

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 1,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 2,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 3,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 4,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 5,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 6,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 7,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 8,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 9,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 10,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 11,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 12,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 13,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 14,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 15,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 16,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 17,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 18,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 19,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 20,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 21,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 22,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 23,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 24,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 25,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 26,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Unidade_Federativas",
                keyColumn: "uf_id",
                keyValue: 27,
                column: "dt_Data_Criacao",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
