using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PC_Parts_Shop_E_Commerce.Data.Models;

namespace PC_Parts_Shop_E_Commerce.Data.Configurations
{
    public class GPUConfiguration : IEntityTypeConfiguration<GPU>
    {
        public void Configure(EntityTypeBuilder<GPU> builder)
        {
            builder.HasData(
                new GPU
                {
                    ProductId = 3,
                    Chipset = "GeForce RTX 4090",
                    VRAM = 24,
                    MemoryType = "GDDR6X",
                    MemoryClock = 21000,
                    Length = "336mm",
                    Cores = 16384
                },
                new GPU
                {
                    ProductId = 5,
                    Chipset = "Radeon RX 7900 XTX",
                    VRAM = 24,
                    MemoryType = "GDDR6",
                    MemoryClock = 20000,
                    Length = "324mm",
                    Cores = 6144
                }
            );
        }
    }
}
