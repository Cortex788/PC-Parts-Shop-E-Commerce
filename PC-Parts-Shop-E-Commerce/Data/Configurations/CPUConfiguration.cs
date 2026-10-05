using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PC_Parts_Shop_E_Commerce.Data.Models;

namespace PC_Parts_Shop_E_Commerce.Data.Configurations
{
    public class CPUConfiguration : IEntityTypeConfiguration<CPU>
    {
        public void Configure(EntityTypeBuilder<CPU> builder)
        {
            builder.HasData(
                new CPU
                {
                    ProductId = 1,
                    Name = "Core i9-13900K",
                    Cores = 24,
                    Threads = 32,
                    BaseClock = 3000,
                    BoostClock = 5300,
                    IntegratedGraphics = "Intel UHD Graphics 770",
                    SocketType = "LGA1700"
                },
                new CPU
                {
                    ProductId = 2,
                    Name = "Ryzen 9 7950X",
                    Cores = 16,
                    Threads = 32,
                    BaseClock = 4500,
                    BoostClock = 5100,
                    IntegratedGraphics = null,
                    SocketType = "AM5"
                }
            );
        }
    }
}
