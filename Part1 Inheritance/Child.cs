using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_.Inheritance
{
    public class Child : Parent
    {
        public int Z { get; set; }

        public Child(int _x,int _y,int _z) : base(_x,_y)
        {
            Z = _z;
        }

        public new int ProductOfNumbers()
        {
            return X * Y * Z;
        }

        public override string ToString()
        {
            return $"X = {X} Y = {Y} Z = {Z}";
        }
    }
}
