using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
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
                    Descricao = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Pontos_Vida = table.Column<int>(type: "int", nullable: false),
                    Pontos_Defesa = table.Column<int>(type: "int", nullable: false),
                    Pontos_Ataque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidade", x => x.Id);
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
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTreinador = table.Column<int>(type: "int", nullable: false),
                    Pontos_Vida = table.Column<int>(type: "int", nullable: false),
                    Pontos_Defesa = table.Column<int>(type: "int", nullable: false),
                    Pontos_Ataque = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Elemento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Treinador_IdTreinador",
                        column: x => x.IdTreinador,
                        principalTable: "Treinador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Pokemon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Peso_Pokemon = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    IdTreinador = table.Column<int>(type: "int", nullable: false),
                    Pontos_Vida = table.Column<int>(type: "int", nullable: false),
                    Pontos_Ataque = table.Column<int>(type: "int", nullable: false),
                    Pontos_Defesa = table.Column<int>(type: "int", nullable: false),
                    Elemento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemon_Treinador_IdTreinador",
                        column: x => x.IdTreinador,
                        principalTable: "Treinador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evolucao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPokemon = table.Column<int>(type: "int", nullable: false),
                    Nome_Pokemon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Peso_Pokemon = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    IdTreinador = table.Column<int>(type: "int", nullable: false),
                    Pontos_Vida = table.Column<int>(type: "int", nullable: false),
                    Pontos_Ataque = table.Column<int>(type: "int", nullable: false),
                    Pontos_Defesa = table.Column<int>(type: "int", nullable: false),
                    Elemento = table.Column<int>(type: "int", nullable: false)
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
                    IdPokemon = table.Column<int>(type: "int", nullable: false),
                    IdHabilidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonHabilidade", x => x.IdPokemon);
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

            migrationBuilder.CreateIndex(
                name: "IX_Evolucao_IdPokemon",
                table: "Evolucao",
                column: "IdPokemon");

            migrationBuilder.CreateIndex(
                name: "IX_Item_IdTreinador",
                table: "Item",
                column: "IdTreinador");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_IdTreinador",
                table: "Pokemon",
                column: "IdTreinador");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonHabilidade_IdHabilidade",
                table: "PokemonHabilidade",
                column: "IdHabilidade");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evolucao");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "PokemonHabilidade");

            migrationBuilder.DropTable(
                name: "Habilidade");

            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "Treinador");
        }
    }
}
