using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PC_Parts_Shop_E_Commerce.Data.Models;
using PC_Parts_Shop_E_Commerce.Data.Enums;

namespace PC_Parts_Shop_E_Commerce.Data.Configurations
{
    public class MotherboardConfiguration : IEntityTypeConfiguration<Motherboard>
    {
        public void Configure(EntityTypeBuilder<Motherboard> builder)
        {
            builder.HasData(
                new Motherboard
                {
                    ProductId = 6,
                    Name = "ROG Strix Z790-E Gaming",
                    Chipset = "Z790",
                    FormFactor = FormFactor.ATX,
                    Socket = "LGA1700",
                    MemoryType = MemoryType.DDR5,
                    MemorySlots = 4
                }
                ,
                new Motherboard
                {
                    ProductId = 7,
                    Name = "MPG Z790 Carbon WiFi",
                    Chipset = "Z790",
                    FormFactor = FormFactor.ATX,
                    Socket = "LGA1700",
                    MemoryType = MemoryType.DDR5,
                    MemorySlots = 4
                },
                new Motherboard
                {
                    ProductId = 8,
                    Name = "X670E AORUS Master",
                    Chipset = "X670E",
                    FormFactor = FormFactor.ATX,
                    Socket = "AM5",
                    MemoryType = MemoryType.DDR5,
                    MemorySlots = 4
                },
                new Motherboard
                {
                    ProductId = 9,
                    Name = "TUF Gaming B650-PLUS",
                    Chipset = "B650",
                    FormFactor = FormFactor.ATX,
                    Socket = "AM5",
                    MemoryType = MemoryType.DDR5,
                    MemorySlots = 4
                },
                new Motherboard
                {
                    ProductId = 10,
                    Name = "MAG B650 Tomahawk",
                    Chipset = "B650",
                    FormFactor = FormFactor.ATX,
                    Socket = "AM5",
                    MemoryType = MemoryType.DDR5,
                    MemorySlots = 4
                }
            );
        }
    }
}
