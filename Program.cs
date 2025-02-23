using static Assignment1_C_.ListGenerator;

namespace Assignment1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  LINQ - Partitioning Operators
            // LINQ - Partitioning Operators
            // 1. Get the first 3 orders from customers in Washington
            //var result = CustomerList.Where(customer => customer.Country == "USA")
            //    .SelectMany(customer => customer.Orders)
            //    .Take(3);

            //foreach (var order in result)
            //    Console.WriteLine(order);

            // 2. Get all but the first 2 orders from customers in Washington.
            //var result = CustomerList.Where(customer => customer.Country == "USA")
            //    .SelectMany(customer => customer.Orders)
            //    .Skip(2);

            //foreach (var order in result)
            //    Console.WriteLine(order);

            // 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((number,index) => index < number);

            //foreach (var number in result)
            //    Console.WriteLine(number);

            // 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(number => number % 3 != 0);

            //foreach (var number in result)
            //    Console.WriteLine(number);

            // 5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((number,index) => number > index);

            //foreach (var number in result)
            //    Console.WriteLine(number); 
            #endregion
        }
    }
}
