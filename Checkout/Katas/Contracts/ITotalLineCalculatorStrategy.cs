using Checkout.Models;

namespace Checkout.Contracts
{
    public interface ITotalLineCalculatorStrategy
    {
        int Calculate(BasketItem item);
    }
}