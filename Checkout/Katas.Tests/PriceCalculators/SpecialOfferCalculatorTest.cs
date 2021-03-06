﻿using Checkout.Models;
using Checkout.Services.PriceCalulators;
using NUnit.Framework;

namespace Checkout.Tests.PriceCalculators
{
    [TestFixture]
    public class SpecialOfferCalculatorTest
    {
        private SpecialOfferTotalCalculator sut;

        [SetUp]
        public void SetUp()
        {
            sut = new SpecialOfferTotalCalculator();
        }
        [Test]
        public void ShoulCalculatePromoPrice()
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
            Assert.AreEqual(700, result);
        }
    }
}
