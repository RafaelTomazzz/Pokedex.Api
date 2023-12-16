using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Api.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoModelEvolucao3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome_Pokemon",
                table: "Evolucao",
                newName: "Nome_Evolcucao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome_Evolcucao",
                table: "Evolucao",
                newName: "Nome_Pokemon");
        }
    }
}
