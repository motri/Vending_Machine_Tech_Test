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
            list.Add("Water", 0.60);
            list.Add("Crisps", 0.40);
        }
    }
}
