using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Katas.Models;

namespace Katas.Models
{
    public class StockItem
    {
        public string SKU { get; set; }
        public int UnitPrice { get; set; }
        public SpecialOffer Offer { get; set; }
        

    }

    public class BasketItem
    {
        public string SKU { get; set; }
        public int Quantity { get; set; }
        public StockItem StockItem { get; set; }
    }
}
