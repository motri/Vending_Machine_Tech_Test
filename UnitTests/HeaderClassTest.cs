using NUnit.Framework;
using System;
using System.IO;
using System.Collections;
using VendingMachineTechTest;
namespace UnitTests
{

    [TestFixture]
    public class HeaderClassTest
    {
		Header header;
        Hashtable productList;
        Decimal credit;

		[SetUp]
		public void SetUp()
		{
			header = new Header();
			productList = new Hashtable
			{
				{ "Water", 0.6m },
				{ "Crisps", 0.4m }
			};
            credit = 4.0m;
		}

        [Test]
        public void TestCase()
		{
			using (StringWriter headerOutput = new StringWriter())

			{
                Console.SetOut(headerOutput);
                header.Print(productList, credit);
                Assert.AreEqual("PRODUCTS: \nCrisps: 0,40 €\nWater: 0,60 €\nCREDIT: 4,00 €\n", headerOutput.ToString());

			}
       
        }
    }
}
