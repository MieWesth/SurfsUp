using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SurfsUp.Migrations
{
    /// <inheritdoc />
    public partial class Wetsuit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WetsuitId",
                schema: "SurfsUp",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WetsuitSize",
                schema: "SurfsUp",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Wetsuits",
                schema: "SurfsUp",
                columns: table => new
                {
                    WetsuitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WetsuitSize = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thickness = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wetsuits", x => x.WetsuitId);
                });

            migrationBuilder.InsertData(
                schema: "SurfsUp",
                table: "Wetsuits",
                columns: new[] { "WetsuitId", "Gender", "ImagePath", "Name", "Price", "Thickness", "WetsuitSize" },
                values: new object[,]
                {
                    { 1, "Male", "/images/wetsuits/wetsuit-1.jpg", "Furnace Natural", 565.0, 2.0, 0 },
                    { 2, "", "/images/wetsuits/wetsuit-1.jpg", "", 565.0, 2.75, 0 },
                    { 3, "", "/images/wetsuits/wetsuit-1.jpg", "", 565.0, 2.75, 0 },
                    { 4, "", "/images/wetsuits/wetsuit-1.jpg", "", 565.0, 2.75, 0 },
                    { 5, "", "/images/wetsuits/wetsuit-1.jpg", "", 565.0, 2.75, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_WetsuitId",
                schema: "SurfsUp",
                table: "Bookings",
                column: "WetsuitId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Wetsuits_WetsuitId",
                schema: "SurfsUp",
                table: "Bookings");

            migrationBuilder.DropTable(
                name: "Wetsuits",
                schema: "SurfsUp");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_WetsuitId",
                schema: "SurfsUp",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "WetsuitId",
                schema: "SurfsUp",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "WetsuitSize",
                schema: "SurfsUp",
                table: "Bookings");
        }
    }
}
