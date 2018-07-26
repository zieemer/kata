using System.Collections.Generic;
using Katas.Models;
using Katas.Services.PriceCalulators;

namespace Katas.Services
{
    public class PricingMethod
    {
        public static IPriceCalulator Get(StockItem item)
        {
            if (item.Offer != null)
            {
                return new SpecialOfferCalculator();
            }
            else
            {
                return new StandartCalulator();
            }
        }
    }
}