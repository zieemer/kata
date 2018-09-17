using Katas.Contracts;
using Katas.Models;
using Katas.Services.PriceCalulators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas.Services
{
    public class Checkout : ICheckout
    {
        private readonly IInventoryService _inventoryService;
        private readonly Dictionary<string, BasketItem> _cart;

        public Checkout(IInventoryService inventoryService)
        {
            _cart = new Dictionary<string, BasketItem>();
            _inventoryService = inventoryService;

        }
        public int GetTotal()
        {

            return _cart.Sum(s => new CartLineTotalCalulator(totalCalulatorStrategy: TotalLineCalculatorStrategy.Get(s.Value.StockItem)).GetTotal(s.Value));
        }

        public void Scan(string sku)
        {
            if (_cart.ContainsKey(sku))
            {
                _cart[sku].Quantity++;
            }
            else
            {
                var stockItem = _inventoryService.GetById(sku);

                if (stockItem == null)
                {
                    Console.WriteLine($"!!! Stock item with SKU:{sku} doesn't exits !!!");
                    return;
                }
                var basketItem = new BasketItem()
                {
                    Quantity = 1,
                    StockItem = stockItem,
                    SKU = stockItem.SKU,
                };
                _cart.Add(stockItem.SKU, basketItem);
            }

            Console.WriteLine("Your Shopping Basket:");
            Console.WriteLine("----------------------|");
            Console.WriteLine("| Item SKU | Qty      |");
            Console.WriteLine("----------------------|");
            foreach (var item in _cart)
            {
                Console.WriteLine($"| Item {item.Key}   | {item.Value.Quantity}        ");
            }
            Console.WriteLine("----------------------|");
        }
    }
}
