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

            #region LINQ – Transformation Operators
            // LINQ – Transformation Operators
            // 1. Return a sequence of just the names of a list of products.
            //var result = ProductList.Select(product => product.ProductName);

            //foreach (var product in result)
            //    Console.WriteLine(product);

            // 2.Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select(word => new
            //{
            //    Upper = word.ToUpper(),
            //    Lower = word.ToLower()
            //});

            //foreach (var i in result)
            //    Console.WriteLine($"Upper: {i.Upper}, Lower: {i.Lower}");

            // 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var result = ProductList.Select(product => new
            //{
            //    product.ProductID,
            //    product.ProductName,
            //    product.Category,
            //    product.UnitsInStock,
            //    Price = product.UnitPrice
            //});

            //foreach (var product in result)
            //    Console.WriteLine(product);

            // 4. Determine if the value of int in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Select((value, index) => value == index);

            //foreach (var value in result)
            //    Console.WriteLine(value);

            // 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var numbers = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select new { A = a, B = b };

            //foreach (var number in numbers)
            //    Console.WriteLine($"{number.A} is less than {number.B}");

            // 6. Select all orders where the order total is less than 500.00.
            //var result = CustomerList.SelectMany(customer => customer.Orders)
            //                          .Where(order => order.Total < 500.00m);

            //foreach (var order in result)
            //    Console.WriteLine(order);

            // 7. Select all orders where the order was made in 1998 or later.
            //var result = CustomerList.SelectMany(customer => customer.Orders)
            //                          .Where(order => order.OrderDate >= new DateTime(1998, 1, 1));

            //foreach (var order in result)
            //    Console.WriteLine(order); 
            #endregion
        }
    }
}
