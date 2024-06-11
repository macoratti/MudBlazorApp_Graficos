using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MudBlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class Ajuste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "DepartamentoId", "Nome" },
                values: new object[,]
                {
                    { 4, "Qualidade" },
                    { 5, "Suporte" }
                });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "FuncionarioId", "Cargo", "DepartamentoId", "Nome", "Salario" },
                values: new object[,]
                {
                    { 11, "Analista de Suporte", 5, "João", 3800m },
                    { 12, "Técnica de Suporte", 5, "Mariana", 3000m },
                    { 13, "Assistente de Suporte", 5, "Lucas", 2500m },
                    { 14, "Analista de Qualidade", 4, "Carla", 4000m },
                    { 15, "Técnico de Qualidade", 4, "Paulo", 3200m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 5);
        }
    }
}
