using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Katas.Contracts;
using Katas.Services;
using NUnit.Framework;

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
