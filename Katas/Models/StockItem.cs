﻿using System;
using System.Linq;

namespace Katas.Models
{
    public class StockItem
    {
        public string SKU { get; set; }
        public int UnitPrice { get; set; }
        public SpecialOffer Offer { get; set; }


    }
}
