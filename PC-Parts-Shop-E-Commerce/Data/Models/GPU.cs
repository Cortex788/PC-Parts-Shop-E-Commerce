using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC_Parts_Shop_E_Commerce.Data.Models
{

    using static Common.EntityValidations;
    public class GPU
    {
        [Key, ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        [Required]
        [MinLength(GPUChipsetMinLength)]
        [MaxLength(GPUChipsetMaxLength)]
        public string Chipset { get; set; } = null!;

        [Range(GPUVRAMMinValue, GPUVRAMMaxValue)]
        public int VRAM { get; set; }

        [Required]
        public string MemoryType { get; set; } = null!;

        [Range(GPUMemoryClockMinValue, GPUMemoryClockMaxValue)]
        public int MemoryClock { get; set; }

        [Required]
        [Range(GPULengthMinValue, GPULengthMaxValue)]
        public string Length { get; set; } = null!;

        [Range(GPUCoresMinValue, GPUCoresMaxValue)]
        public int Cores { get; set; }

        public virtual Product? Product { get; set; }






    }
}
