using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonReviewApp.Migrations
{
    /// <inheritdoc />
    public partial class Changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokemonCategories_Countries_CountryId",
                table: "PokemonCategories");

            migrationBuilder.DropIndex(
                name: "IX_PokemonCategories_CountryId",
                table: "PokemonCategories");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "PokemonCategories");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Owners");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "PokemonCategories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Owners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonCategories_CountryId",
                table: "PokemonCategories",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonCategories_Countries_CountryId",
                table: "PokemonCategories",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }
    }
}
