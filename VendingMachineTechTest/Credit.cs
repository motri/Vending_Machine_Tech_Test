using System;
namespace VendingMachineTechTest
{
    public class Credit
    {
        public decimal total;

        public Credit()
        {
            total = 0.0m;
        }

        public void Add(decimal coin)
        {
            if (coin % 0.5m == 0){
             total = +coin;   
            } else {
                Console.WriteLine("Incorrect change added.");
            }

        }
    }
}
