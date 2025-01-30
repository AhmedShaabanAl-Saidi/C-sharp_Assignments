using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    // 2 - Range Generic Class
    public class Range<T> where T : IComparable<T>, INumber<T>
    {
        // 1
        public T Min { get; set; }
        public T Max { get; set; }

        // 2
        public Range(T min, T max)
        {
            Min = min;
            Max = max;
        }

        // 3
        public bool IsInRange(T value)
        {
            if (value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0)
                return true;
            else
                return false;
        }

        // 4
        public T Length()
        {
            return Max - Min;
        }

    }
}
