using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Katas.Contracts;
using Katas.Models;

namespace Katas.Services
{
    public class Checkout : ICheckout
    {
        private Dictionary<string, BasketItem> _cart;

        public Checkout()
        {
            _cart = new Dictionary<string, BasketItem>();
        }
        public int GetTotal()
        {
            var total = 0;
            foreach (var item in _cart)
            {
                var priceCalculationStrategy = PricingMethod.Get(item.Value);
            }

            return total;
        }

        public void Scan(string sku)
        {
            if (_cart.ContainsKey(sku))
            {
                _cart[sku].Quatity++;
            }
            else
            {
                _cart.Add(sku, new BasketItem(){SKU = sku, Quatity = 1, UnitPrice = 50});
            }
        }
    }
}
