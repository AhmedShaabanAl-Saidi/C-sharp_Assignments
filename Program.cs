using System.Runtime.Intrinsics.Arm;
using System.Threading;
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

            #region LINQ - Ordering Operators
            // LINQ - Ordering Operators
            // 1. Sort a list of products by name
            //var result = ProductList.OrderBy(product => product.ProductName);

            //foreach (var product in result)
            //    Console.WriteLine(product);

            // 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //String [] Arr = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};

            //var result = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var product in result)
            //    Console.WriteLine(product);

            // 3. Sort a list of products by units in stock from highest to lowest.
            //var result = ProductList.OrderByDescending(product => product.UnitsInStock);

            //foreach (var product in result)
            //    Console.WriteLine(product);

            // 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.OrderBy(name => name.Length)
            //            .ThenBy(name => name);

            //foreach (var name in result)
            //    Console.WriteLine(name);

            // 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(word => word.Length)
            //            .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result)
            //    Console.WriteLine(word);

            // 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var result = ProductList.OrderBy(product => product.Category)
            //                        .ThenByDescending(product => product.UnitPrice);

            //foreach (var word in result)
            //    Console.WriteLine(word);

            // 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(word => word.Length)
            //            .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result)
            //    Console.WriteLine(word);

            // 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where(word => word[1] == 'i')
            //            .Reverse();

            //foreach (var word in result)
            //    Console.WriteLine(word); 
            #endregion


        }
    }
}
