using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecom.infrastructure.data.migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "id", "description", "name" },
                values: new object[] { 1, "test", "test" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "categoryid", "description", "name", "price" },
                values: new object[] { 1, 1, "test", "test", 12m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
