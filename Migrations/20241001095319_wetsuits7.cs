using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurfsUp.Migrations
{
    /// <inheritdoc />
    public partial class wetsuits7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "SurfsUp",
                table: "Wetsuits",
                columns: new[] { "WetsuitId", "Gender", "ImagePath", "Name", "Price", "Thickness", "WetsuitSize" },
                values: new object[] { 6, "Male", "/images/wetsuits/wetsuit-6.jpg", "Furnace", 285.0, 5.0, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "SurfsUp",
                table: "Wetsuits",
                keyColumn: "WetsuitId",
                keyValue: 6);
        }
    }
}
