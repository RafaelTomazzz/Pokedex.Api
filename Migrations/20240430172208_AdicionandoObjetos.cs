using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pokedex.Api.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoObjetos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EvolucaoHabilidade_Evolucao_IdHabilidade",
                table: "EvolucaoHabilidade");

            migrationBuilder.DropForeignKey(
                name: "FK_EvolucaoHabilidade_Habilidade_HabilidadeId",
                table: "EvolucaoHabilidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonHabilidade",
                table: "PokemonHabilidade");

            migrationBuilder.DropIndex(
                name: "IX_PokemonHabilidade_IdHabilidade",
                table: "PokemonHabilidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EvolucaoHabilidade",
                table: "EvolucaoHabilidade");

            migrationBuilder.DropIndex(
                name: "IX_EvolucaoHabilidade_HabilidadeId",
                table: "EvolucaoHabilidade");

            migrationBuilder.DropColumn(
                name: "HabilidadeId",
                table: "EvolucaoHabilidade");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonHabilidade",
                table: "PokemonHabilidade",
                columns: new[] { "IdHabilidade", "IdPokemon" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_EvolucaoHabilidade",
                table: "EvolucaoHabilidade",
                columns: new[] { "IdHabilidade", "IdEvolucao" });

            migrationBuilder.InsertData(
                table: "Habilidade",
                columns: new[] { "Id", "Descricao", "Elemento", "Nome_Habilidade", "Power", "Pontos_Power", "Pontos_Precisao" },
                values: new object[,]
                {
                    { 1, "A physical attack in which the user charges and slams into the foe with its whole body.", 1, "Tackle", 40, 35, 100 },
                    { 2, "The foe is struck with slender, whiplike vines to inflict damage.", 4, "Vine Whip", 45, 25, 100 },
                    { 3, "A sharp-edged leaf is launched to slash at the foe. It has a high critical-hit ratio.", 4, "Razor Leaf", 55, 25, 95 },
                    { 4, "Hard, pointed, and sharp claws rake the foe to inflict damage.", 1, "Scratch", 40, 35, 100 },
                    { 5, "The target is attacked with small flames. It may also leave the target with a burn.", 2, "Ember", 40, 25, 100 },
                    { 6, "The user bites with flame-cloaked fangs. This may also make the target flinch or leave it with a burn.", 2, "Fire Fang", 65, 15, 95 },
                    { 7, "Sharp, huge claws hook and slash the foe quickly and with great power.", 16, "Dragon Claw", 80, 15, 100 },
                    { 8, "The foe is struck with a lot of water expelled forcibly from the mouth.", 3, "Water Gun", 40, 25, 100 },
                    { 9, "The user attacks the foe with a pulsing blast of water. It may also confuse the foe.", 3, "Water Pulse", 60, 20, 100 }
                });

            migrationBuilder.InsertData(
                table: "Treinador",
                columns: new[] { "Id", "Data_Nascimento", "Login", "Primeiro_Nome", "Segundo_Nome", "Senha" },
                values: new object[,]
                {
                    { 1, new DateTime(2006, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rafael", "Rafael", "Tomaz", "senha" },
                    { 2, new DateTime(1977, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ye", "Kayne", "West", "senha" },
                    { 3, new DateTime(2014, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "SharkBoy", "Shark", "Boy", "senha" },
                    { 4, new DateTime(2014, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "LavaGirl", "Lava", "Girl", "senha" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Descricao", "Elemento", "IdTreinador", "Nome", "Pontos_Ataque", "Pontos_Defesa", "Pontos_Vida" },
                values: new object[] { 1, "Restaura 20 pontos de vida", null, 1, "Potion", 0, 0, 20 });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Altura_Pokemon", "Apanhado", "Codigo", "Descricao", "Elemento", "IdTreinador", "Imagem", "Max_Ataque", "Max_Defesa", "Max_Velocidade", "Max_Vida", "Min_Ataque", "Min_Defesa", "Min_Velocidade", "Min_Vida", "Nome_Pokemon", "Peso_Pokemon", "SegundoElemento" },
                values: new object[,]
                {
                    { 1, 0.7f, false, 1, "Bulbasaur is a small, mainly turquoise amphibian Pokémon with red eyes and a green bulb on its back. It is based on a frog/toad, with the bulb resembling a plant bulb that grows into a flower as it evolves.", 4, 1, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/001.png", 216, 216, 207, 290, 49, 49, 45, 45, "Bulbasaur", 6.9f, 7 },
                    { 2, 0.6f, false, 4, "Charmander is a bipedal, reptilian Pokémon. Most of its body is colored orange, while its underbelly is light yellow and it has blue eyes. It has a flame at the end of its tail, which is said to signify its health.", 2, 1, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/004.png", 223, 203, 251, 282, 52, 43, 65, 39, "Charmander", 8.5f, 0 },
                    { 3, 0.5f, false, 7, "Charmander is a bipedal, reptilian Pokémon. Most of its body is colored orange, while its underbelly is light yellow and it has blue eyes. It has a flame at the end of its tail, which is said to signify its health.", 3, 1, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/007.png", 214, 251, 203, 292, 48, 65, 43, 44, "Squirtle", 9f, 0 }
                });

            migrationBuilder.InsertData(
                table: "Evolucao",
                columns: new[] { "Id", "Altura_Evolucao", "Apanhado", "Codigo", "Descricao", "Elemento", "IdPokemon", "Imagem", "Max_Ataque", "Max_Defesa", "Max_Velocidade", "Max_Vida", "Min_Ataque", "Min_Defesa", "Min_Velocidade", "Min_Vida", "Nome_Evolcucao", "Peso_Evolucao", "SegundoElemento" },
                values: new object[,]
                {
                    { 1, 1f, false, 2, "Ivysaur's appearance is very similar to that of its pre-evolved form, Bulbasaur. It still retains the turquoise skin and spots, along with its red eyes.", 4, 1, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/002.png", 245, 247, 240, 324, 62, 63, 60, 60, "Ivysaur", 13f, 7 },
                    { 2, 2f, false, 3, "Venusaur is a large, quadrupedal Pokémon with a turquoise body. It has small red eyes and several large ferns on its back and head. The plant bulb that was on the back of its previous evolutions, Bulbasaur and Ivysaur, has now bloomed into a large flower with large pink petals and a yellow center. The female has a seed in the center.", 4, 1, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/003.png", 289, 291, 284, 364, 82, 83, 80, 80, "Venusaur", 100f, 7 },
                    { 3, 1.1f, false, 5, "When it swings its burning tail, the temperature around it rises higher and higher, tormenting its opponents.", 2, 2, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/005.png", 249, 236, 284, 320, 64, 58, 80, 58, "Charmeleon", 19f, 0 },
                    { 4, 1.7f, false, 6, "Charizard is a large dragon-like Pokémon, mainly orange in color. It has two large wings, the underside of which are turquoise. Like Charmander and Charmeleon, it has a flame at the end of its tail.", 2, 2, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/006.png", 293, 280, 328, 360, 84, 78, 100, 78, "Charizard", 90.5f, 5 },
                    { 5, 1f, false, 8, "Wartortle is a small, bipedal, turtle-like Pokémon with a similar appearance to that of its pre-evolved form, Squirtle. Some differences are that Wartortle have developed sharper and larger claws and teeth, and that their tails are larger and fluffier than those of Squirtle's.", 3, 3, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/008.png", 247, 284, 236, 322, 63, 80, 58, 59, "Wartortle", 22.5f, 0 },
                    { 6, 1.6f, false, 9, "Blastoise is a large, bipedal, reptilian Pokémon. It has a blue body with small purple eyes, a light brown belly, and a stubby tail. It has a large brown shell with two powerful water cannons on either side, which can be withdrawn.", 3, 3, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/009.png", 291, 328, 280, 362, 83, 100, 78, 79, "Blastoise", 85.5f, 0 }
                });

            migrationBuilder.InsertData(
                table: "PokemonHabilidade",
                columns: new[] { "IdHabilidade", "IdPokemon" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 2, 1 },
                    { 4, 2 },
                    { 5, 2 },
                    { 8, 3 }
                });

            migrationBuilder.InsertData(
                table: "EvolucaoHabilidade",
                columns: new[] { "IdEvolucao", "IdHabilidade" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 5, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 4 },
                    { 3, 6 },
                    { 4, 6 },
                    { 4, 7 },
                    { 6, 8 },
                    { 5, 9 },
                    { 6, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonHabilidade_IdPokemon",
                table: "PokemonHabilidade",
                column: "IdPokemon");

            migrationBuilder.CreateIndex(
                name: "IX_EvolucaoHabilidade_IdEvolucao",
                table: "EvolucaoHabilidade",
                column: "IdEvolucao");

            migrationBuilder.AddForeignKey(
                name: "FK_EvolucaoHabilidade_Evolucao_IdEvolucao",
                table: "EvolucaoHabilidade",
                column: "IdEvolucao",
                principalTable: "Evolucao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EvolucaoHabilidade_Habilidade_IdHabilidade",
                table: "EvolucaoHabilidade",
                column: "IdHabilidade",
                principalTable: "Habilidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EvolucaoHabilidade_Evolucao_IdEvolucao",
                table: "EvolucaoHabilidade");

            migrationBuilder.DropForeignKey(
                name: "FK_EvolucaoHabilidade_Habilidade_IdHabilidade",
                table: "EvolucaoHabilidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonHabilidade",
                table: "PokemonHabilidade");

            migrationBuilder.DropIndex(
                name: "IX_PokemonHabilidade_IdPokemon",
                table: "PokemonHabilidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EvolucaoHabilidade",
                table: "EvolucaoHabilidade");

            migrationBuilder.DropIndex(
                name: "IX_EvolucaoHabilidade_IdEvolucao",
                table: "EvolucaoHabilidade");

            migrationBuilder.DeleteData(
                table: "EvolucaoHabilidade",
                keyColumns: new[] { "IdEvolucao", "IdHabilidade" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "EvolucaoHabilidade",
                keyColumns: new[] { "IdEvolucao", "IdHabilidade" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "EvolucaoHabilidade",
                keyColumns: new[] { "IdEvolucao", "IdHabilidade" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "EvolucaoHabilidade",
                keyColumns: new[] { "IdEvolucao", "IdHabilidade" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "EvolucaoHabilidade",
                keyColumns: new[] { "IdEvolucao", "IdHabilidade" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "EvolucaoHabilidade",
                keyColumns: new[] { "IdEvolucao", "IdHabilidade" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "EvolucaoHabilidade",
                keyColumns: new[] { "IdEvolucao", "IdHabilidade" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "EvolucaoHabilidade",
                keyColumns: new[] { "IdEvolucao", "IdHabilidade" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "EvolucaoHabilidade",
                keyColumns: new[] { "IdEvolucao", "IdHabilidade" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "EvolucaoHabilidade",
                keyColumns: new[] { "IdEvolucao", "IdHabilidade" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "EvolucaoHabilidade",
                keyColumns: new[] { "IdEvolucao", "IdHabilidade" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "EvolucaoHabilidade",
                keyColumns: new[] { "IdEvolucao", "IdHabilidade" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PokemonHabilidade",
                keyColumns: new[] { "IdHabilidade", "IdPokemon" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PokemonHabilidade",
                keyColumns: new[] { "IdHabilidade", "IdPokemon" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "PokemonHabilidade",
                keyColumns: new[] { "IdHabilidade", "IdPokemon" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PokemonHabilidade",
                keyColumns: new[] { "IdHabilidade", "IdPokemon" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "PokemonHabilidade",
                keyColumns: new[] { "IdHabilidade", "IdPokemon" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "PokemonHabilidade",
                keyColumns: new[] { "IdHabilidade", "IdPokemon" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "Treinador",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Treinador",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Treinador",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Evolucao",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Evolucao",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Evolucao",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Evolucao",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Evolucao",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Evolucao",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Habilidade",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Habilidade",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Habilidade",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Habilidade",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Habilidade",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Habilidade",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Habilidade",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Habilidade",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Habilidade",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Treinador",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "HabilidadeId",
                table: "EvolucaoHabilidade",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonHabilidade",
                table: "PokemonHabilidade",
                column: "IdPokemon");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EvolucaoHabilidade",
                table: "EvolucaoHabilidade",
                column: "IdHabilidade");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonHabilidade_IdHabilidade",
                table: "PokemonHabilidade",
                column: "IdHabilidade");

            migrationBuilder.CreateIndex(
                name: "IX_EvolucaoHabilidade_HabilidadeId",
                table: "EvolucaoHabilidade",
                column: "HabilidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EvolucaoHabilidade_Evolucao_IdHabilidade",
                table: "EvolucaoHabilidade",
                column: "IdHabilidade",
                principalTable: "Evolucao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EvolucaoHabilidade_Habilidade_HabilidadeId",
                table: "EvolucaoHabilidade",
                column: "HabilidadeId",
                principalTable: "Habilidade",
                principalColumn: "Id");
        }
    }
}
