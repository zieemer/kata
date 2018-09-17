using System.Collections.Generic;
using System.Linq;
using Checkout.Contracts;
using Checkout.Models;

namespace Checkout.Services
{
    public class InventoryService : IInventoryService
    {

        public InventoryService()
        {
            Stocks = new Dictionary<string, StockItem>();
        }

        private Dictionary<string, StockItem> Stocks { get; }

        public void Add(StockItem stock)
        {
            Stocks.Add(stock.SKU, stock);
        }

        public IEnumerable<StockItem> GetAll()
        {
            return Stocks.Select(s => s.Value).ToList();
        }

        public StockItem GetById(string sku)
        {
            if (Stocks.ContainsKey(sku))
            {
                return Stocks[sku];
            }

            else
            {
                return null;
            }
        }

        public void SeedStock()
        {
            var stockA = new StockItem()
            {
                SKU = "A",
                UnitPrice = 50,
                Offer = new SpecialOffer()
                {
                    Price = 130,
                    Qty = 3
                }

            };

            Stocks.Add(stockA.SKU, stockA);

            var stockB = new StockItem()
            {
                SKU = "B",
                UnitPrice = 30,
                Offer = new SpecialOffer()
                {
                    Price = 45,
                    Qty = 2
                }

            };

            Stocks.Add(stockB.SKU, stockB);

            var stockC = new StockItem()
            {
                SKU = "C",
                UnitPrice = 20


            };

            Stocks.Add(stockC.SKU, stockC);

            var stockD = new StockItem()
            {
                SKU = "D",
                UnitPrice = 15,


            };

            Stocks.Add(stockD.SKU, stockD);
        }
    }
}
