using Microsoft.AspNetCore.Mvc.Rendering;

namespace PC_Parts_Shop_E_Commerce.ViewModels
{
    using static Common.EntityValidations;
    public class AddEditRamViewModel : ProductViewModel
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string? Description { get; set; } = null!;

        public string? ImageURL { get; set; }

        public int Capacity { get; set; }

        public string MemoryType { get; set; } = null!;

        public int MemorySpeed { get; set; }

        public IEnumerable<SelectListItem>? Brands { get; set; }

    }
}
