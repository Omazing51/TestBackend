using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestBackend.CONTEXT.Migrations
{
    /// <inheritdoc />
    public partial class fk_city_countryid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "countryId",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_countryId",
                table: "Cities",
                column: "countryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_countryId",
                table: "Cities",
                column: "countryId",
                principalTable: "Countries",
                principalColumn: "countryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_countryId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_countryId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "countryId",
                table: "Cities");
        }
    }
}
