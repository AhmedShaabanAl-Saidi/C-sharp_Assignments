using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class LibraryEngine
    {
        //a) Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
        //public static void ProcessBooks(List<Book> books, BookfunctionsDelegate bookfunctions)
        //{
        //    foreach (Book i in books)
        //        Console.WriteLine(bookfunctions.Invoke(i));
        //}

        //b) Use the Proper build in delegate. 
        public static void ProcessBooks(List<Book> books, Func<Book, string> bookfunctions)
        {
            foreach (Book i in books)
                Console.WriteLine(bookfunctions.Invoke(i));
        }
    }
}
