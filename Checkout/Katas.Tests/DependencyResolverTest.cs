using Katas.Contracts;
using Katas.Services;
using NUnit.Framework;
using System;
using System.Linq;

namespace Katas.Tests
{
    [TestFixture]
    public class DependencyResolverTest
    {
        [SetUp]
        public void Setup()
        {
            DependencyConfig.Setup();


        }
        [Test]
        public void ShouldDependencyRosolverWork()
        {
            var checkout = DependencyConfig.GetInstance<ICheckout>();
            Assert.True(checkout.GetType() == typeof(Checkout));

        }

    }
}
