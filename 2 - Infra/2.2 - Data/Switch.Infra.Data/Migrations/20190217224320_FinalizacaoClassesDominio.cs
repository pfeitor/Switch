using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class FinalizacaoClassesDominio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Identificacoes_Usuarios_UsuarioId",
                table: "Identificacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identificacoes",
                table: "Identificacoes");

            migrationBuilder.RenameTable(
                name: "Identificacoes",
                newName: "Identificao");

            migrationBuilder.RenameColumn(
                name: "DataPublicao",
                table: "Postagens",
                newName: "DataPublicacao");

            migrationBuilder.RenameIndex(
                name: "IX_Identificacoes_UsuarioId",
                table: "Identificao",
                newName: "IX_Identificao_UsuarioId");

            migrationBuilder.AddColumn<int>(
                name: "ProcurandoPorId",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusRelacionamentoId",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlConteudo",
                table: "Postagens",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrlFoto",
                table: "Grupos",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 400);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Grupos",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identificao",
                table: "Identificao",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Amigos",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false),
                    UsuarioAmigoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amigos", x => new { x.UsuarioId, x.UsuarioAmigoId });
                    table.ForeignKey(
                        name: "FK_Amigos_Usuarios_UsuarioAmigoId",
                        column: x => x.UsuarioAmigoId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Amigos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataPublicacao = table.Column<DateTime>(nullable: false),
                    Texto = table.Column<string>(maxLength: 600, nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    PostagemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comentarios_Postagens_PostagemId",
                        column: x => x.PostagemId,
                        principalTable: "Postagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comentarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstituicoesEnsino",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    AnoFormacao = table.Column<DateTime>(nullable: true),
                    EstudandoAtualmente = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstituicoesEnsino", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstituicoesEnsino_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocaisTrabalho",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    DataAdmissao = table.Column<DateTime>(nullable: false),
                    DataSaida = table.Column<DateTime>(nullable: true),
                    EmpresaAtual = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocaisTrabalho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocaisTrabalho_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcurandoPor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcurandoPor", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProcurandoPor",
                columns: new[] { "Id", "Descricao" },
                values: new object[,]
                {
                    { 1, "NaoEspecificado" },
                    { 2, "Namoro" },
                    { 3, "Amizade" },
                    { 4, "RelacionamentoSerio" }
                });

            migrationBuilder.InsertData(
                table: "StatusRelacionamento",
                columns: new[] { "Id", "Descricao" },
                values: new object[,]
                {
                    { 1, "NaoEspecificado" },
                    { 2, "Solteiro" },
                    { 3, "Casado" },
                    { 4, "EmRelacionamentoSerio" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ProcurandoPorId",
                table: "Usuarios",
                column: "ProcurandoPorId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_StatusRelacionamentoId",
                table: "Usuarios",
                column: "StatusRelacionamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Amigos_UsuarioAmigoId",
                table: "Amigos",
                column: "UsuarioAmigoId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_PostagemId",
                table: "Comentarios",
                column: "PostagemId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_UsuarioId",
                table: "Comentarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_InstituicoesEnsino_UsuarioId",
                table: "InstituicoesEnsino",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_LocaisTrabalho_UsuarioId",
                table: "LocaisTrabalho",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Identificao_Usuarios_UsuarioId",
                table: "Identificao",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_ProcurandoPor_ProcurandoPorId",
                table: "Usuarios",
                column: "ProcurandoPorId",
                principalTable: "ProcurandoPor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_StatusRelacionamento_StatusRelacionamentoId",
                table: "Usuarios",
                column: "StatusRelacionamentoId",
                principalTable: "StatusRelacionamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Identificao_Usuarios_UsuarioId",
                table: "Identificao");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_ProcurandoPor_ProcurandoPorId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_StatusRelacionamento_StatusRelacionamentoId",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Amigos");

            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "InstituicoesEnsino");

            migrationBuilder.DropTable(
                name: "LocaisTrabalho");

            migrationBuilder.DropTable(
                name: "ProcurandoPor");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_ProcurandoPorId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_StatusRelacionamentoId",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identificao",
                table: "Identificao");

            migrationBuilder.DeleteData(
                table: "StatusRelacionamento",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StatusRelacionamento",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StatusRelacionamento",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StatusRelacionamento",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "ProcurandoPorId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "StatusRelacionamentoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "UrlConteudo",
                table: "Postagens");

            migrationBuilder.RenameTable(
                name: "Identificao",
                newName: "Identificacoes");

            migrationBuilder.RenameColumn(
                name: "DataPublicacao",
                table: "Postagens",
                newName: "DataPublicao");

            migrationBuilder.RenameIndex(
                name: "IX_Identificao_UsuarioId",
                table: "Identificacoes",
                newName: "IX_Identificacoes_UsuarioId");

            migrationBuilder.AlterColumn<string>(
                name: "UrlFoto",
                table: "Grupos",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Grupos",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identificacoes",
                table: "Identificacoes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Identificacoes_Usuarios_UsuarioId",
                table: "Identificacoes",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
