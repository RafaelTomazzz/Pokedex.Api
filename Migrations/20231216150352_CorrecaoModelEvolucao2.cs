using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Api.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoModelEvolucao2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Peso_Pokemon",
                table: "Evolucao",
                newName: "Peso_Evolucao");

            migrationBuilder.AlterColumn<float>(
                name: "Peso_Evolucao",
                table: "Evolucao",
                type: "real",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AddColumn<float>(
                name: "Altura_Evolucao",
                table: "Evolucao",
                type: "real",
                maxLength: 3,
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Altura_Evolucao",
                table: "Evolucao");

            migrationBuilder.RenameColumn(
                name: "Peso_Evolucao",
                table: "Evolucao",
                newName: "Peso_Pokemon");

            migrationBuilder.AlterColumn<string>(
                name: "Peso_Pokemon",
                table: "Evolucao",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real",
                oldMaxLength: 3);
        }
    }
}
