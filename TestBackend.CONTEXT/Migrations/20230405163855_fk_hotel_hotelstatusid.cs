using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestBackend.CONTEXT.Migrations
{
    /// <inheritdoc />
    public partial class fk_hotel_hotelstatusid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "hotelStatusId",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_hotelStatusId",
                table: "Hotels",
                column: "hotelStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_HotelStatuses_hotelStatusId",
                table: "Hotels",
                column: "hotelStatusId",
                principalTable: "HotelStatuses",
                principalColumn: "statusId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_HotelStatuses_hotelStatusId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_hotelStatusId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "hotelStatusId",
                table: "Hotels");
        }
    }
}
