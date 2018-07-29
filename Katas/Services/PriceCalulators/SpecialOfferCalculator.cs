using Katas.Contracts;
using Katas.Models;

namespace Katas.Services.PriceCalulators
{
    public class SpecialOfferTotalCalculator : ITotalLineCalculatorStrategy
    {
        public int Calculate(BasketItem item)
        {
            int promoBundle = ( item.Quantity/ item.StockItem.Offer.Qty ) * item.StockItem.Offer.Price;
            int reset = ( item.Quantity % item.StockItem.Offer.Qty ) * item.StockItem.UnitPrice;

            return promoBundle + reset;
        }
    }
}