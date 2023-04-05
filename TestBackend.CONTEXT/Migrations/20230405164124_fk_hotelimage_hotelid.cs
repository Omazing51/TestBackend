using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestBackend.CONTEXT.Migrations
{
    /// <inheritdoc />
    public partial class fk_hotelimage_hotelid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "hotelId",
                table: "HotelImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HotelImages_hotelId",
                table: "HotelImages",
                column: "hotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelImages_Hotels_hotelId",
                table: "HotelImages",
                column: "hotelId",
                principalTable: "Hotels",
                principalColumn: "hotelId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelImages_Hotels_hotelId",
                table: "HotelImages");

            migrationBuilder.DropIndex(
                name: "IX_HotelImages_hotelId",
                table: "HotelImages");

            migrationBuilder.DropColumn(
                name: "hotelId",
                table: "HotelImages");
        }
    }
}
