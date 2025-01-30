namespace Assignment1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Optimise BubbleSort
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            Helper<int>.BubbleSort(arr);

            foreach (var item in arr)
                Console.WriteLine(item);
        }
    }
}
