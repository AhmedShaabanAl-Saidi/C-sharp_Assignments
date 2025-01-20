using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class OnlineOrderProcessor : Order , IOrderProcessor
    {
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * 0.10m;
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Processes orders placed online");
        }
    }
}
