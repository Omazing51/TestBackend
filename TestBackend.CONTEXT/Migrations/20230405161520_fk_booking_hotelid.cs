using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestBackend.CONTEXT.Migrations
{
    /// <inheritdoc />
    public partial class fk_booking_hotelid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "hotelId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_hotelId",
                table: "Bookings",
                column: "hotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Hotels_hotelId",
                table: "Bookings",
                column: "hotelId",
                principalTable: "Hotels",
                principalColumn: "hotelId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Hotels_hotelId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_hotelId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "hotelId",
                table: "Bookings");
        }
    }
}
