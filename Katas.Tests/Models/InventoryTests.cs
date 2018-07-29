using NUnit.Framework;
using Katas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;

namespace Katas.Models.Tests
{
    [TestFixture]
    public class InventoryTests
    {

        private InventoryService sut;
        private Fixture fixture;

        [SetUp]
        public void Init()
        {
            sut = new InventoryService();
            fixture = new Fixture();

        }


        [Test()]
        public void ShouldBeAbleAddStockItemToInventry()
        {
            var stockItem = fixture.Create<StockItem>();
            sut.Add(stockItem);
            

            Assert.AreEqual(stockItem,  sut.GetById(stockItem.SKU));
        }
    }
}