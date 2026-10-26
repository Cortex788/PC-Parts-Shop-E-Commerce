using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using static PC_Parts_Shop_E_Commerce.Common.EntityValidations;

namespace PC_Parts_Shop_E_Commerce.ViewModels
{
    public class AddEditCpuViewModel : ProductViewModel
    {
        public int ProductId {get ; set; }

        public int CategoryId { get; set; }

        public string? Description { get; set; } = null!;

        public string? ImageURL { get; set; }

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

        public IEnumerable<SelectListItem>? Brands { get; set; }
    }
}
