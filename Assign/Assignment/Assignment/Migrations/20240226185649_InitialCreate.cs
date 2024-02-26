using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false),
                    rentalCompanies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isAvailable = table.Column<bool>(type: "bit", nullable: false),
                    availableFrom = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "flights",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    arrival = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    depTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    arrTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    airline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false),
                    maxPassanger = table.Column<int>(type: "int", nullable: false),
                    numPassanger = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flights", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hotels",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    numRooms = table.Column<int>(type: "int", nullable: false),
                    amenities = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hotels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bookings",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    carId = table.Column<int>(type: "int", nullable: true),
                    flightId = table.Column<int>(type: "int", nullable: true),
                    hotelId = table.Column<int>(type: "int", nullable: true),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumRooms = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookings", x => x.id);
                    table.ForeignKey(
                        name: "FK_bookings_User_userId",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_bookings_cars_carId",
                        column: x => x.carId,
                        principalTable: "cars",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookings_flights_flightId",
                        column: x => x.flightId,
                        principalTable: "flights",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookings_hotels_hotelId",
                        column: x => x.hotelId,
                        principalTable: "hotels",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_bookings_userId",
                table: "bookings",
                column: "userId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookings");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "cars");

            migrationBuilder.DropTable(
                name: "flights");

            migrationBuilder.DropTable(
                name: "hotels");
        }
    }
}
