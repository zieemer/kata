using Katas.Models;

namespace Katas.Services.PriceCalulators
{
    public interface IPriceCalulator
    {
        int Calculate(BasketItem item);
    }
}