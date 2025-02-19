using static Assignment1_C_.ListGenerators;

namespace Assignment1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators
            // LINQ - Element Operators
            // 1.Get first Product out of Stock
            //var result = ProductList.First(product => product.UnitsInStock == 0);

            //Console.WriteLine(result);

            // 2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProductList.FirstOrDefault(product => product.UnitPrice > 1000);

            //Console.WriteLine(result);

            // 3.Retrieve the second number greater than 5
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where(num => num > 5)
            //    .OrderBy(num => num).ElementAt(1);

            //Console.WriteLine(result); 
            #endregion
        }
    }
}
