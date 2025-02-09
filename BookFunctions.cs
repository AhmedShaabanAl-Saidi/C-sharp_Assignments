using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            if (book == null)
                return "Invalid Input";

            Console.WriteLine("********** Book Titles **********");

            return $"Book Title : {book.Title}";
        }

        public static string GetAuthers(Book book)
        {
            if (book == null)
                return "Invalid Input";

            Console.WriteLine("********** Book Authors **********");

            return $"Book Author: {string.Join(", ", book.Authers)}";
        }

        public static string GetPrice(Book book)
        {
            if (book == null)
                return "Invalid Input";

            Console.WriteLine("********** Book Prices **********");

            return $"Book Price : {book.Price:C}";
        }

       
    }
}
