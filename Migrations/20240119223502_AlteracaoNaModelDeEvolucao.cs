using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Api.Migrations
{
    /// <inheritdoc />
    public partial class AlteracaoNaModelDeEvolucao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pontos_Ataque",
                table: "Evolucao");

            migrationBuilder.DropColumn(
                name: "Pontos_Defesa",
                table: "Evolucao");

            migrationBuilder.DropColumn(
                name: "Pontos_Velocidade",
                table: "Evolucao");

            migrationBuilder.RenameColumn(
                name: "Pontos_Vida",
                table: "Evolucao",
                newName: "SegundoElemento");

            migrationBuilder.AddColumn<bool>(
                name: "Apanhado",
                table: "Evolucao",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Evolucao",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Evolucao",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Max_Ataque",
                table: "Evolucao",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Status maximo do ataque");

            migrationBuilder.AddColumn<int>(
                name: "Max_Defesa",
                table: "Evolucao",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Status maximo da defesa");

            migrationBuilder.AddColumn<int>(
                name: "Max_Velocidade",
                table: "Evolucao",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "status maximo da velocidade");

            migrationBuilder.AddColumn<int>(
                name: "Max_Vida",
                table: "Evolucao",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Status maximo da vida");

            migrationBuilder.AddColumn<int>(
                name: "Min_Ataque",
                table: "Evolucao",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Status base do ataque");

            migrationBuilder.AddColumn<int>(
                name: "Min_Defesa",
                table: "Evolucao",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Status base da defesa");

            migrationBuilder.AddColumn<int>(
                name: "Min_Velocidade",
                table: "Evolucao",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "status base da velocidade");

            migrationBuilder.AddColumn<int>(
                name: "Min_Vida",
                table: "Evolucao",
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
                table: "Evolucao");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Evolucao");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Evolucao");

            migrationBuilder.DropColumn(
                name: "Max_Ataque",
                table: "Evolucao");

            migrationBuilder.DropColumn(
                name: "Max_Defesa",
                table: "Evolucao");

            migrationBuilder.DropColumn(
                name: "Max_Velocidade",
                table: "Evolucao");

            migrationBuilder.DropColumn(
                name: "Max_Vida",
                table: "Evolucao");

            migrationBuilder.DropColumn(
                name: "Min_Ataque",
                table: "Evolucao");

            migrationBuilder.DropColumn(
                name: "Min_Defesa",
                table: "Evolucao");

            migrationBuilder.DropColumn(
                name: "Min_Velocidade",
                table: "Evolucao");

            migrationBuilder.DropColumn(
                name: "Min_Vida",
                table: "Evolucao");

            migrationBuilder.RenameColumn(
                name: "SegundoElemento",
                table: "Evolucao",
                newName: "Pontos_Vida");

            migrationBuilder.AddColumn<int>(
                name: "Pontos_Ataque",
                table: "Evolucao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pontos_Defesa",
                table: "Evolucao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pontos_Velocidade",
                table: "Evolucao",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
