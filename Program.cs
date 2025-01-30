using System.Collections;

namespace Assignment1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Optimise BubbleSort
            //int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            //Helper<int>.BubbleSort(arr);

            //foreach (var item in arr)
            //    Console.WriteLine(item);

            // 2 - Range Generic Class
            //Range<int> range = new(1, 10);
            //Console.WriteLine(range.IsInRange(12));
            //Console.WriteLine(range.Length());

            // 3 - Reverse ArrayList
            ArrayList numbers = new ArrayList { 1, 2, 3, 4, 5 };
            Helper<int>.ReverseArrayList(numbers);

            foreach (int item in numbers)
                Console.WriteLine(item);
        }
    }
}
