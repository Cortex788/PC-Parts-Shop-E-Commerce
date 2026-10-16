using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PC_Parts_Shop_E_Commerce.Data.Models;

namespace PC_Parts_Shop_E_Commerce.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "CPU" },
                new Category { Id = 2, Name = "GPU" },
                new Category { Id = 3, Name = "RAM" },
                new Category { Id = 4, Name = "Motherboard" }
            );
        }
    }
}
