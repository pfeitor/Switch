﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class AjustesTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Identificacao_Usuarios_UsuarioId",
                table: "Identificacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Postagem_Grupo_GrupoId",
                table: "Postagem");

            migrationBuilder.DropForeignKey(
                name: "FK_Postagem_Usuarios_UsuarioId",
                table: "Postagem");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioGrupo_Grupo_GrupoId",
                table: "UsuarioGrupo");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioGrupo_Usuarios_UsuarioId",
                table: "UsuarioGrupo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statusrelacionamento",
                table: "Statusrelacionamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioGrupo",
                table: "UsuarioGrupo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Postagem",
                table: "Postagem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identificacao",
                table: "Identificacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grupo",
                table: "Grupo");

            migrationBuilder.RenameTable(
                name: "Statusrelacionamento",
                newName: "StatusRelacionamento");

            migrationBuilder.RenameTable(
                name: "UsuarioGrupo",
                newName: "UsuarioGrupos");

            migrationBuilder.RenameTable(
                name: "Postagem",
                newName: "Postagens");

            migrationBuilder.RenameTable(
                name: "Identificacao",
                newName: "Identificacoes");

            migrationBuilder.RenameTable(
                name: "Grupo",
                newName: "Grupos");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioGrupo_GrupoId",
                table: "UsuarioGrupos",
                newName: "IX_UsuarioGrupos_GrupoId");

            migrationBuilder.RenameIndex(
                name: "IX_Postagem_UsuarioId",
                table: "Postagens",
                newName: "IX_Postagens_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Postagem_GrupoId",
                table: "Postagens",
                newName: "IX_Postagens_GrupoId");

            migrationBuilder.RenameIndex(
                name: "IX_Identificacao_UsuarioId",
                table: "Identificacoes",
                newName: "IX_Identificacoes_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusRelacionamento",
                table: "StatusRelacionamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioGrupos",
                table: "UsuarioGrupos",
                columns: new[] { "UsuarioId", "GrupoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Postagens",
                table: "Postagens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identificacoes",
                table: "Identificacoes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grupos",
                table: "Grupos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Identificacoes_Usuarios_UsuarioId",
                table: "Identificacoes",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Postagens_Grupos_GrupoId",
                table: "Postagens",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Postagens_Usuarios_UsuarioId",
                table: "Postagens",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioGrupos_Grupos_GrupoId",
                table: "UsuarioGrupos",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioGrupos_Usuarios_UsuarioId",
                table: "UsuarioGrupos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Identificacoes_Usuarios_UsuarioId",
                table: "Identificacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Postagens_Grupos_GrupoId",
                table: "Postagens");

            migrationBuilder.DropForeignKey(
                name: "FK_Postagens_Usuarios_UsuarioId",
                table: "Postagens");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioGrupos_Grupos_GrupoId",
                table: "UsuarioGrupos");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioGrupos_Usuarios_UsuarioId",
                table: "UsuarioGrupos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusRelacionamento",
                table: "StatusRelacionamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioGrupos",
                table: "UsuarioGrupos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Postagens",
                table: "Postagens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identificacoes",
                table: "Identificacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grupos",
                table: "Grupos");

            migrationBuilder.RenameTable(
                name: "StatusRelacionamento",
                newName: "Statusrelacionamento");

            migrationBuilder.RenameTable(
                name: "UsuarioGrupos",
                newName: "UsuarioGrupo");

            migrationBuilder.RenameTable(
                name: "Postagens",
                newName: "Postagem");

            migrationBuilder.RenameTable(
                name: "Identificacoes",
                newName: "Identificacao");

            migrationBuilder.RenameTable(
                name: "Grupos",
                newName: "Grupo");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioGrupos_GrupoId",
                table: "UsuarioGrupo",
                newName: "IX_UsuarioGrupo_GrupoId");

            migrationBuilder.RenameIndex(
                name: "IX_Postagens_UsuarioId",
                table: "Postagem",
                newName: "IX_Postagem_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Postagens_GrupoId",
                table: "Postagem",
                newName: "IX_Postagem_GrupoId");

            migrationBuilder.RenameIndex(
                name: "IX_Identificacoes_UsuarioId",
                table: "Identificacao",
                newName: "IX_Identificacao_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statusrelacionamento",
                table: "Statusrelacionamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioGrupo",
                table: "UsuarioGrupo",
                columns: new[] { "UsuarioId", "GrupoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Postagem",
                table: "Postagem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identificacao",
                table: "Identificacao",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grupo",
                table: "Grupo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Identificacao_Usuarios_UsuarioId",
                table: "Identificacao",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Postagem_Grupo_GrupoId",
                table: "Postagem",
                column: "GrupoId",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Postagem_Usuarios_UsuarioId",
                table: "Postagem",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioGrupo_Grupo_GrupoId",
                table: "UsuarioGrupo",
                column: "GrupoId",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioGrupo_Usuarios_UsuarioId",
                table: "UsuarioGrupo",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
