using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Api.Migrations
{
    /// <inheritdoc />
    public partial class RetirandoApanhadoDasClassesPokemonEvolucao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apanhado",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Apanhado",
                table: "Evolucao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Apanhado",
                table: "Pokemon",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Apanhado",
                table: "Evolucao",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Evolucao",
                keyColumn: "Id",
                keyValue: 1,
                column: "Apanhado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Evolucao",
                keyColumn: "Id",
                keyValue: 2,
                column: "Apanhado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Evolucao",
                keyColumn: "Id",
                keyValue: 3,
                column: "Apanhado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Evolucao",
                keyColumn: "Id",
                keyValue: 4,
                column: "Apanhado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Evolucao",
                keyColumn: "Id",
                keyValue: 5,
                column: "Apanhado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Evolucao",
                keyColumn: "Id",
                keyValue: 6,
                column: "Apanhado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 1,
                column: "Apanhado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 2,
                column: "Apanhado",
                value: false);

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 3,
                column: "Apanhado",
                value: false);
        }
    }
}
