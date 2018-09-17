using Checkout.Contracts;
using Checkout.Models;

namespace Checkout.Services.PriceCalulators
{

    public class NoPromoTotalCalulator : ITotalLineCalculatorStrategy
    {
        public int Calculate(BasketItem item)
        {
            return item.Quantity * item.StockItem.UnitPrice;
        }
    }
}
