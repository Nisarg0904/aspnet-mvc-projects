using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class moreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Identity",
                table: "cars",
                columns: new[] { "id", "availableFrom", "isAvailable", "location", "model", "price", "rentalCompanies", "type" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Dallas", "Honda Accord", 168.0, "Rental2", "Sports Car" },
                    { 3, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Chicago", "Hyundai Elantra", 66.0, "Rental3", "Sports Car" },
                    { 4, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "San Diego", "Nissan Altima", 270.0, "Rental4", "Sports Car" },
                    { 5, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "San Diego", "Hyundai Elantra", 259.0, "Rental5", "Sports Car" },
                    { 6, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Phoenix", "Ford Fusion", 150.0, "Rental6", "Sports Car" },
                    { 7, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Chicago", "Toyota Camry", 90.0, "Rental7", "Sports Car" },
                    { 8, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Philadelphia", "Nissan Altima", 278.0, "Rental8", "Sports Car" },
                    { 9, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Dallas", "Nissan Altima", 266.0, "Rental9", "Sports Car" },
                    { 10, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Houston", "Ford Fusion", 91.0, "Rental10", "Sports Car" },
                    { 11, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Houston", "Kia Forte", 190.0, "Rental11", "Sports Car" },
                    { 12, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Houston", "Hyundai Elantra", 78.0, "Rental12", "Sports Car" },
                    { 13, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Dallas", "Honda Accord", 290.0, "Rental13", "Sports Car" },
                    { 14, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "San Jose", "Hyundai Elantra", 214.0, "Rental14", "Sports Car" },
                    { 15, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "San Diego", "Nissan Altima", 112.0, "Rental15", "Sports Car" },
                    { 16, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "New York", "Honda Accord", 219.0, "Rental16", "Sports Car" },
                    { 17, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Los Angeles", "Ford Fusion", 256.0, "Rental17", "Sports Car" },
                    { 18, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Houston", "Volkswagen Jetta", 211.0, "Rental18", "Sports Car" },
                    { 19, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Phoenix", "Hyundai Elantra", 189.0, "Rental19", "Sports Car" },
                    { 20, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Chicago", "Ford Fusion", 177.0, "Rental20", "Sports Car" },
                    { 21, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "San Diego", "Nissan Altima", 127.0, "Rental21", "Sports Car" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "flights",
                columns: new[] { "id", "airline", "arrTime", "arrival", "depTime", "departure", "maxPassanger", "numPassanger", "price" },
                values: new object[,]
                {
                    { 2, "Air Canada", new DateTime(2024, 4, 18, 17, 28, 52, 31, DateTimeKind.Local).AddTicks(520), "SIN", new DateTime(2024, 5, 3, 0, 42, 52, 31, DateTimeKind.Local).AddTicks(292), "LHR", 456, 153, 340.0 },
                    { 3, "Singapore Airlines", new DateTime(2024, 4, 28, 12, 46, 52, 31, DateTimeKind.Local).AddTicks(583), "LHR", new DateTime(2024, 4, 27, 23, 14, 52, 31, DateTimeKind.Local).AddTicks(578), "ATL", 367, 22, 401.0 },
                    { 4, "Singapore Airlines", new DateTime(2024, 5, 2, 13, 54, 52, 31, DateTimeKind.Local).AddTicks(637), "CAN", new DateTime(2024, 5, 7, 17, 58, 52, 31, DateTimeKind.Local).AddTicks(633), "SFO", 209, 115, 1240.0 },
                    { 5, "Singapore Airlines", new DateTime(2024, 5, 10, 21, 58, 52, 31, DateTimeKind.Local).AddTicks(691), "JFK", new DateTime(2024, 5, 11, 9, 11, 52, 31, DateTimeKind.Local).AddTicks(685), "YYZ", 438, 36, 780.0 },
                    { 6, "Lufthansa", new DateTime(2024, 5, 12, 18, 6, 52, 31, DateTimeKind.Local).AddTicks(745), "SIN", new DateTime(2024, 5, 13, 4, 36, 52, 31, DateTimeKind.Local).AddTicks(741), "DFW", 465, 101, 964.0 },
                    { 7, "Cathay Pacific", new DateTime(2024, 4, 19, 15, 36, 52, 31, DateTimeKind.Local).AddTicks(792), "HKG", new DateTime(2024, 4, 21, 9, 49, 52, 31, DateTimeKind.Local).AddTicks(788), "PEK", 261, 70, 1213.0 },
                    { 8, "United Airlines", new DateTime(2024, 4, 27, 12, 56, 52, 31, DateTimeKind.Local).AddTicks(842), "LHR", new DateTime(2024, 5, 3, 12, 34, 52, 31, DateTimeKind.Local).AddTicks(838), "CDG", 378, 109, 1276.0 },
                    { 9, "British Airways", new DateTime(2024, 5, 11, 5, 49, 52, 31, DateTimeKind.Local).AddTicks(892), "AMS", new DateTime(2024, 5, 7, 16, 15, 52, 31, DateTimeKind.Local).AddTicks(887), "DFW", 212, 165, 551.0 },
                    { 10, "Lufthansa", new DateTime(2024, 5, 1, 21, 56, 52, 31, DateTimeKind.Local).AddTicks(942), "SIN", new DateTime(2024, 5, 1, 19, 2, 52, 31, DateTimeKind.Local).AddTicks(938), "ATL", 342, 68, 315.0 },
                    { 11, "Air Canada", new DateTime(2024, 4, 19, 8, 38, 52, 31, DateTimeKind.Local).AddTicks(989), "LHR", new DateTime(2024, 4, 24, 22, 39, 52, 31, DateTimeKind.Local).AddTicks(984), "HND", 315, 48, 884.0 },
                    { 12, "Qantas", new DateTime(2024, 5, 2, 12, 41, 52, 31, DateTimeKind.Local).AddTicks(1036), "ICN", new DateTime(2024, 5, 3, 13, 16, 52, 31, DateTimeKind.Local).AddTicks(1032), "DFW", 325, 94, 1460.0 },
                    { 13, "Cathay Pacific", new DateTime(2024, 5, 8, 20, 28, 52, 31, DateTimeKind.Local).AddTicks(1089), "JFK", new DateTime(2024, 4, 21, 15, 20, 52, 31, DateTimeKind.Local).AddTicks(1084), "DFW", 406, 60, 363.0 },
                    { 14, "Qantas", new DateTime(2024, 4, 17, 9, 43, 52, 31, DateTimeKind.Local).AddTicks(1138), "LHR", new DateTime(2024, 5, 2, 19, 30, 52, 31, DateTimeKind.Local).AddTicks(1134), "LHR", 217, 110, 658.0 },
                    { 15, "Delta Air Lines", new DateTime(2024, 5, 10, 20, 3, 52, 31, DateTimeKind.Local).AddTicks(1189), "SIN", new DateTime(2024, 5, 7, 18, 4, 52, 31, DateTimeKind.Local).AddTicks(1184), "SFO", 494, 151, 1049.0 },
                    { 16, "Singapore Airlines", new DateTime(2024, 4, 22, 14, 24, 52, 31, DateTimeKind.Local).AddTicks(1239), "SIN", new DateTime(2024, 4, 18, 8, 14, 52, 31, DateTimeKind.Local).AddTicks(1234), "YYZ", 308, 157, 435.0 },
                    { 17, "Cathay Pacific", new DateTime(2024, 5, 7, 3, 19, 52, 31, DateTimeKind.Local).AddTicks(1285), "SIN", new DateTime(2024, 4, 26, 23, 19, 52, 31, DateTimeKind.Local).AddTicks(1280), "JFK", 210, 17, 1201.0 },
                    { 18, "American Airlines", new DateTime(2024, 4, 27, 6, 57, 52, 31, DateTimeKind.Local).AddTicks(1338), "CAN", new DateTime(2024, 4, 29, 6, 33, 52, 31, DateTimeKind.Local).AddTicks(1333), "CDG", 217, 94, 613.0 },
                    { 19, "United Airlines", new DateTime(2024, 5, 12, 14, 54, 52, 31, DateTimeKind.Local).AddTicks(1387), "CAN", new DateTime(2024, 4, 21, 1, 6, 52, 31, DateTimeKind.Local).AddTicks(1382), "HND", 334, 88, 352.0 },
                    { 20, "Singapore Airlines", new DateTime(2024, 4, 29, 10, 14, 52, 31, DateTimeKind.Local).AddTicks(1438), "DXB", new DateTime(2024, 5, 5, 4, 47, 52, 31, DateTimeKind.Local).AddTicks(1434), "DFW", 304, 176, 678.0 },
                    { 21, "Cathay Pacific", new DateTime(2024, 4, 25, 13, 12, 52, 31, DateTimeKind.Local).AddTicks(1484), "CDG", new DateTime(2024, 5, 2, 14, 17, 52, 31, DateTimeKind.Local).AddTicks(1480), "YYZ", 337, 82, 1044.0 }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "hotels",
                columns: new[] { "id", "amenities", "city", "location", "name", "numRooms", "price" },
                values: new object[,]
                {
                    { 2, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "Houston", "840 Marriott St., Philadelphia, 55338", "Radisson", 69, 271.0 },
                    { 3, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "Philadelphia", "549 Holiday Inn St., Phoenix, 27316", "Holiday Inn", 69, 262.0 },
                    { 4, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "San Antonio", "302 Radisson St., San Jose, 31031", "Marriott", 40, 165.0 },
                    { 5, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "Chicago", "695 Wyndham St., San Jose, 44572", "Sheraton", 54, 278.0 },
                    { 6, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "Los Angeles", "927 Hyatt St., Chicago, 33964", "Ritz-Carlton", 82, 221.0 },
                    { 7, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "San Jose", "115 Wyndham St., Philadelphia, 87254", "Marriott", 98, 84.0 },
                    { 8, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "Houston", "229 Holiday Inn St., San Diego, 71705", "Holiday Inn", 66, 289.0 },
                    { 9, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "New York", "120 Hilton St., Philadelphia, 31386", "Hilton", 27, 184.0 },
                    { 10, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "Philadelphia", "58 Wyndham St., San Antonio, 21700", "Marriott", 88, 274.0 },
                    { 11, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "San Diego", "443 Hilton St., Dallas, 60229", "Holiday Inn", 55, 137.0 },
                    { 12, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "San Diego", "474 Wyndham St., Dallas, 86551", "Marriott", 35, 179.0 },
                    { 13, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "Philadelphia", "787 Four Seasons St., San Antonio, 68030", "Holiday Inn", 89, 253.0 },
                    { 14, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "San Antonio", "376 InterContinental St., Los Angeles, 41412", "Holiday Inn", 23, 248.0 },
                    { 15, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "New York", "139 Ritz-Carlton St., Phoenix, 88739", "Holiday Inn", 62, 285.0 },
                    { 16, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "Chicago", "62 Marriott St., San Diego, 83689", "Four Seasons", 24, 192.0 },
                    { 17, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "Los Angeles", "458 Hilton St., San Diego, 96195", "Wyndham", 89, 154.0 },
                    { 18, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "Los Angeles", "222 Radisson St., Los Angeles, 99490", "Four Seasons", 24, 160.0 },
                    { 19, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "Phoenix", "476 Four Seasons St., Dallas, 63173", "InterContinental", 62, 115.0 },
                    { 20, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "Chicago", "94 Marriott St., San Jose, 52970", "Marriott", 62, 151.0 },
                    { 21, "Wi-Fi, Air Conditioning, TV, Swimming Pool", "Chicago", "535 Radisson St., San Diego, 77147", "Marriott", 39, 181.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "cars",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "flights",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "hotels",
                keyColumn: "id",
                keyValue: 21);
        }
    }
}
