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
        private readonly IInventoryService _inventoryService;
        private Dictionary<string, BasketItem> _cart;

        public Checkout(IInventoryService inventoryService)
        {
            _cart = new Dictionary<string, BasketItem>();
            _inventoryService = inventoryService;
        }
        public int GetTotal()
        {
            var total = 0;
            foreach (var item in _cart)
            {
                var priceCalculationStrategy = PricingMethod.Get(item.Value.StockItem);

                total += priceCalculationStrategy.Calculate(item.Value);
            }

            return total;
        }

        public void Scan(string sku)
        {
            if (_cart.ContainsKey(sku))
            {
                _cart[sku].Quantity++;
            }
            else
            {
                var stockItem =  _inventoryService.GetById(sku);
                var basketItem = new BasketItem()
                {
                    Quantity = 1,
                    StockItem = stockItem,
                    SKU = stockItem.SKU,
                };
                _cart.Add(stockItem.SKU, basketItem);
            }
        }
    }
}
