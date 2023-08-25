using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Fit.Persistence.Contextos;

#nullable disable

namespace Fit.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeAluno = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "Date", nullable: false),
                    Cpf = table.Column<long>(type: "INTEGER", nullable: false),
                    TipoSanguineo = table.Column<string>(type: "TEXT", maxLength: 3, nullable: true),
                    Altura = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FotoAluno = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GruposMusculares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeGrupo = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GruposMusculares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeUnidade = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Treinos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Observacoes = table.Column<string>(type: "TEXT", nullable: false),
                    Inicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AlunoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treinos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treinos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exercicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeExercicio = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    GrupoId = table.Column<int>(type: "INTEGER", nullable: false),
                    URL = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercicios_GruposMusculares_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "GruposMusculares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TreinoExercicios",
                columns: table => new
                {
                    TreinoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ExercicioId = table.Column<int>(type: "INTEGER", nullable: false),
                    UnidadeId = table.Column<int>(type: "INTEGER", nullable: false),
                    DiaDaSemana = table.Column<int>(type: "INTEGER", nullable: false),
                    Valor = table.Column<int>(type: "INTEGER", nullable: false),
                    Series = table.Column<int>(type: "INTEGER", nullable: false),
                    Repeticoes = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreinoExercicios", x => new { x.TreinoId, x.ExercicioId });
                    table.ForeignKey(
                        name: "FK_TreinoExercicios_Exercicios_ExercicioId",
                        column: x => x.ExercicioId,
                        principalTable: "Exercicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreinoExercicios_Treinos_TreinoId",
                        column: x => x.TreinoId,
                        principalTable: "Treinos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreinoExercicios_Unidades_UnidadeId",
                        column: x => x.UnidadeId,
                        principalTable: "Unidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercicios_GrupoId",
                table: "Exercicios",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_TreinoExercicios_ExercicioId",
                table: "TreinoExercicios",
                column: "ExercicioId");

            migrationBuilder.CreateIndex(
                name: "IX_TreinoExercicios_UnidadeId",
                table: "TreinoExercicios",
                column: "UnidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Treinos_AlunoId",
                table: "Treinos",
                column: "AlunoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TreinoExercicios");

            migrationBuilder.DropTable(
                name: "Exercicios");

            migrationBuilder.DropTable(
                name: "Treinos");

            migrationBuilder.DropTable(
                name: "Unidades");

            migrationBuilder.DropTable(
                name: "GruposMusculares");

            migrationBuilder.DropTable(
                name: "Alunos");
        }
    }
}
