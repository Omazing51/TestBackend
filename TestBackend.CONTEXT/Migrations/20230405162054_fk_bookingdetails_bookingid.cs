using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestBackend.CONTEXT.Migrations
{
    /// <inheritdoc />
    public partial class fk_bookingdetails_bookingid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "bookingId",
                table: "BookingDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_bookingId",
                table: "BookingDetails",
                column: "bookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingDetails_Bookings_bookingId",
                table: "BookingDetails",
                column: "bookingId",
                principalTable: "Bookings",
                principalColumn: "bookingId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingDetails_Bookings_bookingId",
                table: "BookingDetails");

            migrationBuilder.DropIndex(
                name: "IX_BookingDetails_bookingId",
                table: "BookingDetails");

            migrationBuilder.DropColumn(
                name: "bookingId",
                table: "BookingDetails");
        }
    }
}
