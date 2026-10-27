using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace PC_Parts_Shop_E_Commerce.ViewModels
{
    using static Common.EntityValidations;
    public class AddEditGpuViewModel : ProductViewModel
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string? Description { get; set; } = null!;

        public string? ImageURL { get; set; }



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

        public IEnumerable<SelectListItem>? Brands { get; set; }
    }
}
