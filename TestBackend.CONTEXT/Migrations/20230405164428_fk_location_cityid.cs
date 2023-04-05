using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestBackend.CONTEXT.Migrations
{
    /// <inheritdoc />
    public partial class fk_location_cityid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cityId",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_cityId",
                table: "Locations",
                column: "cityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Cities_cityId",
                table: "Locations",
                column: "cityId",
                principalTable: "Cities",
                principalColumn: "cityId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Cities_cityId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_cityId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "cityId",
                table: "Locations");
        }
    }
}
