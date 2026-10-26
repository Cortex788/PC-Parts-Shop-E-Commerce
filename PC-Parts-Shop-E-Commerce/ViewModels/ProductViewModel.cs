using System.ComponentModel.DataAnnotations;

namespace PC_Parts_Shop_E_Commerce.ViewModels
{
    using static Common.EntityValidations;
    public class ProductViewModel
    {

        [Required]
        [MinLength(ProductNameMinLength)]
        [MaxLength(ProductNameMaxLength)]
        public string ProductName { get; set; } = null!;

        [Required]
        [MinLength(ProductDescriptionMinLength)]
        [MaxLength(ProductDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Range(ProductPriceMinValue, (double)ProductPriceMaxValue)]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue)]
        public int StockQuantity { get; set; }

        [Required]
        public int BrandId { get; set; }
    }
}
