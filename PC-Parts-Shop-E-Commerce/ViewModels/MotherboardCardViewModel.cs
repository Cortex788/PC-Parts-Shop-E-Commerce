using PC_Parts_Shop_E_Commerce.Data.Enums;

namespace PC_Parts_Shop_E_Commerce.ModelsViews
{
    public class MotherboardCardViewModel : ProductCardViewModel
    {
        public string Chipset { get; set; } = null!;
        public FormFactor FormFactor { get; set; }
        public string Socket { get; set; } = null!;
        public MemoryType MemoryType { get; set; }
        public int MemorySlots { get; set; }
    }
}
