using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class addChildBookingModels : Migration
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
                name: "carId",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "flightId",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "hotelId",
                table: "bookings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_flights_flightId",
                table: "bookings",
                column: "flightId",
                principalTable: "flights",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_hotels_hotelId",
                table: "bookings",
                column: "hotelId",
                principalTable: "hotels",
                principalColumn: "id");
        }
    }
}
