using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment1_C_.Part2_Employee
{
    public class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int _day , int _month , int _year)
        {
            if (_day < 1 || _day > 31)
            {
                throw new Exception("Day must be between 1 and 31.");
            }
            if (_month < 1 || _month > 12)
            {
                throw new Exception("Month must be between 1 and 12.");
            }
            if (_year < 1)
            {
                throw new Exception("Year must be a positive number.");
            }

            Day = _day;
            Month = _month;
            Year = _year;
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }
}
