using Katas.Models;
using Katas.Services.PriceCalulators;
using NUnit.Framework;

namespace Katas.Tests.PriceCalculators
{
    [TestFixture]
    public class StandartClassCalulatorTests
    {
        private NoPromoTotalCalulator sut;


        [SetUp]
        public void SetUp()
        {
            sut = new NoPromoTotalCalulator();

        }
        [Test]
        public void ShouldCalulateStandardPrice()
        {
            var item = new BasketItem()
            {
                SKU = "a",
                Quantity = 10,
                StockItem = new StockItem()
                {

                    UnitPrice = 100,
                    Offer = new SpecialOffer()
                    {
                        Price = 200,
                        Qty = 3
                    }
                }
            };

            var result = sut.Calculate(item);
            // TODO: Add your test code here
            Assert.AreEqual(1000, result);
        }
    }
}
