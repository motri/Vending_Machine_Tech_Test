using System;
namespace VendingMachineTechTest
{
    public class Credit
    {
        public double total;

        public Credit()
        {
            total = 0;
        }

        public void Add(double coin)
        {
            total =+ coin;
        }
    }
}
