using System;
using System.Collections;
namespace VendingMachineTechTest
{
    public class Header
    {
        public Header()
        {
        }

        public void Print(Hashtable productList, decimal credit, Hashtable basketItems)
        {
            Console.WriteLine("PRODUCTS: ");

            foreach (DictionaryEntry pair in productList)
            {
                Console.WriteLine("{0}: {1:C}", pair.Key, pair.Value);
            }

            Console.WriteLine("CREDIT: {0:C}", credit);
            Console.WriteLine("BASKET:");

            foreach (DictionaryEntry pair in basketItems)
            {
                Console.WriteLine("{0} {1}", pair.Value, pair.Key);
            }
        }
    }
}
