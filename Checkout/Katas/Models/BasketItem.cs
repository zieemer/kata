namespace Checkout.Models
{
    public class BasketItem
    {
        public string SKU { get; set; }
        public int Quantity { get; set; }
        public StockItem StockItem { get; set; }
    }
}