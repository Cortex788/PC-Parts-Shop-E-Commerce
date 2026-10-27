using Microsoft.AspNetCore.Mvc.Rendering;
using PC_Parts_Shop_E_Commerce.Data.Enums;
using PC_Parts_Shop_E_Commerce.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace PC_Parts_Shop_E_Commerce.ViewModels
{
    using static Common.EntityValidations;
    public class AddEditMotherboardViewModel : ProductViewModel
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string? Description { get; set; } = null!;

        public string? ImageURL { get; set; }

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

        public IEnumerable<SelectListItem>? Brands { get; set; }
    }
}
