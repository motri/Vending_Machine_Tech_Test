using System;
using System.Collections;
namespace VendingMachineTechTest
{
    public class Product
    {
        public Hashtable list;

        public Product()
        {
            list = new Hashtable();
            list.Add("Water", 0.6m);
            list.Add("Crisps", 0.4m);
        }
    }
}
