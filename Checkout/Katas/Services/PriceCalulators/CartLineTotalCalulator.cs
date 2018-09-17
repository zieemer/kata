using Checkout.Contracts;
using Checkout.Models;

namespace Checkout.Services.PriceCalulators
{
    public class CartLineTotalCalulator
    {
        private readonly ITotalLineCalculatorStrategy _totalCalulatorStrategy;

        public CartLineTotalCalulator(ITotalLineCalculatorStrategy totalCalulatorStrategy)
        {
            _totalCalulatorStrategy = totalCalulatorStrategy;
        }

        public int GetTotal(BasketItem item)
        {
            return _totalCalulatorStrategy.Calculate(item);
        }
    }
}
