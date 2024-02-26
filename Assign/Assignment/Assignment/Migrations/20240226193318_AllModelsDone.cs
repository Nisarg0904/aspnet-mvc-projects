using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class AllModelsDone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookings_cars_carId",
                table: "bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_bookings_flights_flightId",
                table: "bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_bookings_hotels_hotelId",
                table: "bookings");

            migrationBuilder.DropIndex(
                name: "IX_bookings_carId",
                table: "bookings");

            migrationBuilder.DropIndex(
                name: "IX_bookings_flightId",
                table: "bookings");

            migrationBuilder.DropIndex(
                name: "IX_bookings_hotelId",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "CheckInDate",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "CheckOutDate",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "NumRooms",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "carId",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "flightId",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "hotelId",
                table: "bookings");

            migrationBuilder.CreateTable(
                name: "cBookings",
                columns: table => new
                {
                    bId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carId = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    bookingid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cBookings", x => x.bId);
                    table.ForeignKey(
                        name: "FK_cBookings_bookings_bookingid",
                        column: x => x.bookingid,
                        principalTable: "bookings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cBookings_cars_carId",
                        column: x => x.carId,
                        principalTable: "cars",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "fBookings",
                columns: table => new
                {
                    bId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    flightId = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    bookingid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fBookings", x => x.bId);
                    table.ForeignKey(
                        name: "FK_fBookings_bookings_bookingid",
                        column: x => x.bookingid,
                        principalTable: "bookings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_fBookings_flights_flightId",
                        column: x => x.flightId,
                        principalTable: "flights",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hBookings",
                columns: table => new
                {
                    bId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hotelId = table.Column<int>(type: "int", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumRooms = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    bookingid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hBookings", x => x.bId);
                    table.ForeignKey(
                        name: "FK_hBookings_bookings_bookingid",
                        column: x => x.bookingid,
                        principalTable: "bookings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hBookings_hotels_hotelId",
                        column: x => x.hotelId,
                        principalTable: "hotels",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cBookings_bookingid",
                table: "cBookings",
                column: "bookingid");

            migrationBuilder.CreateIndex(
                name: "IX_cBookings_carId",
                table: "cBookings",
                column: "carId");

            migrationBuilder.CreateIndex(
                name: "IX_fBookings_bookingid",
                table: "fBookings",
                column: "bookingid");

            migrationBuilder.CreateIndex(
                name: "IX_fBookings_flightId",
                table: "fBookings",
                column: "flightId");

            migrationBuilder.CreateIndex(
                name: "IX_hBookings_bookingid",
                table: "hBookings",
                column: "bookingid");

            migrationBuilder.CreateIndex(
                name: "IX_hBookings_hotelId",
                table: "hBookings",
                column: "hotelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cBookings");

            migrationBuilder.DropTable(
                name: "fBookings");

            migrationBuilder.DropTable(
                name: "hBookings");

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckInDate",
                table: "bookings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckOutDate",
                table: "bookings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "bookings",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumRooms",
                table: "bookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "carId",
                table: "bookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "flightId",
                table: "bookings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "hotelId",
                table: "bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_bookings_carId",
                table: "bookings",
                column: "carId");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_flightId",
                table: "bookings",
                column: "flightId");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_hotelId",
                table: "bookings",
                column: "hotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_cars_carId",
                table: "bookings",
                column: "carId",
                principalTable: "cars",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_flights_flightId",
                table: "bookings",
                column: "flightId",
                principalTable: "flights",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_hotels_hotelId",
                table: "bookings",
                column: "hotelId",
                principalTable: "hotels",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
