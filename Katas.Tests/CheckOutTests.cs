using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;
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
        private Fixture fixture;

        [SetUp]
        public void Setup()
        {
            fixture = new Fixture();
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
                SKU = "C",
                UnitPrice = 50
            };

            moqInventoryService.Setup(s=>s.GetById("A")).Returns(itemA);
            moqInventoryService.Setup(s => s.GetById("B")).Returns(itemB);


            sut = new Checkout(moqInventoryService.Object);
        }
        [Test]
        public void ShouldItemBeAddedToBasket()
        {

            

            // TODO: Add your test code here
            sut.Scan("A");
            sut.Scan("A");
            sut.Scan("B");


            Assert.That(sut.GetTotal(), Is.EqualTo(180));



        }
    }
}
