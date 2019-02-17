using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class AddDataPostagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Texto",
                table: "Postagem",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataPublicao",
                table: "Postagem",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataPublicao",
                table: "Postagem");

            migrationBuilder.AlterColumn<string>(
                name: "Texto",
                table: "Postagem",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 400);
        }
    }
}
