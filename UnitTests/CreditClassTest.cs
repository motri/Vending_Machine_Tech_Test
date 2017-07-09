using NUnit.Framework;
using System;
using System.IO;
using VendingMachineTechTest;
namespace CreditClassTest
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
        public void Credit_class_is_instantiable()
        {
            Assert.IsInstanceOf<Credit>(credit);
        }

        [Test()]
        public void Initial_credit_total_is_0()
        {
            Assert.AreEqual(credit.total, 0);
        }

        [Test()]
        public void Add_method_adds_credit_to_total()
        {
            credit.Add(0.50);
            Assert.AreEqual(credit.total, 0.50);
        }

        [Test()]
        public void Add_method_only_allows_multiples_of_50p()
        {
            using (StringWriter sw = new StringWriter())  
			{
				Console.SetOut(sw);
	            credit.Add(0.70);
				Assert.AreEqual("Incorrect change added.\n", sw.ToString());
			}
		}
    }
}
