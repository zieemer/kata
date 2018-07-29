using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;
using Katas.Contracts;
using Katas.Models;
using Katas.Services;
using Moq;
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

            moqInventoryService.Setup(s=>s.GetById("A")).Returns(itemA);
            moqInventoryService.Setup(s => s.GetById("B")).Returns(itemB);

            sut = new Checkout(moqInventoryService.Object);
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
