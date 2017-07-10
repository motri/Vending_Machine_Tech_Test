using System;
using System.Collections;
namespace VendingMachineTechTest
{
    public class Product
    {
        public Hashtable list;

        public Product()
        {
            list = new Hashtable
            {
                { "Water", 0.6m },
                { "Crisps", 0.4m }
            };
        }
    }
}
