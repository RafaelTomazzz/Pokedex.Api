using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Api.Migrations
{
    /// <inheritdoc />
    public partial class AlteracaoHabilidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pontos_Vida",
                table: "Habilidade",
                newName: "Power");

            migrationBuilder.RenameColumn(
                name: "Pontos_Defesa",
                table: "Habilidade",
                newName: "Pontos_Precisao");

            migrationBuilder.RenameColumn(
                name: "Pontos_Ataque",
                table: "Habilidade",
                newName: "Pontos_Power");

            migrationBuilder.AddColumn<int>(
                name: "Elemento",
                table: "Habilidade",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Elemento",
                table: "Habilidade");

            migrationBuilder.RenameColumn(
                name: "Power",
                table: "Habilidade",
                newName: "Pontos_Vida");

            migrationBuilder.RenameColumn(
                name: "Pontos_Precisao",
                table: "Habilidade",
                newName: "Pontos_Defesa");

            migrationBuilder.RenameColumn(
                name: "Pontos_Power",
                table: "Habilidade",
                newName: "Pontos_Ataque");
        }
    }
}
