using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestBackend.CONTEXT.Migrations
{
    /// <inheritdoc />
    public partial class fk_hotel_locationid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "locationId",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_locationId",
                table: "Hotels",
                column: "locationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Locations_locationId",
                table: "Hotels",
                column: "locationId",
                principalTable: "Locations",
                principalColumn: "locationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Locations_locationId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_locationId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "locationId",
                table: "Hotels");
        }
    }
}
