using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestBackend.CONTEXT.Migrations
{
    /// <inheritdoc />
    public partial class rcityid2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cityId2",
                table: "Locations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cityId2",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
