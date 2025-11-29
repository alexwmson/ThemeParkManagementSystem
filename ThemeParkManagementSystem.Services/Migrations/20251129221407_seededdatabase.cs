using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ThemeParkManagementSystem.Services.Migrations
{
    /// <inheritdoc />
    public partial class seededdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rides",
                columns: new[] { "Id", "Capacity", "Description", "Name", "NextMaintenance", "WaitTime" },
                values: new object[,]
                {
                    { 1, 24, "High-speed outdoor roller coaster with sharp turns.", "Thunder Mountain Coaster", new DateTime(2025, 12, 9, 17, 14, 7, 284, DateTimeKind.Local).AddTicks(1325), 45 },
                    { 2, 20, "Family water ride through a pirate-themed river.", "Pirate Splash Adventure", new DateTime(2025, 12, 4, 17, 14, 7, 285, DateTimeKind.Local).AddTicks(5165), 30 },
                    { 3, 16, "Spinning space-themed ride with LED lighting.", "Galaxy Spinner", new DateTime(2025, 12, 14, 17, 14, 7, 285, DateTimeKind.Local).AddTicks(5176), 20 },
                    { 4, 12, "Dark indoor ride with animatronics and jump scares.", "Haunted Mansion Escape", new DateTime(2025, 12, 6, 17, 14, 7, 285, DateTimeKind.Local).AddTicks(5178), 60 },
                    { 5, 8, "200-foot freefall tower drop ride.", "Sky Tower Drop", new DateTime(2025, 12, 19, 17, 14, 7, 285, DateTimeKind.Local).AddTicks(5179), 50 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "DatePurchased", "Name", "Price", "Type", "ValidOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 11, 29, 17, 14, 7, 285, DateTimeKind.Local).AddTicks(9400), "Adult Day Pass", 89.99f, 0, new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, new DateTime(2025, 11, 29, 16, 59, 7, 285, DateTimeKind.Local).AddTicks(9516), "Child Day Pass", 59.99f, 1, new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, new DateTime(2025, 11, 29, 16, 14, 7, 285, DateTimeKind.Local).AddTicks(9524), "VIP All-Access Ticket", 199.99f, 3, new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, new DateTime(2025, 11, 29, 16, 29, 7, 285, DateTimeKind.Local).AddTicks(9530), "FastPass Upgrade", 49.99f, 5, new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, new DateTime(2025, 11, 19, 17, 14, 7, 285, DateTimeKind.Local).AddTicks(9542), "Season Pass", 299.99f, 4, new DateTime(2026, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
