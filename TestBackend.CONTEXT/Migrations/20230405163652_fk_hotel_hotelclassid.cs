using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestBackend.CONTEXT.Migrations
{
    /// <inheritdoc />
    public partial class fk_hotel_hotelclassid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "hotelClassId",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_hotelClassId",
                table: "Hotels",
                column: "hotelClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_HotelClasses_hotelClassId",
                table: "Hotels",
                column: "hotelClassId",
                principalTable: "HotelClasses",
                principalColumn: "hotelClassId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_HotelClasses_hotelClassId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_hotelClassId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "hotelClassId",
                table: "Hotels");
        }
    }
}
