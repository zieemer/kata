using Checkout.Contracts;
using Checkout.Models;
using Moq;
using NUnit.Framework;

namespace Checkout.Tests
{
    [TestFixture]
    public class CheckOutTests
    {
        private Checkout.Services.Checkout sut;


        [SetUp]
        public void Setup()
        {

            var moqInventoryService = new Mock<IInventoryService>();

            var itemA = new StockItem()
            {
                SKU = "A",
                UnitPrice = 50,
                Offer = new SpecialOffer()
                {
                    Price = 130,
                    Qty = 2
                }
            };

            var itemB = new StockItem()
            {
                SKU = "B",
                UnitPrice = 30,
                Offer = new SpecialOffer()
                {
                    Price = 45,
                    Qty = 2
                }
            };

            moqInventoryService.Setup(s => s.GetById("A")).Returns(itemA);
            moqInventoryService.Setup(s => s.GetById("B")).Returns(itemB);

            sut = new Checkout.Services.Checkout(moqInventoryService.Object);
        }
        [Test]
        public void ShouldPriceForTwoBAndOneABe95()
        {

            sut.Scan("B");
            sut.Scan("A");
            sut.Scan("B");

            Assert.That(sut.GetTotal(), Is.EqualTo(95));



        }
    }
}
