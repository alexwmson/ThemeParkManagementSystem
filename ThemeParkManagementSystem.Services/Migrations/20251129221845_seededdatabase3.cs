using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThemeParkManagementSystem.Services.Migrations
{
    /// <inheritdoc />
    public partial class seededdatabase3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Alice Johnson");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatePurchased", "Name" },
                values: new object[] { new DateTime(2025, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bobby Smith" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Caroline Park");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "David Nguyen");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Emily Carter");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Adult Day Pass");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatePurchased", "Name" },
                values: new object[] { new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Child Day Pass" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "VIP Access");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Season Pass");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Fast Pass");
        }
    }
}
