namespace Assignment1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("C#","Ahmed Shaaban","123321");

            BorrowedBook borrowedBook = new BorrowedBook(1, true, book, "Mohmed", DateTime.Now.AddDays(-7));

            Console.WriteLine(borrowedBook.CheckOut(1));

            Console.WriteLine(borrowedBook.ReturnItem(55));

            Console.WriteLine($"Borrowed : {borrowedBook.CalculateBorrowDuration()} Days");
        }
    }
}
