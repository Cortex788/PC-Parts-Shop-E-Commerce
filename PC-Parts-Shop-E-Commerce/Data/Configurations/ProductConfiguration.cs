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
                    ImageURL = "https://img-cdn.heureka.group/v1/3a01e256-9993-48bb-b658-79cc53f92cec/intel-core-i9-13900k-24-core-4-3ghz-lga1700-box-bx8071513900k.jpg"
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
                ,
                new Product
                {
                    Id = 6,
                    ProductName = "ASUS ROG Strix Z790-E Gaming",
                    Description = "High-end Z790 motherboard from ASUS with robust power delivery and features for gaming and content creation.",
                    Price = 449.99m,
                    StockQuantity = 12,
                    BrandId = 5,
                    CategoryId = 4,
                    ImageURL = "/images/products/asus-rog-strix-z790-e.jpg"
                }
                ,
                new Product
                {
                    Id = 7,
                    ProductName = "MSI MPG Z790 Carbon WiFi",
                    Description = "MSI Z790 motherboard with advanced cooling and built-in WiFi for high-end Intel builds.",
                    Price = 379.99m,
                    StockQuantity = 7,
                    BrandId = 6,
                    CategoryId = 4,
                    ImageURL = "/images/products/msi-mpg-z790-carbon.jpg"
                },
                new Product
                {
                    Id = 8,
                    ProductName = "Gigabyte X670E AORUS Master",
                    Description = "Gigabyte X670E flagship motherboard for AMD AM5 with premium power design and connectivity.",
                    Price = 499.99m,
                    StockQuantity = 5,
                    BrandId = 7,
                    CategoryId = 4,
                    ImageURL = "/images/products/gigabyte-x670e-aorus-master.jpg"
                },
                new Product
                {
                    Id = 9,
                    ProductName = "ASUS TUF Gaming B650-PLUS",
                    Description = "ASUS TUF B650 motherboard offering durability and value for AM5 builds.",
                    Price = 189.99m,
                    StockQuantity = 14,
                    BrandId = 5,
                    CategoryId = 4,
                    ImageURL = "/images/products/asus-tuf-b650-plus.jpg"
                },
                new Product
                {
                    Id = 10,
                    ProductName = "MSI MAG B650 Tomahawk",
                    Description = "MSI B650 mid-range motherboard with strong VRM and features for gamers and creators.",
                    Price = 219.99m,
                    StockQuantity = 9,
                    BrandId = 6,
                    CategoryId = 4,
                    ImageURL = "/images/products/msi-mag-b650-tomahawk.jpg"
                }
            );
        }
    }
}
