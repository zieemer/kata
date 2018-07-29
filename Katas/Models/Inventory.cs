using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Models
{
    public interface IInventoryService
    {
        void Add(StockItem stock);
        StockItem GetById(string sku);
    }

    public class InventoryService : IInventoryService
    {
        private Dictionary<string,StockItem> Stocks { get; }

        public InventoryService()
        {
            Stocks = new Dictionary<string, StockItem>();

            //TODO
            InitStock();


        }

        private void InitStock()
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

            Stocks.Add(stockA.SKU,stockA);

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

        public void Add(StockItem stock)
        {
            Stocks.Add(stock.SKU, stock);
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
    }
}
