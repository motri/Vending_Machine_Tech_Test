using System;
using System.Collections;
namespace VendingMachineTechTest
{
    public class Item
    {
        public Hashtable list;

        public Item()
        {
            list = new Hashtable();
            list.Add("Water", 0.60);
            list.Add("Crips", 0.40);
        }
    }
}
