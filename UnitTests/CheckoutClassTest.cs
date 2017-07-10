using NUnit.Framework;
using System;
using VendingMachineTechTest;
namespace UnitTests
{
    [TestFixture()]
    public class CheckoutClassTest
    {
        Checkout checkout;
        [SetUp]
        public void SetUp()
        {
            checkout = new Checkout();
        }

        [Test()]
        public void Class_can_be_instantiated()
        {
            Assert.IsInstanceOf<Checkout>(checkout);
        }
    }
}
