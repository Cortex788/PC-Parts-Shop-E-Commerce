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

        [Range(CPUCoresMinCount, CPUCoresMaxCount)]
        public int Cores { get; set; }

        [Range(CPUThreadsMinCount, CPUThreadsMaxCount)]
        public int Threads { get; set; }

        [Range(CPUBaseClockMinValue, CPUBaseClockMaxValue)]
        public int BaseClock { get; set; }

        [Range(CPUBoostClockMinValue, CPUBoostClockMaxValue)]
        public int BoostClock { get; set; }

        public string? IntegratedGraphics { get; set; }

        [Required]
        public string SocketType { get; set; } = null!;

        public virtual Product? Product { get; set; }
    }
}
