using System.Linq;
using AutoFixture;
using Katas.Models;
using Katas.Services;
using NUnit.Framework;

namespace Katas.Tests.Models
{
    [TestFixture]
    public class InventoryServiceTests
    {

        private InventoryService sut;
        private Fixture fixture;

        [SetUp]
        public void Init()
        {
            sut = new InventoryService();
            fixture = new Fixture();

        }


        [Test]
        public void ShouldBeAbleAddStockItemToInventry()
        {
            var stockItem = fixture.Create<StockItem>();
            sut.Add(stockItem);
            Assert.AreEqual(stockItem,  sut.GetById(stockItem.SKU));
        }

        [Test]
        public void ShouldBeAbleToGetAllStock()
        {
            var stockItems = fixture.CreateMany<StockItem>(10);

            foreach (var stockItem in stockItems)
            {
                sut.Add(stockItem);
            }
           
            Assert.AreEqual(10, sut.GetAll().Count());
        }

        [Test]

        public void ShouldSeedAddStockToService()
        {
            sut.SeedStock();

            Assert.IsTrue(sut.GetAll().Count()==4);
        }
    }
}