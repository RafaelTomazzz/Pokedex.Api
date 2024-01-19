using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Api.Migrations
{
    /// <inheritdoc />
    public partial class AlteracaoNaModelDePokemon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pontos_Ataque",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Pontos_Defesa",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Pontos_Velocidade",
                table: "Pokemon");

            migrationBuilder.RenameColumn(
                name: "Pontos_Vida",
                table: "Pokemon",
                newName: "SegundoElemento");

            migrationBuilder.AddColumn<bool>(
                name: "Apanhado",
                table: "Pokemon",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Pokemon",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Pokemon",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Max_Ataque",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Status maximo do ataque");

            migrationBuilder.AddColumn<int>(
                name: "Max_Defesa",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Status maximo da defesa");

            migrationBuilder.AddColumn<int>(
                name: "Max_Velocidade",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "status maximo da velocidade");

            migrationBuilder.AddColumn<int>(
                name: "Max_Vida",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Status maximo da vida");

            migrationBuilder.AddColumn<int>(
                name: "Min_Ataque",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Status base do ataque");

            migrationBuilder.AddColumn<int>(
                name: "Min_Defesa",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Status base da defesa");

            migrationBuilder.AddColumn<int>(
                name: "Min_Velocidade",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "status base da velocidade");

            migrationBuilder.AddColumn<int>(
                name: "Min_Vida",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Status base da vida");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apanhado",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Max_Ataque",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Max_Defesa",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Max_Velocidade",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Max_Vida",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Min_Ataque",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Min_Defesa",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Min_Velocidade",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Min_Vida",
                table: "Pokemon");

            migrationBuilder.RenameColumn(
                name: "SegundoElemento",
                table: "Pokemon",
                newName: "Pontos_Vida");

            migrationBuilder.AddColumn<int>(
                name: "Pontos_Ataque",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pontos_Defesa",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pontos_Velocidade",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
