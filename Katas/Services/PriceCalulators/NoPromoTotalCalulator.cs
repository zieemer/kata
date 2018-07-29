using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Katas.Contracts;
using Katas.Models;

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
