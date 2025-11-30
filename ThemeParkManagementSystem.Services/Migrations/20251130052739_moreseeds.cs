using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThemeParkManagementSystem.Services.Migrations
{
    /// <inheritdoc />
    public partial class moreseeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rides",
                columns: new[] { "Id", "Capacity", "Description", "Name", "NextMaintenance", "WaitTime" },
                values: new object[,]
                {
                    { 6, 30, "Boat safari adventure", "Jungle Expedition", new DateTime(2026, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 7, 28, "Water boat battle ride", "Pirate Bay", new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 8, 18, "Spinning space-themed ride", "Galactic Spin", new DateTime(2026, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 9, 25, "Fast-paced river rafting", "Wild River Rapids", new DateTime(2026, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 55 },
                    { 10, 22, "Indoor mine-cart roller coaster", "Mystery Mine", new DateTime(2026, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 },
                    { 11, 40, "Aerial gondola with aerial views", "Sky Glider", new DateTime(2026, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 12, 14, "Extreme spinning thrill ride", "Tornado Twister", new DateTime(2026, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 65 },
                    { 13, 16, "Tower drop ride", "Firestorm Drop", new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 70 },
                    { 14, 50, "Classic carousel with fantasy theme", "Enchanted Carousel", new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 15, 30, "Motion simulator space ride", "Cosmic Cruiser", new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 16, 20, "Dark ride through frozen tunnels", "Ice Cavern Escape", new DateTime(2026, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 17, 18, "High-speed volcanic themed coaster", "Volcano Surge", new DateTime(2026, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { 18, 14, "Sci-fi dark ride with animatronics", "Alien Encounter", new DateTime(2026, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 19, 12, "Zip-line glider attraction", "Jungle Flyers", new DateTime(2026, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 80 },
                    { 20, 20, "Slow exploration dark ride", "Crystal Caverns", new DateTime(2026, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "DatePurchased", "Name", "Price", "Type", "ValidOn" },
                values: new object[,]
                {
                    { 6, new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Franklin West", 59.99f, 0, new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grace Howard", 149.99f, 3, new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2025, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henry Lopez", 39.99f, 1, new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabella Turner", 29.99f, 5, new DateTime(2025, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jacob Hill", 59.99f, 0, new DateTime(2025, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelly Green", 49.99f, 2, new DateTime(2025, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2025, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liam Roberts", 59.99f, 0, new DateTime(2025, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2025, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mia Douglas", 149.99f, 3, new DateTime(2026, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2025, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noah Carter", 39.99f, 1, new DateTime(2025, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2025, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olivia Brooks", 29.99f, 5, new DateTime(2026, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2025, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peter Winston", 59.99f, 0, new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2025, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quinn Adams", 49.99f, 2, new DateTime(2026, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2025, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rebecca Miles", 149.99f, 3, new DateTime(2026, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2025, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel Pratt", 39.99f, 1, new DateTime(2026, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tiffany Rhodes", 29.99f, 5, new DateTime(2026, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Franklin Moore", 59.99f, 0, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Georgia Alvarez", 39.99f, 1, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henry Thompson", 29.99f, 5, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 23);
        }
    }
}
