using NUnit.Framework;
using System;
using VendingMachineTechTest;
namespace UnitTests
{
    [TestFixture()]
    public class VendingMachineClassTest
    {
        VendingMachine vendingMachine;

        [SetUp]
        public void SetUp()
        {
            vendingMachine = new VendingMachine();
        }
        [Test()]
        public void Instantiates_all_the_other_classes_when_initialised()
        {
            Assert.IsInstanceOf<Credit>(vendingMachine.credit);
            Assert.IsInstanceOf<Basket>(vendingMachine.basket);
            Assert.IsInstanceOf<Product>(vendingMachine.product);
            Assert.IsInstanceOf<Checkout>(vendingMachine.checkout);
            Assert.IsInstanceOf<Printer>(vendingMachine.printer);
            Assert.IsInstanceOf<Header>(vendingMachine.header);
        }


    }
}
