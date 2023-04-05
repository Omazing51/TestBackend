using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestBackend.CONTEXT.Migrations
{
    /// <inheritdoc />
    public partial class fk_room_roomstatusid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "roomStatusId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_roomStatusId",
                table: "Rooms",
                column: "roomStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomStatuses_roomStatusId",
                table: "Rooms",
                column: "roomStatusId",
                principalTable: "RoomStatuses",
                principalColumn: "statusId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomStatuses_roomStatusId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_roomStatusId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "roomStatusId",
                table: "Rooms");
        }
    }
}
