using System.Collections.Generic;
using Checkout.Models;

namespace Checkout.Contracts
{
    public interface IInventoryService
    {
        void Add(StockItem stock);
        StockItem GetById(string sku);
        IEnumerable<StockItem> GetAll();
        void SeedStock();
    }
}