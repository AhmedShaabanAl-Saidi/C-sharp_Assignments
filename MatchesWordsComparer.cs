using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class MatchesWordsEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            if (x == null || y == null)
                return false;

            return GetAsciiSum(x) == GetAsciiSum(y);
        }

        public int GetAsciiSum(string str)
        {
            int sum = 0;
            foreach (char c in str)
            {
                sum += (int)c;
            }
            return sum;
        }

        public int GetHashCode(string obj)
        {
            if (obj == null)
                return -1;

            var objChars = obj.OrderBy(c => c).ToArray();
            return new string(objChars).GetHashCode();
        }
    }
}
