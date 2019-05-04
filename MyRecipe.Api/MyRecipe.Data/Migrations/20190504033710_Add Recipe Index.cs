using Microsoft.EntityFrameworkCore.Migrations;

namespace MyRecipe.Data.Migrations
{
    public partial class AddRecipeIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IDX_Recipe_Name",
                table: "Recipe",
                column: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IDX_Recipe_Name",
                table: "Recipe");
        }
    }
}
