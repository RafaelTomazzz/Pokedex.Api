using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Api.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoEvolucaoHabilidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EvolucaoHabilidade",
                columns: table => new
                {
                    IdHabilidade = table.Column<int>(type: "int", nullable: false),
                    IdEvolucao = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvolucaoHabilidade", x => x.IdHabilidade);
                    table.ForeignKey(
                        name: "FK_EvolucaoHabilidade_Evolucao_IdHabilidade",
                        column: x => x.IdHabilidade,
                        principalTable: "Evolucao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EvolucaoHabilidade_Habilidade_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "Habilidade",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EvolucaoHabilidade_HabilidadeId",
                table: "EvolucaoHabilidade",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EvolucaoHabilidade");
        }
    }
}
