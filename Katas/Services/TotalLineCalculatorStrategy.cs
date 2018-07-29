using System.Collections.Generic;
using Katas.Contracts;
using Katas.Models;
using Katas.Services.PriceCalulators;

namespace Katas.Services
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