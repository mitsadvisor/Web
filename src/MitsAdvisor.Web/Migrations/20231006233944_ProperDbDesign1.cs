using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MitsAdvisor.Web.Migrations
{
    /// <inheritdoc />
    public partial class ProperDbDesign1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_Restaurants_RestaurantId1",
                table: "MenuItems");

            migrationBuilder.DropIndex(
                name: "IX_MenuItems_RestaurantId1",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "RestaurantId1",
                table: "MenuItems");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RestaurantId1",
                table: "MenuItems",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_RestaurantId1",
                table: "MenuItems",
                column: "RestaurantId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_Restaurants_RestaurantId1",
                table: "MenuItems",
                column: "RestaurantId1",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
