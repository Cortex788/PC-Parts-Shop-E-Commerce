using PC_Parts_Shop_E_Commerce.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC_Parts_Shop_E_Commerce.Data.Models
{

    using static PC_Parts_Shop_E_Commerce.Common.EntityValidations;
    public class Motherboard
    {
        [Key, ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        [Required]
        [MinLength(MotherboardNameMinLength)]
        [MaxLength(MotherboardNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MinLength(MotherboardChipsetMinLength)]
        [MaxLength(MotherboardChipsetMaxLength)]
        public string Chipset { get; set; } = null!;

        public FormFactor FormFactor { get; set; }

        [Required]
        [MinLength(MotherboardSocketMinLength)]
        [MaxLength(MotherboardSocketMaxLength)]
        public string Socket { get; set; } = null!;

        public MemoryType MemoryType { get; set; }

        [Required]
        [Range(MotherboardMemorySlotsMinValue, MotherboardMemorySlotsMaxValue)]
        public int MemorySlots { get; set; }



        public virtual Product? Product { get; set; }
    }
}
