using NUnit.Framework;
using System;
using VendingMachineTechTest;
namespace UnitTests
{
    [TestFixture()]
    public class Test
    {
        Credit credit;
        [SetUp]
        public void SetUp()
        {
            credit = new Credit();
        }

        [Test()]
        public void Test_if_class_is_instantiable()
        {
            Assert.IsInstanceOf<Credit>(credit);
        }

    }
}
