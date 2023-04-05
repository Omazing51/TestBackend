using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestBackend.CONTEXT.Migrations
{
    /// <inheritdoc />
    public partial class fk_room_hotelid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "hotelId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_hotelId",
                table: "Rooms",
                column: "hotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Hotels_hotelId",
                table: "Rooms",
                column: "hotelId",
                principalTable: "Hotels",
                principalColumn: "hotelId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Hotels_hotelId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_hotelId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "hotelId",
                table: "Rooms");
        }
    }
}
