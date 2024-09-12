using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SurfsUp.Migrations
{
    /// <inheritdoc />
    public partial class SeedBoards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "SurfsUp",
                table: "Boards",
                columns: new[] { "BoardId", "Equipment", "ImagePath", "Length", "Name", "Price", "Thickness", "Type", "Volume", "Width" },
                values: new object[,]
                {
                    { 1, "", "/../../~/images/surfboards/surfboard-1", 6.0, "The Minilog", 565, 2.75, "Shortboard", 38.799999999999997, 21.0 },
                    { 2, "", "/../../~/images/surfboards/surfboard-2", 7.0999999999999996, "The Wide Glider", 685, 2.75, "Funboard", 44.159999999999997, 21.75 },
                    { 3, "", "/../../~/images/surfboards/surfboard-3", 6.2999999999999998, "The Golden Ratio", 695, 2.8999999999999999, "Funboard", 43.219999999999999, 21.850000000000001 },
                    { 4, "", "/../../~/images/surfboards/surfboard-4", 5.4000000000000004, "Mahi Mahi", 645, 2.2999999999999998, "Fish", 29.390000000000001, 20.75 },
                    { 5, "", "/../../~/images/surfboards/surfboard-5", 9.1999999999999993, "The Emerald Glider", 895, 2.7999999999999998, "Longboard", 65.400000000000006, 22.800000000000001 },
                    { 6, "", "/../../~/images/surfboards/surfboard-6", 5.5, "The Bomb", 645, 2.5, "Shortboard", 33.700000000000003, 21.0 },
                    { 7, "", "/../../~/images/surfboards/surfboard-7", 9.5999999999999996, "Walden Magic", 1025, 3.0, "Longboard", 80.0, 19.399999999999999 },
                    { 8, "Paddle", "/../../~/images/surfboards/surfboard-8", 12.6, "Naish One", 854, 6.0, "SUP", 301.0, 30.0 },
                    { 9, "Fin, Paddle, Pump, Leash", "/../../~/images/surfboards/surfboard-9", 11.6, "Six Tourer", 611, 6.0, "SUP", 270.0, 32.0 },
                    { 10, "Fin, Paddle, Pump, Leash", "/../../~/images/surfboards/surfboard-10", 14.0, "Naish Maliko", 1304, 6.0, "SUP", 330.0, 25.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 10);
        }
    }
}
