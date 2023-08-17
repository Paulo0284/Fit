using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fit.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class TabelaAluno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    IdAluno = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeAluno = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "Date", nullable: false),
                    TipoSanguineo = table.Column<string>(type: "TEXT", maxLength: 3, nullable: true),
                    Altura = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FotoAluno = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.IdAluno);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");
        }
    }
}
