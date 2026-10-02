using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PC_Parts_Shop_E_Commerce.Data.Models
{

    using static Common.EntityValidations;
    public class CPU
    {
        [Key, ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        [Required]
        [MinLength(CPUNameMinLength)]
        [MaxLength(CPUNameMaxLength)]
        public string Name { get; set; } = null!;

        [Range(1,256)]
        public int Cores { get; set; }

        [Range(1, 512)]
        public int Threads { get; set; }

        [Range(1, 10000)]
        public int BaseClock { get; set; }

        [Range(1, 10000)]
        public int BoostClock { get; set; }

        public string? IntegratedGraphics { get; set; }

        [Required]
        public string SocketType { get; set; } = null!;

        public virtual Product? Product { get; set; }
    }
}
