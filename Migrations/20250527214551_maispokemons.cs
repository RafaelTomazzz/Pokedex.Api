using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pokedex.Api.Migrations
{
    /// <inheritdoc />
    public partial class maispokemons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Altura_Pokemon", "Codigo", "Descricao", "Elemento", "Imagem", "Max_Ataque", "Max_Defesa", "Max_Velocidade", "Max_Vida", "Min_Ataque", "Min_Defesa", "Min_Velocidade", "Min_Vida", "Nome_Pokemon", "Peso_Pokemon", "SegundoElemento" },
                values: new object[,]
                {
                    { 5, 0.3f, 13, "Often found in forests, eating leaves. It has a sharp venomous stinger on its head.", 13, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/013.png", 185, 174, 218, 284, 35, 30, 50, 40, "Weedle", 3.2f, 7 },
                    { 6, 0.3f, 16, "A common sight in forests and woods. It flaps its wings at ground level to kick up blinding sand.", 1, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/016.png", 207, 196, 232, 284, 45, 40, 56, 40, "Pidgey", 1.8f, 5 }
                });

            migrationBuilder.InsertData(
                table: "Evolucao",
                columns: new[] { "Id", "Altura_Evolucao", "Codigo", "Descricao", "Elemento", "IdPokemon", "Imagem", "Max_Ataque", "Max_Defesa", "Max_Velocidade", "Max_Vida", "Min_Ataque", "Min_Defesa", "Min_Velocidade", "Min_Vida", "Nome_Evolcucao", "Peso_Evolucao", "SegundoElemento" },
                values: new object[,]
                {
                    { 9, 0.6f, 14, "Almost incapable of moving, this POKéMON can only harden its shell to protect itself from predators.", 13, 5, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/014.png", 163, 218, 67, 294, 25, 50, 35, 45, "Kakuna", 10f, 7 },
                    { 10, 1f, 15, "Flies at high speed and attacks using its large venomous stingers on its forelegs and tail.", 13, 5, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/015.png", 306, 196, 273, 334, 90, 50, 75, 65, "Beedrill", 29.5f, 7 },
                    { 11, 1.1f, 17, "Very protective of its sprawling territorial area, this POKéMON will fiercely peck at any intruder.", 1, 6, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/017.png", 240, 229, 218, 330, 60, 55, 71, 63, "Pidgeotto", 30f, 5 },
                    { 12, 1.5f, 18, "When hunting, it skims the surface of water at high speed to pick off unwary prey such as MAGIKARP.", 1, 6, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/018.png", 284, 273, 331, 370, 80, 75, 101, 83, "Pidgeot", 39.5f, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Evolucao",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Evolucao",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Evolucao",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Evolucao",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
