using NUnit.Framework;
using System;
using VendingMachineTechTest;
namespace UnitTests
{
    [TestFixture()]
    public class BasketClassTest
    {
        Basket basket;
        [SetUp]
        public void SetUp()
        {
            basket = new Basket();
        }
        [Test()]
        public void TestCase()
        {
            Assert.IsInstanceOf<Basket>(basket);
        }
    }
}
