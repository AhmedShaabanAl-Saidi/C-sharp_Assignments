using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class CompareTypes
    {
        public static bool CompareGreaterThan(int x, int y)
        {
            return x > y;
        }

        public static bool CompareLessThan(int x, int y)
        {
            return x < y;
        }

        public static bool CompareGreaterThan(string x, string y)
        {
            return x.Length > y.Length;
        }

        public static bool CompareLessThan(string x, string y)
        {
            return x.Length < y.Length;
        }
    }
}
