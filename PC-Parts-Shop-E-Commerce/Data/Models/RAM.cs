using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC_Parts_Shop_E_Commerce.Data.Models
{
    using static Common.EntityValidations;  
    public class RAM
    {
        [Key, ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        [Required]
        [Range(RAMCapacityMinValue, RAMCapacityMaxValue)]
        public int Capacity { get; set; }


        public string MemoryType { get; set; } = null!;

        [Range(RAMMemorySpeedMinValue, RAMMemorySpeedMaxValue)]
        public int MemorySpeed { get; set; }

        public virtual Product? Product { get; set; }
    }
}
