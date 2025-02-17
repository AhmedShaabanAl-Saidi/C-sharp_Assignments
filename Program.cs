using static Assignment1_C_.ListGenerator;

namespace Assignment1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            // LINQ - Restriction Operators
            // 1. Find all products that are out of stock.
            //var result = ProductList.Where(product => product.UnitsInStock == 0);

            //foreach (var product in result)
            //    Console.WriteLine(product);

            // 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var result = ProductList.Where(product => product.UnitsInStock != 0 && product.UnitPrice > 3.00m);

            //foreach (var product in result)
            //    Console.WriteLine(product);

            // 3. Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where((name, index) => name.Length < index);

            //foreach (var product in result)
            //    Console.WriteLine(product); 
            #endregion
        }
    }
}
