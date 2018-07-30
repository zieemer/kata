using Katas.Models;
using System.Collections.Generic;

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