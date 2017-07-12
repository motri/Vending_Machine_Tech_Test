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
        Hashtable basketItems;

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
			basketItems = new Hashtable
			{
				{ "Water", 3 },
				{ "Crisps", 2 }
			};
		}

        [Test]
        public void TestCase()
		{
			using (StringWriter headerOutput = new StringWriter())

			{
                Console.SetOut(headerOutput);
                header.Print(productList, credit, basketItems);
                Assert.AreEqual("PRODUCTS: \nCrisps: 0,40 €\nWater: 0,60 €\n" +
                                "CREDIT: 4,00 €\n" +
                                "BASKET:\n2 Crisps\n3 Water\n", headerOutput.ToString());
			}
       
        }
    }
}
