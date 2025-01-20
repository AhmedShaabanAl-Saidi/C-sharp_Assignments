using System.Diagnostics;
using Assignment1_C_;

namespace Assignment1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the order details from the user
            Console.Write("Input the Order ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Input the Customer Name: ");
            string customerName = Console.ReadLine();

            Console.Write("Input Order Amount: ");
            decimal orderAmount = decimal.Parse(Console.ReadLine());

            Console.Write("Input the Order Type (online/instore): ");
            string orderType = Console.ReadLine();

            // Create an order processor object
            IOrderProcessor processor;

            if (orderType.ToLower() == "online")
            {
                processor = new OnlineOrderProcessor();
            }
            else if (orderType.ToLower() == "instore")
            {
                processor = new InStoreOrderProcessor();
            }
            else
            {
                Console.WriteLine("Invalid order type! Try again.");
                return;
            }

            // Create an order object
            Order order = new Order
            {
                OrderId = id,
                CustomerName = customerName,
                OrderAmount = orderAmount,
                OrderProcessor = processor
            };

            order.Process();
        }
    }
}