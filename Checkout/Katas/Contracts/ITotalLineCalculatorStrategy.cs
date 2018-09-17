using Katas.Models;

namespace Katas.Contracts
{
    public interface ITotalLineCalculatorStrategy
    {
        int Calculate(BasketItem item);
    }
}