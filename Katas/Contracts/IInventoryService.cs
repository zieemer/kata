using System.Collections.Generic;
using Katas.Models;

namespace Katas.Contracts
{
    public interface IInventoryService
    {
        void Add(StockItem stock);
        StockItem GetById(string sku);
        IEnumerable<StockItem> GetAll();
        void SeedStock();
    }
}