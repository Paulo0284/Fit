using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fit.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class alunocamposuniques : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeGrupo",
                table: "GruposMusculares",
                type: "TEXT",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_Cpf",
                table: "Alunos",
                column: "Cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_Email",
                table: "Alunos",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Alunos_Cpf",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_Email",
                table: "Alunos");

            migrationBuilder.AlterColumn<string>(
                name: "NomeGrupo",
                table: "GruposMusculares",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
