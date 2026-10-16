namespace PC_Parts_Shop_E_Commerce.ModelsViews
{
    public class ProductCardViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; } = null!;

        public int StockQuantity { get; set; }
    }
}
