using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class addingRawDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Identity",
                table: "cars",
                columns: new[] { "id", "availableFrom", "isAvailable", "location", "model", "price", "rentalCompanies", "type" },
                values: new object[] { 1, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Toronto", "Kawasaki Ninja", 150.0, "BikeGo", "Sports Bike" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "flights",
                columns: new[] { "id", "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { 1, "Emirates", new DateTime(2024, 4, 25, 7, 20, 0, 0, DateTimeKind.Unspecified), "DXB", new DateTime(2024, 4, 24, 18, 30, 0, 0, DateTimeKind.Unspecified), "YYZ", 276, 30, 700.0 });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "hotels",
                columns: new[] { "id", "amenities", "city", "location", "name", "numRooms", "price" },
                values: new object[] { 1, "Heater, Balcony, TV, Free Breakfast", "Toronto", "219 Dundas St. East, Toronto, ON M5A 0V1", "Rolex Hotel", 30, 120.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
