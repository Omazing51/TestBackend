using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestBackend.CONTEXT.Migrations
{
    /// <inheritdoc />
    public partial class fk_booking_bookingstatusid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "bookingStatuslId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_bookingStatuslId",
                table: "Bookings",
                column: "bookingStatuslId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_BookingStatuses_bookingStatuslId",
                table: "Bookings",
                column: "bookingStatuslId",
                principalTable: "BookingStatuses",
                principalColumn: "statusId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_BookingStatuses_bookingStatuslId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_bookingStatuslId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "bookingStatuslId",
                table: "Bookings");
        }
    }
}
