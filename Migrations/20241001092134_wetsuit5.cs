using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurfsUp.Migrations
{
    /// <inheritdoc />
    public partial class wetsuit5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Boards_BoardId",
                schema: "SurfsUp",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Wetsuits_WetsuitId",
                schema: "SurfsUp",
                table: "Bookings");

            migrationBuilder.AlterColumn<int>(
                name: "WetsuitId",
                schema: "SurfsUp",
                table: "Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BoardId",
                schema: "SurfsUp",
                table: "Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Boards_BoardId",
                schema: "SurfsUp",
                table: "Bookings",
                column: "BoardId",
                principalSchema: "SurfsUp",
                principalTable: "Boards",
                principalColumn: "BoardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Wetsuits_WetsuitId",
                schema: "SurfsUp",
                table: "Bookings",
                column: "WetsuitId",
                principalSchema: "SurfsUp",
                principalTable: "Wetsuits",
                principalColumn: "WetsuitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Boards_BoardId",
                schema: "SurfsUp",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Wetsuits_WetsuitId",
                schema: "SurfsUp",
                table: "Bookings");

            migrationBuilder.AlterColumn<int>(
                name: "WetsuitId",
                schema: "SurfsUp",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BoardId",
                schema: "SurfsUp",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Boards_BoardId",
                schema: "SurfsUp",
                table: "Bookings",
                column: "BoardId",
                principalSchema: "SurfsUp",
                principalTable: "Boards",
                principalColumn: "BoardId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Wetsuits_WetsuitId",
                schema: "SurfsUp",
                table: "Bookings",
                column: "WetsuitId",
                principalSchema: "SurfsUp",
                principalTable: "Wetsuits",
                principalColumn: "WetsuitId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
