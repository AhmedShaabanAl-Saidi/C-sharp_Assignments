using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class SortingAlgorithm<T>
    {
        private static void Swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static void BubbleSort(T[] arr, Func<T, T, bool> compare)
        {
            if (arr == null || arr.Length == 0)
                return;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (compare.Invoke(arr[j], arr[j + 1]))
                        Swap(ref arr[j], ref arr[j + 1]);
                }
            }
        }
    }
}
