using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pokedex.Api.Migrations
{
    /// <inheritdoc />
    public partial class NaoSei : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Altura_Pokemon", "Codigo", "Descricao", "Elemento", "Imagem", "Max_Ataque", "Max_Defesa", "Max_Velocidade", "Max_Vida", "Min_Ataque", "Min_Defesa", "Min_Velocidade", "Min_Vida", "Nome_Pokemon", "Peso_Pokemon", "SegundoElemento" },
                values: new object[] { 4, 0.3f, 10, "Its short feet are tipped with suction pads that enable it to tirelessly climb slopes and walls.", 13, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/010.png", 174, 185, 207, 294, 30, 35, 45, 45, "Caterpie", 2.9f, 0 });

            migrationBuilder.InsertData(
                table: "Evolucao",
                columns: new[] { "Id", "Altura_Evolucao", "Codigo", "Descricao", "Elemento", "IdPokemon", "Imagem", "Max_Ataque", "Max_Defesa", "Max_Velocidade", "Max_Vida", "Min_Ataque", "Min_Defesa", "Min_Velocidade", "Min_Vida", "Nome_Evolcucao", "Peso_Evolucao", "SegundoElemento" },
                values: new object[,]
                {
                    { 7, 0.7f, 11, "This POKéMON is vulnerable to attack while its shell is soft, exposing its weak and tender body.", 13, 4, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/011.png", 152, 229, 174, 304, 20, 55, 30, 50, "Metapod", 9.9f, 0 },
                    { 8, 1.1f, 12, "In battle, it flaps its wings at high speed to release highly toxic dust into the air.", 13, 4, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/012.png", 207, 218, 262, 324, 45, 50, 70, 60, "Butterfree", 32f, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Evolucao",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Evolucao",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
