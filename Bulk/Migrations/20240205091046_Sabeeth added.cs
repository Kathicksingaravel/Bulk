using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bulk.Migrations
{
    /// <inheritdoc />
    public partial class Sabeethadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Name", "OrderDisplay" },
                values: new object[] { 4, "sabeeth", "4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
