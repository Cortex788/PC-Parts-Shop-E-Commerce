using System.ComponentModel.DataAnnotations;

namespace PC_Parts_Shop_E_Commerce.Data.Models
{
    using static Common.EntityValidations;

    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(CategoryNameMinLength)]
        [MaxLength(CategoryNameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
