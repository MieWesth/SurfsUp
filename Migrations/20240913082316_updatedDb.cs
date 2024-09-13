using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurfsUp.Migrations
{
    /// <inheritdoc />
    public partial class updatedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBooked",
                schema: "SurfsUp",
                table: "Boards",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 1,
                column: "IsBooked",
                value: false);

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 2,
                column: "IsBooked",
                value: false);

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 3,
                column: "IsBooked",
                value: false);

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 4,
                column: "IsBooked",
                value: false);

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 5,
                column: "IsBooked",
                value: false);

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 6,
                column: "IsBooked",
                value: false);

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 7,
                column: "IsBooked",
                value: false);

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 8,
                column: "IsBooked",
                value: false);

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 9,
                column: "IsBooked",
                value: false);

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Boards",
                keyColumn: "BoardId",
                keyValue: 10,
                column: "IsBooked",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBooked",
                schema: "SurfsUp",
                table: "Boards");
        }
    }
}
