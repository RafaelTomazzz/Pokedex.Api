using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pokedex.Api.Migrations
{
    /// <inheritdoc />
    public partial class AdionandoAtenticacaoPorToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habilidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Habilidade = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Elemento = table.Column<int>(type: "int", nullable: false),
                    Power = table.Column<int>(type: "int", nullable: false),
                    Pontos_Precisao = table.Column<int>(type: "int", nullable: false),
                    Pontos_Power = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Pontos_Vida = table.Column<int>(type: "int", nullable: false),
                    Pontos_Defesa = table.Column<int>(type: "int", nullable: false),
                    Pontos_Ataque = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Elemento = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Pokemon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Peso_Pokemon = table.Column<float>(type: "real", nullable: false),
                    Altura_Pokemon = table.Column<float>(type: "real", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Min_Vida = table.Column<int>(type: "int", nullable: false, comment: "Status base da vida"),
                    Max_Vida = table.Column<int>(type: "int", nullable: false, comment: "Status maximo da vida"),
                    Min_Ataque = table.Column<int>(type: "int", nullable: false, comment: "Status base do ataque"),
                    Max_Ataque = table.Column<int>(type: "int", nullable: false, comment: "Status maximo do ataque"),
                    Min_Defesa = table.Column<int>(type: "int", nullable: false, comment: "Status base da defesa"),
                    Max_Defesa = table.Column<int>(type: "int", nullable: false, comment: "Status maximo da defesa"),
                    Min_Velocidade = table.Column<int>(type: "int", nullable: false, comment: "status base da velocidade"),
                    Max_Velocidade = table.Column<int>(type: "int", nullable: false, comment: "status maximo da velocidade"),
                    Elemento = table.Column<int>(type: "int", nullable: false),
                    SegundoElemento = table.Column<int>(type: "int", nullable: false),
                    Apanhado = table.Column<bool>(type: "bit", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Treinador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Primeiro_Nome = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Segundo_Nome = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Data_Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treinador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Evolucao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPokemon = table.Column<int>(type: "int", nullable: false),
                    Nome_Evolcucao = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Peso_Evolucao = table.Column<float>(type: "real", maxLength: 3, nullable: false),
                    Altura_Evolucao = table.Column<float>(type: "real", maxLength: 3, nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Min_Vida = table.Column<int>(type: "int", nullable: false, comment: "Status base da vida"),
                    Max_Vida = table.Column<int>(type: "int", nullable: false, comment: "Status maximo da vida"),
                    Min_Ataque = table.Column<int>(type: "int", nullable: false, comment: "Status base do ataque"),
                    Max_Ataque = table.Column<int>(type: "int", nullable: false, comment: "Status maximo do ataque"),
                    Min_Defesa = table.Column<int>(type: "int", nullable: false, comment: "Status base da defesa"),
                    Max_Defesa = table.Column<int>(type: "int", nullable: false, comment: "Status maximo da defesa"),
                    Min_Velocidade = table.Column<int>(type: "int", nullable: false, comment: "status base da velocidade"),
                    Max_Velocidade = table.Column<int>(type: "int", nullable: false, comment: "status maximo da velocidade"),
                    Elemento = table.Column<int>(type: "int", nullable: false),
                    SegundoElemento = table.Column<int>(type: "int", nullable: false),
                    Apanhado = table.Column<bool>(type: "bit", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evolucao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evolucao_Pokemon_IdPokemon",
                        column: x => x.IdPokemon,
                        principalTable: "Pokemon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonHabilidade",
                columns: table => new
                {
                    IdHabilidade = table.Column<int>(type: "int", nullable: false),
                    IdPokemon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonHabilidade", x => new { x.IdHabilidade, x.IdPokemon });
                    table.ForeignKey(
                        name: "FK_PokemonHabilidade_Habilidade_IdHabilidade",
                        column: x => x.IdHabilidade,
                        principalTable: "Habilidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonHabilidade_Pokemon_IdPokemon",
                        column: x => x.IdPokemon,
                        principalTable: "Pokemon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemTreinador",
                columns: table => new
                {
                    IdItem = table.Column<int>(type: "int", nullable: false),
                    IdTreinador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTreinador", x => new { x.IdItem, x.IdTreinador });
                    table.ForeignKey(
                        name: "FK_ItemTreinador_Item_IdItem",
                        column: x => x.IdItem,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemTreinador_Treinador_IdTreinador",
                        column: x => x.IdTreinador,
                        principalTable: "Treinador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonTreinador",
                columns: table => new
                {
                    IdPokemon = table.Column<int>(type: "int", nullable: false),
                    IdTreinador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTreinador", x => new { x.IdTreinador, x.IdPokemon });
                    table.ForeignKey(
                        name: "FK_PokemonTreinador_Pokemon_IdPokemon",
                        column: x => x.IdPokemon,
                        principalTable: "Pokemon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonTreinador_Treinador_IdTreinador",
                        column: x => x.IdTreinador,
                        principalTable: "Treinador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvolucaoHabilidade",
                columns: table => new
                {
                    IdHabilidade = table.Column<int>(type: "int", nullable: false),
                    IdEvolucao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvolucaoHabilidade", x => new { x.IdHabilidade, x.IdEvolucao });
                    table.ForeignKey(
                        name: "FK_EvolucaoHabilidade_Evolucao_IdEvolucao",
                        column: x => x.IdEvolucao,
                        principalTable: "Evolucao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EvolucaoHabilidade_Habilidade_IdHabilidade",
                        column: x => x.IdHabilidade,
                        principalTable: "Habilidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvolucaoTreinador",
                columns: table => new
                {
                    IdEvolucao = table.Column<int>(type: "int", nullable: false),
                    IdTreinador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvolucaoTreinador", x => new { x.IdEvolucao, x.IdTreinador });
                    table.ForeignKey(
                        name: "FK_EvolucaoTreinador_Evolucao_IdEvolucao",
                        column: x => x.IdEvolucao,
                        principalTable: "Evolucao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EvolucaoTreinador_Treinador_IdTreinador",
                        column: x => x.IdTreinador,
                        principalTable: "Treinador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Item",
                columns: new[] { "Id", "Descricao", "Elemento", "Nome", "Pontos_Ataque", "Pontos_Defesa", "Pontos_Vida" },
                values: new object[] { 1, "Restaura 20 pontos de vida", null, "Potion", 0, 0, 20 });

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Altura_Pokemon", "Apanhado", "Codigo", "Descricao", "Elemento", "Imagem", "Max_Ataque", "Max_Defesa", "Max_Velocidade", "Max_Vida", "Min_Ataque", "Min_Defesa", "Min_Velocidade", "Min_Vida", "Nome_Pokemon", "Peso_Pokemon", "SegundoElemento" },
                values: new object[,]
                {
                    { 1, 0.7f, false, 1, "Bulbasaur is a small, mainly turquoise amphibian Pokémon with red eyes and a green bulb on its back. It is based on a frog/toad, with the bulb resembling a plant bulb that grows into a flower as it evolves.", 4, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/001.png", 216, 216, 207, 290, 49, 49, 45, 45, "Bulbasaur", 6.9f, 7 },
                    { 2, 0.6f, false, 4, "Charmander is a bipedal, reptilian Pokémon. Most of its body is colored orange, while its underbelly is light yellow and it has blue eyes. It has a flame at the end of its tail, which is said to signify its health.", 2, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/004.png", 223, 203, 251, 282, 52, 43, 65, 39, "Charmander", 8.5f, 0 },
                    { 3, 0.5f, false, 7, "Charmander is a bipedal, reptilian Pokémon. Most of its body is colored orange, while its underbelly is light yellow and it has blue eyes. It has a flame at the end of its tail, which is said to signify its health.", 3, "https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/007.png", 214, 251, 203, 292, 48, 65, 43, 44, "Squirtle", 9f, 0 }
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
                table: "ItemTreinador",
                columns: new[] { "IdItem", "IdTreinador" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 }
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
                table: "PokemonTreinador",
                columns: new[] { "IdPokemon", "IdTreinador" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 1, 2 },
                    { 3, 3 },
                    { 2, 4 }
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

            migrationBuilder.InsertData(
                table: "EvolucaoTreinador",
                columns: new[] { "IdEvolucao", "IdTreinador" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 3, 1 },
                    { 3, 4 },
                    { 4, 1 },
                    { 5, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evolucao_IdPokemon",
                table: "Evolucao",
                column: "IdPokemon");

            migrationBuilder.CreateIndex(
                name: "IX_EvolucaoHabilidade_IdEvolucao",
                table: "EvolucaoHabilidade",
                column: "IdEvolucao");

            migrationBuilder.CreateIndex(
                name: "IX_EvolucaoTreinador_IdTreinador",
                table: "EvolucaoTreinador",
                column: "IdTreinador");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTreinador_IdTreinador",
                table: "ItemTreinador",
                column: "IdTreinador");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonHabilidade_IdPokemon",
                table: "PokemonHabilidade",
                column: "IdPokemon");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTreinador_IdPokemon",
                table: "PokemonTreinador",
                column: "IdPokemon");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EvolucaoHabilidade");

            migrationBuilder.DropTable(
                name: "EvolucaoTreinador");

            migrationBuilder.DropTable(
                name: "ItemTreinador");

            migrationBuilder.DropTable(
                name: "PokemonHabilidade");

            migrationBuilder.DropTable(
                name: "PokemonTreinador");

            migrationBuilder.DropTable(
                name: "Evolucao");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Habilidade");

            migrationBuilder.DropTable(
                name: "Treinador");

            migrationBuilder.DropTable(
                name: "Pokemon");
        }
    }
}
