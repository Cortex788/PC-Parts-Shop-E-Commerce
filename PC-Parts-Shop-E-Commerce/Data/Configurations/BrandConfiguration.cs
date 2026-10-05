using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PC_Parts_Shop_E_Commerce.Data.Models;

namespace PC_Parts_Shop_E_Commerce.Data.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(
                new Brand { Id = 1, Name = "Intel" },
                new Brand { Id = 2, Name = "AMD" },
                new Brand { Id = 3, Name = "NVIDIA" },
                new Brand { Id = 4, Name = "Corsair" }
            );
        }
    }
}
