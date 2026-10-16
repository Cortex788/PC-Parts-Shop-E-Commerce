namespace PC_Parts_Shop_E_Commerce.ModelsViews
{
    public class CpuCardViewModel : ProductCardViewModel
    {
        public int Cores { get; set; }

        public int Threads { get; set; }

        public int BaseClock { get; set; }

        public int BoostClock { get; set; }

        public string? IntegratedGraphics { get; set; }

        public string SocketType { get; set; } = null!;
    }
}
