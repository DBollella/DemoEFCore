using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEFCore.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Eventos",
                newName: "EventoId");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Eventos",
                maxLength: 500,
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EventoId",
                table: "Eventos",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Eventos",
                maxLength: 1000,
                nullable: false);
        }
    }
}
