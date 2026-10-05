using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PC_Parts_Shop_E_Commerce.Data.Models;

namespace PC_Parts_Shop_E_Commerce.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    ProductName = "Intel Core i9-13900K",
                    Description = "High-end desktop CPU from Intel for enthusiast gaming and content creation.",
                    Price = 589.99m,
                    StockQuantity = 10,
                    BrandId = 1,
                    CategoryId = 1,
                    ImageURL = "/images/products/i9-13900k.jpg"
                },
                new Product
                {
                    Id = 2,
                    ProductName = "AMD Ryzen 9 7950X",
                    Description = "High-performance CPU from AMD suitable for multitasking and heavy workloads.",
                    Price = 699.99m,
                    StockQuantity = 8,
                    BrandId = 2,
                    CategoryId = 1,
                    ImageURL = "/images/products/ryzen9-7950x.jpg"
                },
                new Product
                {
                    Id = 3,
                    ProductName = "NVIDIA GeForce RTX 4090",
                    Description = "Flagship GPU delivering top-tier gaming and compute performance.",
                    Price = 1599.99m,
                    StockQuantity = 5,
                    BrandId = 3,
                    CategoryId = 2,
                    ImageURL = "/images/products/rtx4090.jpg"
                },
                new Product
                {
                    Id = 4,
                    ProductName = "Corsair Vengeance LPX 32GB",
                    Description = "Reliable DDR4 memory kit designed for performance and compatibility.",
                    Price = 89.99m,
                    StockQuantity = 25,
                    BrandId = 4,
                    CategoryId = 3,
                    ImageURL = "/images/products/corsair-vengeance-32gb.jpg"
                },
                new Product
                {
                    Id = 5,
                    ProductName = "AMD Radeon RX 7900 XTX",
                    Description = "High-end GPU from AMD for 4K gaming and creative workloads.",
                    Price = 999.99m,
                    StockQuantity = 6,
                    BrandId = 2,
                    CategoryId = 2,
                    ImageURL = "/images/products/rx7900xtx.jpg"
                }
            );
        }
    }
}
