using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestBackend.CONTEXT.Migrations
{
    /// <inheritdoc />
    public partial class fk_room_roomtypelid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "roomTypeId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_roomTypeId",
                table: "Rooms",
                column: "roomTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomTypes_roomTypeId",
                table: "Rooms",
                column: "roomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "typeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomTypes_roomTypeId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_roomTypeId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "roomTypeId",
                table: "Rooms");
        }
    }
}
