using System.ComponentModel.DataAnnotations;

namespace PC_Parts_Shop_E_Commerce.Data.Models
{
    public class RAM
    {
        public int ProductId { get; set; }

        public int Capacity { get; set; }

        [Required]
        public string MemoryType { get; set; } = null!;

        public int MemorySpeed { get; set; }

        public virtual Product? Product { get; set; }
    }
}
