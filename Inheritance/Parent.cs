using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_.Inheritance
{
    public class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int _x,int _y)
        {
            X = _x;
            Y = _y;
        }

        public int ProductOfNumbers()
        {
            return X * Y;
        }

        public override string ToString()
        {
            return $"X = {X} Y = {Y}";
        }
    }
}
