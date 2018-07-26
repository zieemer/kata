using Katas.Models;

namespace Katas.Services.PriceCalulators
{
    public class SpecialOfferCalculator : IPriceCalulator
    {
        public int Calculate(BasketItem item)
        {
            int promoBundle = ( item.Quatity/ item.Offer.Qty ) * item.Offer.Price;
            int reset = ( item.Quatity % item.Offer.Qty ) * item.UnitPrice;

            return promoBundle + reset;
        }
    }
}