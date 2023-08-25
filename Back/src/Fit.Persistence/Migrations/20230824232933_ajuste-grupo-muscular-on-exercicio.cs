using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fit.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ajustegrupomuscularonexercicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercicios_GruposMusculares_GrupoId",
                table: "Exercicios");

            migrationBuilder.RenameColumn(
                name: "GrupoId",
                table: "Exercicios",
                newName: "GrupoMuscularId");

            migrationBuilder.RenameIndex(
                name: "IX_Exercicios_GrupoId",
                table: "Exercicios",
                newName: "IX_Exercicios_GrupoMuscularId");

            migrationBuilder.AlterColumn<string>(
                name: "NomeUnidade",
                table: "Unidades",
                type: "TEXT",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Observacoes",
                table: "Treinos",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "Exercicios",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "NomeExercicio",
                table: "Exercicios",
                type: "TEXT",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Alunos",
                type: "TEXT",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Alunos",
                type: "TEXT",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AddForeignKey(
                name: "FK_Exercicios_GruposMusculares_GrupoMuscularId",
                table: "Exercicios",
                column: "GrupoMuscularId",
                principalTable: "GruposMusculares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercicios_GruposMusculares_GrupoMuscularId",
                table: "Exercicios");

            migrationBuilder.RenameColumn(
                name: "GrupoMuscularId",
                table: "Exercicios",
                newName: "GrupoId");

            migrationBuilder.RenameIndex(
                name: "IX_Exercicios_GrupoMuscularId",
                table: "Exercicios",
                newName: "IX_Exercicios_GrupoId");

            migrationBuilder.AlterColumn<string>(
                name: "NomeUnidade",
                table: "Unidades",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Observacoes",
                table: "Treinos",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "Exercicios",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeExercicio",
                table: "Exercicios",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Alunos",
                type: "TEXT",
                maxLength: 11,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Alunos",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Exercicios_GruposMusculares_GrupoId",
                table: "Exercicios",
                column: "GrupoId",
                principalTable: "GruposMusculares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
