using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudASPEjemplo.Migrations
{
    public partial class testFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Pagos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Pagos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EsEfectuado",
                table: "Pagos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Pagos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Monto",
                table: "Pagos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "EsEfectuado",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "Monto",
                table: "Pagos");
        }
    }
}
