using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using static Assignment1_C_.ListGenerator;
using System.Linq;

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

            #region LINQ – Grouping Operators
            // LINQ – Grouping Operators
            // 1.Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int>{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(number => number % 5);

            //foreach (var group in result)
            //{
            //    Console.WriteLine("Remainder: " + group.Key);

            //    foreach (var number in group)
            //        Console.WriteLine(number);
            //}

            // 2.Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.GroupBy(word => word[0]);

            // foreach (var group in result)
            // {
            //     Console.WriteLine("Words that start with: " + group.Key);

            //     foreach (var word in group)
            //         Console.WriteLine(word);

            //     Console.WriteLine("*********************************");
            // }

            // Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            //var result = Arr.GroupBy(word => word, new MatchesWordsEqualityComparer());

            //foreach (var group in result)
            //{
            //    foreach (var word in group)
            //        Console.WriteLine(word);

            //    Console.WriteLine("*********************************");
            //} 
            #endregion
        }
    }
}
