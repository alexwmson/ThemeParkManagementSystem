using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThemeParkManagementSystem.Services.Migrations
{
    /// <inheritdoc />
    public partial class fixedfastpassprice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 89.99f);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 89.99f);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: 89.99f);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 20,
                column: "Price",
                value: 89.99f);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 23,
                column: "Price",
                value: 89.99f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 29.99f);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 29.99f);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: 29.99f);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 20,
                column: "Price",
                value: 29.99f);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 23,
                column: "Price",
                value: 29.99f);
        }
    }
}
