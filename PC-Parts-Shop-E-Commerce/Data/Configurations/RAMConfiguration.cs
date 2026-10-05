using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PC_Parts_Shop_E_Commerce.Data.Models;

namespace PC_Parts_Shop_E_Commerce.Data.Configurations
{
    public class RAMConfiguration : IEntityTypeConfiguration<RAM>
    {
        public void Configure(EntityTypeBuilder<RAM> builder)
        {
            builder.HasData(
                new RAM
                {
                    ProductId = 4,
                    Capacity = 32,
                    MemoryType = "DDR4",
                    MemorySpeed = 3200
                }
            );
        }
    }
}
