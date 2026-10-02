using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC_Parts_Shop_E_Commerce.Data.Models
{
    public class RAM
    {
        [Key, ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public int Capacity { get; set; }

        [Required]
        public string MemoryType { get; set; } = null!;

        public int MemorySpeed { get; set; }

        public virtual Product? Product { get; set; }
    }
}
