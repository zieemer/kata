using System.Linq;
using AutoFixture;
using Checkout.Models;
using Checkout.Services;
using NUnit.Framework;

namespace Checkout.Tests.Models
{
    [TestFixture]
    public class InventoryServiceTests
    {

        private InventoryService _sut;
        private Fixture _fixture;

        [SetUp]
        public void Init()
        {
            _sut = new InventoryService();
            _fixture = new Fixture();

        }


        [Test]
        public void ShouldBeAbleAddStockItemToInventry()
        {
            var stockItem = _fixture.Create<StockItem>();
            _sut.Add(stockItem);
            Assert.AreEqual(stockItem, _sut.GetById(stockItem.SKU));
        }

        [Test]
        public void ShouldBeAbleToGetAllStock()
        {
            var stockItems = _fixture.CreateMany<StockItem>(10);

            foreach (var stockItem in stockItems)
            {
                _sut.Add(stockItem);
            }

            Assert.AreEqual(10, _sut.GetAll().Count());
        }

        [Test]

        public void ShouldSeedAddStockToService()
        {
            _sut.SeedStock();

            Assert.IsTrue(_sut.GetAll().Count() == 4);
        }
    }
}