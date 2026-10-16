using System.ComponentModel.DataAnnotations;

namespace PC_Parts_Shop_E_Commerce.ModelsViews
{
    public class RamCardViewModel : ProductCardViewModel
    {
        public int Capacity { get; set; }

        public string MemoryType { get; set; }

        public int MemorySpeed { get; set; }
    }
}
