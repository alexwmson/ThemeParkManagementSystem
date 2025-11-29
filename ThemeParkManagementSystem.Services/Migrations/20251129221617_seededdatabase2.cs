using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThemeParkManagementSystem.Services.Migrations
{
    /// <inheritdoc />
    public partial class seededdatabase2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "NextMaintenance" },
                values: new object[] { "High-speed roller coaster", "Dragon Coaster", new DateTime(2026, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "NextMaintenance" },
                values: new object[] { "Log flume ride with drops", "Splash Mountain", new DateTime(2026, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "Name", "NextMaintenance", "WaitTime" },
                values: new object[] { 40, "Giant ferris wheel with views", "Sky Wheel", new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "Description", "Name", "NextMaintenance", "WaitTime" },
                values: new object[] { 16, "Dark ride with animatronics", "Haunted Mansion", new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Description", "Name", "NextMaintenance", "WaitTime" },
                values: new object[] { 12, "Vertical launch thrill ride", "Rocket Launch", new DateTime(2026, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 60 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatePurchased", "Price", "ValidOn" },
                values: new object[] { new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 59.99f, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatePurchased", "Price", "ValidOn" },
                values: new object[] { new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.99f, new DateTime(2025, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatePurchased", "Name", "Price", "ValidOn" },
                values: new object[] { new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "VIP Access", 149.99f, new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatePurchased", "Name", "Price", "Type", "ValidOn" },
                values: new object[] { new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Season Pass", 299.99f, 4, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatePurchased", "Name", "Price", "Type", "ValidOn" },
                values: new object[] { new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast Pass", 29.99f, 5, new DateTime(2025, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "NextMaintenance" },
                values: new object[] { "High-speed outdoor roller coaster with sharp turns.", "Thunder Mountain Coaster", new DateTime(2025, 12, 9, 17, 14, 7, 284, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "NextMaintenance" },
                values: new object[] { "Family water ride through a pirate-themed river.", "Pirate Splash Adventure", new DateTime(2025, 12, 4, 17, 14, 7, 285, DateTimeKind.Local).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "Description", "Name", "NextMaintenance", "WaitTime" },
                values: new object[] { 16, "Spinning space-themed ride with LED lighting.", "Galaxy Spinner", new DateTime(2025, 12, 14, 17, 14, 7, 285, DateTimeKind.Local).AddTicks(5176), 20 });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "Description", "Name", "NextMaintenance", "WaitTime" },
                values: new object[] { 12, "Dark indoor ride with animatronics and jump scares.", "Haunted Mansion Escape", new DateTime(2025, 12, 6, 17, 14, 7, 285, DateTimeKind.Local).AddTicks(5178), 60 });

            migrationBuilder.UpdateData(
                table: "Rides",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "Description", "Name", "NextMaintenance", "WaitTime" },
                values: new object[] { 8, "200-foot freefall tower drop ride.", "Sky Tower Drop", new DateTime(2025, 12, 19, 17, 14, 7, 285, DateTimeKind.Local).AddTicks(5179), 50 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatePurchased", "Price", "ValidOn" },
                values: new object[] { new DateTime(2025, 11, 29, 17, 14, 7, 285, DateTimeKind.Local).AddTicks(9400), 89.99f, new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatePurchased", "Price", "ValidOn" },
                values: new object[] { new DateTime(2025, 11, 29, 16, 59, 7, 285, DateTimeKind.Local).AddTicks(9516), 59.99f, new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatePurchased", "Name", "Price", "ValidOn" },
                values: new object[] { new DateTime(2025, 11, 29, 16, 14, 7, 285, DateTimeKind.Local).AddTicks(9524), "VIP All-Access Ticket", 199.99f, new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatePurchased", "Name", "Price", "Type", "ValidOn" },
                values: new object[] { new DateTime(2025, 11, 29, 16, 29, 7, 285, DateTimeKind.Local).AddTicks(9530), "FastPass Upgrade", 49.99f, 5, new DateTime(2025, 11, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatePurchased", "Name", "Price", "Type", "ValidOn" },
                values: new object[] { new DateTime(2025, 11, 19, 17, 14, 7, 285, DateTimeKind.Local).AddTicks(9542), "Season Pass", 299.99f, 4, new DateTime(2026, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
