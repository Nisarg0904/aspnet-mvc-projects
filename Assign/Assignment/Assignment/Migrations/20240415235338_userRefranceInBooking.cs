using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class userRefranceInBooking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userId",
                schema: "Identity",
                table: "bookings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "availableFrom", "isAvailable", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "New York", "Toyota Camry", 51.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los Angeles", "Chevrolet Malibu", 238.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "availableFrom", "isAvailable", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Dallas", "Ford Fusion", 265.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "availableFrom", "isAvailable", "location", "model" },
                values: new object[] { new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Houston", "Honda Accord" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Diego", "Honda Accord", 169.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York", "Ford Fusion", 295.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "availableFrom", "isAvailable", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Los Angeles", "Honda Civic", 95.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houston", "Chevrolet Malibu", 160.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York", "Honda Accord", 57.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "availableFrom", "location", "price" },
                values: new object[] { new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phoenix", 88.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "availableFrom", "isAvailable", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Chicago", "Kia Forte", 240.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Antonio", "Toyota Camry", 128.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Diego", "Honda Civic", 291.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "availableFrom", "isAvailable", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Dallas", "Chevrolet Malibu", 90.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houston", "Hyundai Elantra", 77.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicago", "Toyota Corolla", 100.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Diego", "Kia Forte", 154.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "availableFrom", "location", "price" },
                values: new object[] { new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicago", 210.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "availableFrom", "isAvailable", "location", "price" },
                values: new object[] { new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Los Angeles", 263.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "availableFrom", "isAvailable", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "San Jose", "Hyundai Elantra", 254.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "British Airways", new DateTime(2024, 4, 17, 8, 56, 35, 939, DateTimeKind.Local).AddTicks(4376), "CAN", new DateTime(2024, 5, 5, 4, 3, 35, 939, DateTimeKind.Local).AddTicks(4239), "YYZ", 285, 58, 1396.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Air Canada", new DateTime(2024, 4, 24, 3, 51, 35, 939, DateTimeKind.Local).AddTicks(4438), "FRA", new DateTime(2024, 5, 4, 4, 31, 35, 939, DateTimeKind.Local).AddTicks(4434), 318, 26, 1246.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Cathay Pacific", new DateTime(2024, 5, 4, 8, 36, 35, 939, DateTimeKind.Local).AddTicks(4485), "CDG", new DateTime(2024, 5, 11, 23, 33, 35, 939, DateTimeKind.Local).AddTicks(4481), 230, 184, 1064.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Cathay Pacific", new DateTime(2024, 5, 6, 22, 58, 35, 939, DateTimeKind.Local).AddTicks(4537), "FRA", new DateTime(2024, 5, 7, 17, 33, 35, 939, DateTimeKind.Local).AddTicks(4532), "PEK", 426, 149, 1263.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "airline", "arrTime", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Cathay Pacific", new DateTime(2024, 4, 30, 3, 47, 35, 939, DateTimeKind.Local).AddTicks(4596), new DateTime(2024, 5, 6, 11, 41, 35, 939, DateTimeKind.Local).AddTicks(4591), "YYZ", 252, 107, 813.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { new DateTime(2024, 5, 2, 1, 40, 35, 939, DateTimeKind.Local).AddTicks(4644), "LHR", new DateTime(2024, 4, 21, 12, 59, 35, 939, DateTimeKind.Local).AddTicks(4639), "DFW", 366, 28, 1241.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Singapore Airlines", new DateTime(2024, 4, 17, 3, 3, 35, 939, DateTimeKind.Local).AddTicks(4694), "HKG", new DateTime(2024, 5, 15, 2, 11, 35, 939, DateTimeKind.Local).AddTicks(4689), "YYZ", 203, 177, 834.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Emirates", new DateTime(2024, 5, 8, 1, 20, 35, 939, DateTimeKind.Local).AddTicks(4741), "LHR", new DateTime(2024, 5, 14, 6, 32, 35, 939, DateTimeKind.Local).AddTicks(4736), "SFO", 396, 48, 1324.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "American Airlines", new DateTime(2024, 5, 11, 18, 9, 35, 939, DateTimeKind.Local).AddTicks(4796), "LHR", new DateTime(2024, 4, 21, 5, 5, 35, 939, DateTimeKind.Local).AddTicks(4791), 404, 10, 1102.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "American Airlines", new DateTime(2024, 5, 8, 4, 44, 35, 939, DateTimeKind.Local).AddTicks(4845), "JFK", new DateTime(2024, 4, 27, 9, 31, 35, 939, DateTimeKind.Local).AddTicks(4839), "DFW", 476, 189, 715.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "British Airways", new DateTime(2024, 5, 5, 22, 56, 35, 939, DateTimeKind.Local).AddTicks(5263), "DXB", new DateTime(2024, 5, 2, 2, 8, 35, 939, DateTimeKind.Local).AddTicks(5257), "SFO", 292, 118, 447.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "airline", "arrTime", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "United Airlines", new DateTime(2024, 4, 24, 4, 12, 35, 939, DateTimeKind.Local).AddTicks(5325), new DateTime(2024, 5, 7, 23, 25, 35, 939, DateTimeKind.Local).AddTicks(5320), "JFK", 222, 175, 1125.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Air Canada", new DateTime(2024, 5, 3, 17, 44, 35, 939, DateTimeKind.Local).AddTicks(5376), "CDG", new DateTime(2024, 5, 14, 14, 2, 35, 939, DateTimeKind.Local).AddTicks(5370), "HND", 439, 10, 1240.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "British Airways", new DateTime(2024, 5, 3, 16, 30, 35, 939, DateTimeKind.Local).AddTicks(5428), "CDG", new DateTime(2024, 5, 7, 12, 13, 35, 939, DateTimeKind.Local).AddTicks(5423), 280, 106, 633.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { new DateTime(2024, 4, 22, 8, 56, 35, 939, DateTimeKind.Local).AddTicks(5479), "AMS", new DateTime(2024, 4, 23, 2, 37, 35, 939, DateTimeKind.Local).AddTicks(5474), "ATL", 266, 166, 1398.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "American Airlines", new DateTime(2024, 4, 30, 14, 23, 35, 939, DateTimeKind.Local).AddTicks(5529), "CAN", new DateTime(2024, 4, 23, 8, 25, 35, 939, DateTimeKind.Local).AddTicks(5524), "SFO", 359, 56, 1434.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Air Canada", new DateTime(2024, 4, 28, 9, 26, 35, 939, DateTimeKind.Local).AddTicks(5584), "CDG", new DateTime(2024, 5, 10, 14, 7, 35, 939, DateTimeKind.Local).AddTicks(5579), "YYZ", 340, 54, 764.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "British Airways", new DateTime(2024, 4, 30, 12, 48, 35, 939, DateTimeKind.Local).AddTicks(5633), "FRA", new DateTime(2024, 5, 6, 5, 58, 35, 939, DateTimeKind.Local).AddTicks(5629), "LHR", 249, 157, 874.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Cathay Pacific", new DateTime(2024, 5, 15, 11, 9, 35, 939, DateTimeKind.Local).AddTicks(5682), "CDG", new DateTime(2024, 4, 30, 1, 24, 35, 939, DateTimeKind.Local).AddTicks(5677), "LHR", 356, 122, 612.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "American Airlines", new DateTime(2024, 4, 29, 14, 33, 35, 939, DateTimeKind.Local).AddTicks(5731), "LHR", new DateTime(2024, 4, 28, 23, 26, 35, 939, DateTimeKind.Local).AddTicks(5726), "PEK", 475, 78, 682.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Philadelphia", "572 Hilton St., San Diego, 99966", "Ritz-Carlton", 38, 213.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "San Diego", "37 Hyatt St., Phoenix, 51555", "Hilton", 94, 282.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Chicago", "629 Holiday Inn St., Dallas, 25832", "Hilton", 63, 110.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "city", "location", "numRooms", "price" },
                values: new object[] { "Houston", "367 Ritz-Carlton St., San Diego, 12517", 70, 219.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Philadelphia", "632 Marriott St., Houston, 39365", "Hilton", 20, 294.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "location", "numRooms", "price" },
                values: new object[] { "307 Holiday Inn St., Los Angeles, 34235", 23, 262.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Dallas", "508 Marriott St., San Antonio, 87381", "InterContinental", 90, 93.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Dallas", "434 Sheraton St., San Antonio, 68563", "Marriott", 58, 137.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Chicago", "886 Sheraton St., Los Angeles, 49238", "Holiday Inn", 52, 225.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Houston", "530 Marriott St., Los Angeles, 94395", "Hilton", 24, 213.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Philadelphia", "742 Ritz-Carlton St., Chicago, 11408", "Hyatt", 29, 136.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Phoenix", "869 Four Seasons St., Philadelphia, 21556", "Sheraton", 97, 271.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Philadelphia", "186 InterContinental St., San Jose, 62516", "InterContinental", 42, 200.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Dallas", "667 InterContinental St., San Diego, 73390", "Hilton", 49, 244.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "location", "name", "numRooms", "price" },
                values: new object[] { "651 Hilton St., Los Angeles, 99881", "Marriott", 36, 160.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "San Antonio", "282 Four Seasons St., Phoenix, 40497", "Ritz-Carlton", 53, 183.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Dallas", "518 Hilton St., Philadelphia, 85133", "Radisson", 65, 249.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "San Jose", "374 Hyatt St., San Jose, 19327", "Radisson", 86, 153.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Dallas", "341 Hyatt St., San Diego, 29494", "Radisson", 85, 105.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "San Antonio", "704 Ritz-Carlton St., Los Angeles, 88717", "Wyndham", 27, 231.0 });

            migrationBuilder.CreateIndex(
                name: "IX_bookings_userId",
                schema: "Identity",
                table: "bookings",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_User_userId",
                schema: "Identity",
                table: "bookings",
                column: "userId",
                principalSchema: "Identity",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookings_User_userId",
                schema: "Identity",
                table: "bookings");

            migrationBuilder.DropIndex(
                name: "IX_bookings_userId",
                schema: "Identity",
                table: "bookings");

            migrationBuilder.DropColumn(
                name: "userId",
                schema: "Identity",
                table: "bookings");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "availableFrom", "isAvailable", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Dallas", "Honda Accord", 168.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicago", "Hyundai Elantra", 66.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "availableFrom", "isAvailable", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "San Diego", "Nissan Altima", 270.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "availableFrom", "isAvailable", "location", "model" },
                values: new object[] { new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "San Diego", "Hyundai Elantra" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phoenix", "Ford Fusion", 150.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicago", "Toyota Camry", 90.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "availableFrom", "isAvailable", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Philadelphia", "Nissan Altima", 278.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dallas", "Nissan Altima", 266.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houston", "Ford Fusion", 91.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "availableFrom", "location", "price" },
                values: new object[] { new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houston", 190.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "availableFrom", "isAvailable", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Houston", "Hyundai Elantra", 78.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dallas", "Honda Accord", 290.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Jose", "Hyundai Elantra", 214.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "availableFrom", "isAvailable", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "San Diego", "Nissan Altima", 112.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York", "Honda Accord", 219.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los Angeles", "Ford Fusion", 256.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "availableFrom", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houston", "Volkswagen Jetta", 211.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "availableFrom", "location", "price" },
                values: new object[] { new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phoenix", 189.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "availableFrom", "isAvailable", "location", "price" },
                values: new object[] { new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Chicago", 177.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "availableFrom", "isAvailable", "location", "model", "price" },
                values: new object[] { new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "San Diego", "Nissan Altima", 127.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Air Canada", new DateTime(2024, 4, 18, 17, 28, 52, 31, DateTimeKind.Local).AddTicks(520), "SIN", new DateTime(2024, 5, 3, 0, 42, 52, 31, DateTimeKind.Local).AddTicks(292), "LHR", 456, 153, 340.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Singapore Airlines", new DateTime(2024, 4, 28, 12, 46, 52, 31, DateTimeKind.Local).AddTicks(583), "LHR", new DateTime(2024, 4, 27, 23, 14, 52, 31, DateTimeKind.Local).AddTicks(578), 367, 22, 401.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Singapore Airlines", new DateTime(2024, 5, 2, 13, 54, 52, 31, DateTimeKind.Local).AddTicks(637), "CAN", new DateTime(2024, 5, 7, 17, 58, 52, 31, DateTimeKind.Local).AddTicks(633), 209, 115, 1240.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Singapore Airlines", new DateTime(2024, 5, 10, 21, 58, 52, 31, DateTimeKind.Local).AddTicks(691), "JFK", new DateTime(2024, 5, 11, 9, 11, 52, 31, DateTimeKind.Local).AddTicks(685), "YYZ", 438, 36, 780.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "airline", "arrTime", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Lufthansa", new DateTime(2024, 5, 12, 18, 6, 52, 31, DateTimeKind.Local).AddTicks(745), new DateTime(2024, 5, 13, 4, 36, 52, 31, DateTimeKind.Local).AddTicks(741), "DFW", 465, 101, 964.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { new DateTime(2024, 4, 19, 15, 36, 52, 31, DateTimeKind.Local).AddTicks(792), "HKG", new DateTime(2024, 4, 21, 9, 49, 52, 31, DateTimeKind.Local).AddTicks(788), "PEK", 261, 70, 1213.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "United Airlines", new DateTime(2024, 4, 27, 12, 56, 52, 31, DateTimeKind.Local).AddTicks(842), "LHR", new DateTime(2024, 5, 3, 12, 34, 52, 31, DateTimeKind.Local).AddTicks(838), "CDG", 378, 109, 1276.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "British Airways", new DateTime(2024, 5, 11, 5, 49, 52, 31, DateTimeKind.Local).AddTicks(892), "AMS", new DateTime(2024, 5, 7, 16, 15, 52, 31, DateTimeKind.Local).AddTicks(887), "DFW", 212, 165, 551.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Lufthansa", new DateTime(2024, 5, 1, 21, 56, 52, 31, DateTimeKind.Local).AddTicks(942), "SIN", new DateTime(2024, 5, 1, 19, 2, 52, 31, DateTimeKind.Local).AddTicks(938), 342, 68, 315.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Air Canada", new DateTime(2024, 4, 19, 8, 38, 52, 31, DateTimeKind.Local).AddTicks(989), "LHR", new DateTime(2024, 4, 24, 22, 39, 52, 31, DateTimeKind.Local).AddTicks(984), "HND", 315, 48, 884.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Qantas", new DateTime(2024, 5, 2, 12, 41, 52, 31, DateTimeKind.Local).AddTicks(1036), "ICN", new DateTime(2024, 5, 3, 13, 16, 52, 31, DateTimeKind.Local).AddTicks(1032), "DFW", 325, 94, 1460.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "airline", "arrTime", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Cathay Pacific", new DateTime(2024, 5, 8, 20, 28, 52, 31, DateTimeKind.Local).AddTicks(1089), new DateTime(2024, 4, 21, 15, 20, 52, 31, DateTimeKind.Local).AddTicks(1084), "DFW", 406, 60, 363.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Qantas", new DateTime(2024, 4, 17, 9, 43, 52, 31, DateTimeKind.Local).AddTicks(1138), "LHR", new DateTime(2024, 5, 2, 19, 30, 52, 31, DateTimeKind.Local).AddTicks(1134), "LHR", 217, 110, 658.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Delta Air Lines", new DateTime(2024, 5, 10, 20, 3, 52, 31, DateTimeKind.Local).AddTicks(1189), "SIN", new DateTime(2024, 5, 7, 18, 4, 52, 31, DateTimeKind.Local).AddTicks(1184), 494, 151, 1049.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { new DateTime(2024, 4, 22, 14, 24, 52, 31, DateTimeKind.Local).AddTicks(1239), "SIN", new DateTime(2024, 4, 18, 8, 14, 52, 31, DateTimeKind.Local).AddTicks(1234), "YYZ", 308, 157, 435.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Cathay Pacific", new DateTime(2024, 5, 7, 3, 19, 52, 31, DateTimeKind.Local).AddTicks(1285), "SIN", new DateTime(2024, 4, 26, 23, 19, 52, 31, DateTimeKind.Local).AddTicks(1280), "JFK", 210, 17, 1201.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "American Airlines", new DateTime(2024, 4, 27, 6, 57, 52, 31, DateTimeKind.Local).AddTicks(1338), "CAN", new DateTime(2024, 4, 29, 6, 33, 52, 31, DateTimeKind.Local).AddTicks(1333), "CDG", 217, 94, 613.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "United Airlines", new DateTime(2024, 5, 12, 14, 54, 52, 31, DateTimeKind.Local).AddTicks(1387), "CAN", new DateTime(2024, 4, 21, 1, 6, 52, 31, DateTimeKind.Local).AddTicks(1382), "HND", 334, 88, 352.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Singapore Airlines", new DateTime(2024, 4, 29, 10, 14, 52, 31, DateTimeKind.Local).AddTicks(1438), "DXB", new DateTime(2024, 5, 5, 4, 47, 52, 31, DateTimeKind.Local).AddTicks(1434), "DFW", 304, 176, 678.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[] { "Cathay Pacific", new DateTime(2024, 4, 25, 13, 12, 52, 31, DateTimeKind.Local).AddTicks(1484), "CDG", new DateTime(2024, 5, 2, 14, 17, 52, 31, DateTimeKind.Local).AddTicks(1480), "YYZ", 337, 82, 1044.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Houston", "840 Marriott St., Philadelphia, 55338", "Radisson", 69, 271.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Philadelphia", "549 Holiday Inn St., Phoenix, 27316", "Holiday Inn", 69, 262.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "San Antonio", "302 Radisson St., San Jose, 31031", "Marriott", 40, 165.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "city", "location", "numRooms", "price" },
                values: new object[] { "Chicago", "695 Wyndham St., San Jose, 44572", 54, 278.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Los Angeles", "927 Hyatt St., Chicago, 33964", "Ritz-Carlton", 82, 221.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "location", "numRooms", "price" },
                values: new object[] { "115 Wyndham St., Philadelphia, 87254", 98, 84.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Houston", "229 Holiday Inn St., San Diego, 71705", "Holiday Inn", 66, 289.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "New York", "120 Hilton St., Philadelphia, 31386", "Hilton", 27, 184.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Philadelphia", "58 Wyndham St., San Antonio, 21700", "Marriott", 88, 274.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "San Diego", "443 Hilton St., Dallas, 60229", "Holiday Inn", 55, 137.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "San Diego", "474 Wyndham St., Dallas, 86551", "Marriott", 35, 179.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Philadelphia", "787 Four Seasons St., San Antonio, 68030", "Holiday Inn", 89, 253.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "San Antonio", "376 InterContinental St., Los Angeles, 41412", "Holiday Inn", 23, 248.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "New York", "139 Ritz-Carlton St., Phoenix, 88739", "Holiday Inn", 62, 285.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "location", "name", "numRooms", "price" },
                values: new object[] { "62 Marriott St., San Diego, 83689", "Four Seasons", 24, 192.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Los Angeles", "458 Hilton St., San Diego, 96195", "Wyndham", 89, 154.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Los Angeles", "222 Radisson St., Los Angeles, 99490", "Four Seasons", 24, 160.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Phoenix", "476 Four Seasons St., Dallas, 63173", "InterContinental", 62, 115.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Chicago", "94 Marriott St., San Jose, 52970", "Marriott", 62, 151.0 });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "city", "location", "name", "numRooms", "price" },
                values: new object[] { "Chicago", "535 Radisson St., San Diego, 77147", "Marriott", 39, 181.0 });
        }
    }
}
