using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurfsUp.Migrations
{
    /// <inheritdoc />
    public partial class SeedBoardsWithImg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 1,
                column: "ImagePath",
                value: "/images/surfboards/surfboard-1");

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 2,
                column: "ImagePath",
                value: "/images/surfboards/surfboard-2");

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 3,
                column: "ImagePath",
                value: "/images/surfboards/surfboard-3");

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 4,
                column: "ImagePath",
                value: "/images/surfboards/surfboard-4");

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 5,
                column: "ImagePath",
                value: "/images/surfboards/surfboard-5");

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 6,
                column: "ImagePath",
                value: "/images/surfboards/surfboard-6");

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 7,
                column: "ImagePath",
                value: "/images/surfboards/surfboard-7");

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 8,
                column: "ImagePath",
                value: "/images/surfboards/surfboard-8");

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 9,
                column: "ImagePath",
                value: "/images/surfboards/surfboard-9");

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 10,
                column: "ImagePath",
                value: "/images/surfboards/surfboard-10");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 1,
                column: "ImagePath",
                value: "/../../~/images/surfboards/surfboard-1");

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 2,
                column: "ImagePath",
                value: "/../../~/images/surfboards/surfboard-2");

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 3,
                column: "ImagePath",
                value: "/../../~/images/surfboards/surfboard-3");

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 4,
                column: "ImagePath",
                value: "/../../~/images/surfboards/surfboard-4");

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 5,
                column: "ImagePath",
                value: "/../../~/images/surfboards/surfboard-5");

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 6,
                column: "ImagePath",
                value: "/../../~/images/surfboards/surfboard-6");

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 7,
                column: "ImagePath",
                value: "/../../~/images/surfboards/surfboard-7");

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 8,
                column: "ImagePath",
                value: "/../../~/images/surfboards/surfboard-8");

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 9,
                column: "ImagePath",
                value: "/../../~/images/surfboards/surfboard-9");

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 10,
                column: "ImagePath",
                value: "/../../~/images/surfboards/surfboard-10");
        }
    }
}
