using Katas.Contracts;
using Katas.Models;
using System;
using System.Linq;

namespace Katas.Services.PriceCalulators
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
