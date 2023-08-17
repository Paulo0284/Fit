﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fit.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class cpfTabelaAluno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Cpf",
                table: "Alunos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Alunos");
        }
    }
}
