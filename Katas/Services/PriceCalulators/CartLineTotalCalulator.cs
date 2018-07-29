using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Katas.Contracts;
using Katas.Models;

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
