using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurfsUp.Migrations
{
    /// <inheritdoc />
    public partial class wetsuits6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Wetsuits",
                keyColumn: "WetsuitId",
                keyValue: 1,
                column: "Price",
                value: 275.0);

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Wetsuits",
                keyColumn: "WetsuitId",
                keyValue: 2,
                columns: new[] { "Gender", "ImagePath", "Name", "Price", "Thickness" },
                values: new object[] { "Male", "/images/wetsuits/wetsuit-2.jpg", "Revolution", 290.0, 2.0 });

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Wetsuits",
                keyColumn: "WetsuitId",
                keyValue: 3,
                columns: new[] { "Gender", "ImagePath", "Name", "Price", "Thickness" },
                values: new object[] { "Male", "/images/wetsuits/wetsuit-3.jpg", "Foil", 265.0, 3.0 });

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Wetsuits",
                keyColumn: "WetsuitId",
                keyValue: 4,
                columns: new[] { "Gender", "ImagePath", "Name", "Price", "Thickness" },
                values: new object[] { "Male", "/images/wetsuits/wetsuit-4.jpg", "Revolution Natural", 270.0, 3.0 });

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Wetsuits",
                keyColumn: "WetsuitId",
                keyValue: 5,
                columns: new[] { "Gender", "ImagePath", "Name", "Price", "Thickness" },
                values: new object[] { "Male", "/images/wetsuits/wetsuit-5.jpg", "Foil Natural", 285.0, 5.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Wetsuits",
                keyColumn: "WetsuitId",
                keyValue: 1,
                column: "Price",
                value: 565.0);

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Wetsuits",
                keyColumn: "WetsuitId",
                keyValue: 2,
                columns: new[] { "Gender", "ImagePath", "Name", "Price", "Thickness" },
                values: new object[] { "", "/images/wetsuits/wetsuit-1.jpg", "", 565.0, 2.75 });

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Wetsuits",
                keyColumn: "WetsuitId",
                keyValue: 3,
                columns: new[] { "Gender", "ImagePath", "Name", "Price", "Thickness" },
                values: new object[] { "", "/images/wetsuits/wetsuit-1.jpg", "", 565.0, 2.75 });

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Wetsuits",
                keyColumn: "WetsuitId",
                keyValue: 4,
                columns: new[] { "Gender", "ImagePath", "Name", "Price", "Thickness" },
                values: new object[] { "", "/images/wetsuits/wetsuit-1.jpg", "", 565.0, 2.75 });

            migrationBuilder.UpdateData(
                schema: "SurfsUp",
                table: "Wetsuits",
                keyColumn: "WetsuitId",
                keyValue: 5,
                columns: new[] { "Gender", "ImagePath", "Name", "Price", "Thickness" },
                values: new object[] { "", "/images/wetsuits/wetsuit-1.jpg", "", 565.0, 2.75 });
        }
    }
}
