using Katas.Contracts;
using Katas.Models;
using System;
using System.Linq;

namespace Katas.Services.PriceCalulators
{

    public class NoPromoTotalCalulator : ITotalLineCalculatorStrategy
    {
        public int Calculate(BasketItem item)
        {
            return item.Quantity * item.StockItem.UnitPrice;
        }
    }
}
