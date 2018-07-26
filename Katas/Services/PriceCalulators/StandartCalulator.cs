using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Katas.Models;

namespace Katas.Services.PriceCalulators
{

    public class StandartCalulator : IPriceCalulator
    {
        public int Calculate(BasketItem item)
        {
            return item.Quatity * item.UnitPrice;
        }
    }
}
