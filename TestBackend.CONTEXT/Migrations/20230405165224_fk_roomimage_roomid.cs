using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestBackend.CONTEXT.Migrations
{
    /// <inheritdoc />
    public partial class fk_roomimage_roomid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "roomId",
                table: "RoomImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RoomImages_roomId",
                table: "RoomImages",
                column: "roomId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomImages_Rooms_roomId",
                table: "RoomImages",
                column: "roomId",
                principalTable: "Rooms",
                principalColumn: "roomId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomImages_Rooms_roomId",
                table: "RoomImages");

            migrationBuilder.DropIndex(
                name: "IX_RoomImages_roomId",
                table: "RoomImages");

            migrationBuilder.DropColumn(
                name: "roomId",
                table: "RoomImages");
        }
    }
}
