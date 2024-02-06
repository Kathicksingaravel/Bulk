using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bulk.Migrations
{
    /// <inheritdoc />
    public partial class Sabeethupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDisplay",
                value: "5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDisplay",
                value: "7");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDisplay",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDisplay",
                value: "3");
        }
    }
}
