using Assignment1_C_.Inheritance;

namespace Assignment1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            Child child = new Child(10,20,30);

            int result = child.ProductOfNumbers();

            Console.WriteLine(result);
            #endregion
        }
    }
}
