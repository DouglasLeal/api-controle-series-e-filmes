using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Migrations
{
    public partial class TabelaFilmes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Assistido = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    TituloOriginal = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    TituloBrasileiro = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    Nota = table.Column<int>(type: "INTEGER", nullable: false),
                    Lancamento = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmes");
        }
    }
}
