using Checkout.Contracts;
using Checkout.Models;
using Checkout.Services.PriceCalulators;

namespace Checkout.Services
{
    public class TotalLineCalculatorStrategy
    {
        public static ITotalLineCalculatorStrategy Get(StockItem item)
        {
            if (item.Offer != null)
            {
                return new SpecialOfferTotalCalculator();
            }
            else
            {
                return new NoPromoTotalCalulator();
            }
        }
    }
}