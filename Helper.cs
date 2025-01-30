using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class Helper<T> where T : IComparable<T>
    {
        // 1 - Optimise BubbleSort
        public static void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void BubbleSort(T[] arr)
        {
            if (arr is null || arr.Length == 0)
                return;

            bool swapped;

            for (int i = 0; i < arr.Length; i++)
            {
                swapped = false;

                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) == 1)
                    {
                        swapped = true;
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }

                if (!swapped)
                    break;
            }
        }
    }
}
