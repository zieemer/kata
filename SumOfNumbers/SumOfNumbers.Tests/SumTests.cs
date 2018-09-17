using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers.Tests
{
    [TestFixture]
    public class SumTests
    {
        [Test]
        [TestCase(0, 1, 1)]
        [TestCase(1, 2, 3)]
        [TestCase(1, 0, 1)]
        [TestCase(0, 1, 1)]
        [TestCase(-1,2,2)]
        public void SumShouldReturnRightResult(int a, int b, int exp)
        {
           var sut = new Sum();

            var result = sut.GetSum(a, b);

            Assert.AreEqual(exp,result);
        }
    }
}
