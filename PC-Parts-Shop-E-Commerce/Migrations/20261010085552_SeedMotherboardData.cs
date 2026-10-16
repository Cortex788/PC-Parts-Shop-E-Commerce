using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PC_Parts_Shop_E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class SeedMotherboardData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Motherboard" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "ImageURL", "Price", "ProductName", "StockQuantity" },
                values: new object[,]
                {
                    { 6, 5, 4, "High-end Z790 motherboard from ASUS with robust power delivery and features for gaming and content creation.", "/images/products/asus-rog-strix-z790-e.jpg", 449.99m, "ASUS ROG Strix Z790-E Gaming", 12 },
                    { 7, 6, 4, "MSI Z790 motherboard with advanced cooling and built-in WiFi for high-end Intel builds.", "/images/products/msi-mpg-z790-carbon.jpg", 379.99m, "MSI MPG Z790 Carbon WiFi", 7 },
                    { 8, 7, 4, "Gigabyte X670E flagship motherboard for AMD AM5 with premium power design and connectivity.", "/images/products/gigabyte-x670e-aorus-master.jpg", 499.99m, "Gigabyte X670E AORUS Master", 5 },
                    { 9, 5, 4, "ASUS TUF B650 motherboard offering durability and value for AM5 builds.", "/images/products/asus-tuf-b650-plus.jpg", 189.99m, "ASUS TUF Gaming B650-PLUS", 14 },
                    { 10, 6, 4, "MSI B650 mid-range motherboard with strong VRM and features for gamers and creators.", "/images/products/msi-mag-b650-tomahawk.jpg", 219.99m, "MSI MAG B650 Tomahawk", 9 }
                });

            migrationBuilder.InsertData(
                table: "Motherboards",
                columns: new[] { "ProductId", "Chipset", "FormFactor", "MemorySlots", "MemoryType", "Name", "Socket" },
                values: new object[,]
                {
                    { 6, "Z790", 1, 4, 5, "ROG Strix Z790-E Gaming", "LGA1700" },
                    { 7, "Z790", 1, 4, 5, "MPG Z790 Carbon WiFi", "LGA1700" },
                    { 8, "X670E", 1, 4, 5, "X670E AORUS Master", "AM5" },
                    { 9, "B650", 1, 4, 5, "TUF Gaming B650-PLUS", "AM5" },
                    { 10, "B650", 1, 4, 5, "MAG B650 Tomahawk", "AM5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Motherboards",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Motherboards",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Motherboards",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Motherboards",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Motherboards",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
