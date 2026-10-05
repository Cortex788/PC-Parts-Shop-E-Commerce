using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PC_Parts_Shop_E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class InsertSampleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Intel" },
                    { 2, "AMD" },
                    { 3, "NVIDIA" },
                    { 4, "Corsair" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "CPU" },
                    { 2, "GPU" },
                    { 3, "RAM" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "ImageURL", "Price", "ProductName", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 1, 1, "High-end desktop CPU from Intel for enthusiast gaming and content creation.", "/images/products/i9-13900k.jpg", 589.99m, "Intel Core i9-13900K", 10 },
                    { 2, 2, 1, "High-performance CPU from AMD suitable for multitasking and heavy workloads.", "/images/products/ryzen9-7950x.jpg", 699.99m, "AMD Ryzen 9 7950X", 8 },
                    { 3, 3, 2, "Flagship GPU delivering top-tier gaming and compute performance.", "/images/products/rtx4090.jpg", 1599.99m, "NVIDIA GeForce RTX 4090", 5 },
                    { 4, 4, 3, "Reliable DDR4 memory kit designed for performance and compatibility.", "/images/products/corsair-vengeance-32gb.jpg", 89.99m, "Corsair Vengeance LPX 32GB", 25 },
                    { 5, 2, 2, "High-end GPU from AMD for 4K gaming and creative workloads.", "/images/products/rx7900xtx.jpg", 999.99m, "AMD Radeon RX 7900 XTX", 6 }
                });

            migrationBuilder.InsertData(
                table: "CPUs",
                columns: new[] { "ProductId", "BaseClock", "BoostClock", "Cores", "IntegratedGraphics", "Name", "SocketType", "Threads" },
                values: new object[,]
                {
                    { 1, 3000, 5300, 24, "Intel UHD Graphics 770", "Core i9-13900K", "LGA1700", 32 },
                    { 2, 4500, 5100, 16, null, "Ryzen 9 7950X", "AM5", 32 }
                });

            migrationBuilder.InsertData(
                table: "GPUs",
                columns: new[] { "ProductId", "Chipset", "Cores", "Length", "MemoryClock", "MemoryType", "VRAM" },
                values: new object[,]
                {
                    { 3, "GeForce RTX 4090", 16384, "336mm", 21000, "GDDR6X", 24 },
                    { 5, "Radeon RX 7900 XTX", 6144, "324mm", 20000, "GDDR6", 24 }
                });

            migrationBuilder.InsertData(
                table: "RAMs",
                columns: new[] { "ProductId", "Capacity", "MemorySpeed", "MemoryType" },
                values: new object[] { 4, 32, 3200, "DDR4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CPUs",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CPUs",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GPUs",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GPUs",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RAMs",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
