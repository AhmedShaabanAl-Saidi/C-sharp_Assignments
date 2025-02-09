namespace Assignment1_C_
{
    // a)Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
    public delegate string BookfunctionsDelegate(Book book );
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 01
            // 1.Try Every Point Covered in the Lecture.
            //int[] numbers = [7, 8, 9, 4, 6, 1, 5, 3, 2];

            //SortingAlgorithm<int>.BubbleSort(numbers, CompareTypes.CompareGreaterThan);
            //SortingAlgorithm<int>.BubbleSort(numbers, CompareTypes.CompareLessThan);

            //Console.WriteLine(string.Join(", ", numbers));

            /////////////////////////////////////////////////////////////////////////////
            //string[] names = ["Ahmed", "Ali", "Mohmed", "Amr", "Omar", "Ibraheem"];

            //SortingAlgorithm<string>.BubbleSort(names, CompareTypes.CompareGreaterThan);
            //SortingAlgorithm<string>.BubbleSort(names, CompareTypes.CompareLessThan);

            //Console.WriteLine(string.Join(", ", names));

            // Part 02
            // Considering the Code Below, Write Down the Body of all Listed Methods and Properties and Constructor
            //List<Book> list = new List<Book>();

            //list.Add(new Book("123", "C# Basics", new string[] { "Ahmed Shaaban" , "Amr Amer" }, new DateTime(2025, 1, 1), 39.99m));
            //list.Add(new Book("456", "C# OOP", new string[] { "Ahmed Ali", "Saad Mohmed" }, new DateTime(2024, 12, 22), 70.99m));
            //list.Add(new Book("789", "C# Advanced", new string[] { "Mohmed Ali", "Aya Mohmed" }, new DateTime(2022, 5, 10), 79.99m));

            //LibraryEngine.ProcessBooks(list, BookFunctions.GetTitle);
            //Console.WriteLine("--------------------------------------");
            //LibraryEngine.ProcessBooks(list, BookFunctions.GetAuthers);
            //Console.WriteLine("--------------------------------------");
            //LibraryEngine.ProcessBooks(list, BookFunctions.GetPrice);

            // c)Anonymous Method (GetISBN).
            //Func<Book, string> GetISBN = delegate (Book book)
            //{
            //    if (book == null)
            //        return "Invalid Input";

            //    Console.WriteLine("********** Book ISBN **********");

            //    return $"Book ISBN : {book.ISBN}";
            //};

            //Book book = new Book("123", "C# Basics", new string[] { "Ahmed Shaaban", "Amr Amer" }, new DateTime(2025, 1, 1), 39.99m);

            //string bookISBN = GetISBN.Invoke(book);

            //Console.WriteLine(bookISBN);

            // d)Lambda Expression (GetPublicationDate).
            //Func<Book , string> GetPublicationDate = book => $"Publication Date: {book.PublicationDate:yyyy-MM-dd}";

            //Book book = new Book("123", "C# Basics", new string[] { "Ahmed Shaaban", "Amr Amer" }, new DateTime(2025, 1, 1), 39.99m);

            //string publicationDate = GetPublicationDate.Invoke(book);

            //Console.WriteLine(publicationDate);

            ////////////////////////////////////////////////////////////////////////
            // Part 03 in ListMethods Class
        }
    }
}
