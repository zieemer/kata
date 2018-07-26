using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Katas.Models;
using Katas.Services;
using NUnit.Framework.Internal;

namespace Katas.Tests
{
    [TestFixture]
    public class CheckOutTests
    {
        private Checkout sut;

        [SetUp]
        public void Setup()
        {
            sut = new Checkout();
        }
        [Test]
        public void ShouldItemBeAddedToBasket()
        {

            var itemA = new StockItem()
            {
                SKU = "A",
                UnitPrice = 50
            };

            var itemB = new StockItem()
            {
                SKU = "C",
                UnitPrice = 50
            };

            // TODO: Add your test code here
            sut.Scan(itemB.SKU);
            sut.Scan(itemB.SKU);
            sut.Scan(itemA.SKU);


            Assert.That(sut.GetTotal(), Is.EqualTo(150));



        }
    }
}
