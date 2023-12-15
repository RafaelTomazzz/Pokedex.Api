using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Api.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoModelPokemon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Peso_Pokemon",
                table: "Pokemon",
                type: "real",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AddColumn<float>(
                name: "Altura_Pokemon",
                table: "Pokemon",
                type: "real",
                maxLength: 3,
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Pontos_Velocidade",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Altura_Pokemon",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Pontos_Velocidade",
                table: "Pokemon");

            migrationBuilder.AlterColumn<string>(
                name: "Peso_Pokemon",
                table: "Pokemon",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real",
                oldMaxLength: 3);
        }
    }
}
