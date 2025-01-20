using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class InStoreOrderProcessor : Order , IOrderProcessor
    {
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * 0.05m;
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Processes orders placed in physical stores");
        }
    }
}
