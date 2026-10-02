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
        [MinLength(GPUNameMinLength)]
        [MaxLength(GPUNameMaxLength)]
        public string Chipset { get; set; } = null!;

        [Range(0, 128)]
        public int VRAM { get; set; }

        [Required]
        public string MemoryType { get; set; } = null!;

        [Range(0, int.MaxValue)]
        public int MemoryClock { get; set; }

        [Required]
        [Range(0, 1000)]
        public string Length { get; set; } = null!;

        [Range(0, int.MaxValue)]
        public int Cores { get; set; }

        public virtual Product? Product { get; set; }






    }
}
