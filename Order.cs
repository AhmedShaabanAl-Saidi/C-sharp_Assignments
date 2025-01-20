using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public decimal OrderAmount { get; set; }
        public IOrderProcessor OrderProcessor { get; set; }

        public void Process()
        {
            Console.Clear();
            OrderProcessor.ProcessOrder();
            decimal discount = OrderProcessor.CalculateDiscount(OrderAmount);
            Console.WriteLine($"Order ID: {OrderId}\nCustomer Name: {CustomerName}\nOrder Amount: {OrderAmount:C}\nDiscount: {discount}\nOrder Amount After Discount: {OrderAmount-discount:C}");
        }
    }
}
