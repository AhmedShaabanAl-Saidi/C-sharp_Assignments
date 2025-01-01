using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    internal struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double _x, double _y)
        {
            X = _x;
            Y = _y;
        }

        public double Distance(Point p)
        {
            return Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
        }

    }
}
