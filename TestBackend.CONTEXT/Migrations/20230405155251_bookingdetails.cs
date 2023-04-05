using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestBackend.CONTEXT.Migrations
{
    /// <inheritdoc />
    public partial class bookingdetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookingDetails",
                columns: table => new
                {
                    bookingDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identificationType = table.Column<int>(type: "int", nullable: false),
                    identificationUser = table.Column<int>(type: "int", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    secondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    secondLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    birthDayUser = table.Column<DateTime>(type: "datetime2", nullable: false),
                    emailUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumberUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumberContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    startBooking = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endBooking = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingDetails", x => x.bookingDetailId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingDetails");
        }
    }
}
