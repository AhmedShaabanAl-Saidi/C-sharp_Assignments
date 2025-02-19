using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
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

            #region LINQ - Aggregate Operators
            // LINQ - Aggregate Operators
            //1.Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Count(element => element % 2 != 0);

            //Console.WriteLine(result);

            // 2.Return a list of customers and how many orders each has.
            //var result = CustomerList.Select(customer => new
            //{
            //    customer.CustomerName,
            //    Orders = customer.Orders.Count()
            //});

            //foreach (var customer in result)
            //    Console.WriteLine($"Customer Name: {customer.CustomerName}, Orders: {customer.Orders}");

            // 3.Return a list of categories and how many products each has
            //var result = ProductList.Select( product => new
            //{
            //    product.Category,
            //    Products = ProductList.Count(p => p.Category == product.Category)
            //});

            //foreach (var catogory in result)
            //    Console.WriteLine($"Category Name: {catogory.Category}, Products: {catogory.Products}");

            // 4.Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Sum();

            //Console.WriteLine(result);

            // 5.Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Sum(word => word.Length);

            //Console.WriteLine(result);

            // 6.Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Min(word => word.Length);

            //Console.WriteLine(result);

            // 7.Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Max(word => word.Length);

            //Console.WriteLine(result);

            // 8.Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Average(word => word.Length);

            //Console.WriteLine(result);

            // 9.Get the total units in stock for each product category.
            //var result = ProductList.Select(product => new
            //{
            //    product.Category,
            //    ProductsInStock = ProductList.Count(p => p.UnitsInStock != 0 && p.Category == product.Category)
            //});

            //foreach (var catogory in result)
            //    Console.WriteLine($"Category Name: {catogory.Category}, Products In Stock: {catogory.ProductsInStock}");

            // 10.Get the cheapest price among each category's products
            //var result = ProductList.Select(product => new
            //{
            //    product.Category,
            //    CheapestProduct = ProductList.Where(p => p.Category == product.Category).Min(p => p.UnitPrice)
            //}).Distinct();

            //foreach (var category in result)
            //    Console.WriteLine($"Category Name: {category.Category}, Cheapest Product Price: {category.CheapestProduct}");

            // 11.Get the products with the cheapest price in each category (Use Let)
            //var result = from product in ProductList
            //             group product by product.Category into categoryGroup
            //             let cheapestProductPrice = categoryGroup.Min(p => p.UnitPrice)
            //             select new
            //             {
            //                 Category = categoryGroup.Key,
            //                 CheapestProduct = cheapestProductPrice
            //             };

            //foreach (var category in result)
            //    Console.WriteLine($"Category Name: {category.Category}, Cheapest Product Price: {category.CheapestProduct}");

            // 12.Get the most expensive price among each category's products.
            //var result = ProductList.Select(product => new
            //{
            //    product.Category,
            //    CheapestProduct = ProductList.Where(p => p.Category == product.Category).Max(p => p.UnitPrice)
            //}).Distinct();

            //foreach (var category in result)
            //    Console.WriteLine($"Category Name: {category.Category}, Cheapest Product Price: {category.CheapestProduct}");

            // 13.Get the products with the most expensive price in each category.
            //var result = ProductList.Select(product => new
            //{
            //    product.Category,
            //    CheapestProduct = ProductList.Where(p => p.Category == product.Category).OrderByDescending(p => p.UnitPrice).FirstOrDefault()
            //}).Distinct();

            //foreach (var category in result)
            //    Console.WriteLine($"Category Name: {category.Category}, Expensive Product Price: {category.CheapestProduct}");

            // 14.Get the average price of each category's products.
            //var result = ProductList.Select(product => new
            //{
            //    product.Category,
            //    CheapestProduct = ProductList.Where(p => p.Category == product.Category).Average(p => p.UnitPrice)
            //}).Distinct();

            //foreach (var category in result)
            //    Console.WriteLine($"Category Name: {category.Category}, Average Product Price: {category.CheapestProduct}"); 
            #endregion

            // LINQ - Set Operators
        }
    }
}
