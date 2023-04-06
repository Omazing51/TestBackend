using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestBackend.CONTEXT.Migrations
{
    /// <inheritdoc />
    public partial class keys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RoomBookings_roomId",
                table: "RoomBookings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomBookings",
                table: "RoomBookings",
                columns: new[] { "roomId", "bookingId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomBookings",
                table: "RoomBookings");

            migrationBuilder.CreateIndex(
                name: "IX_RoomBookings_roomId",
                table: "RoomBookings",
                column: "roomId");
        }
    }
}
