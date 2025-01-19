using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    internal class Circle : ICircle
    {
        public double Area { get; set; }
        public double Radius { get; set; }

        public Circle(double _redius) 
        { 
            Radius = _redius;
            Area = Math.PI * Math.Pow(Radius, 2);
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle Info => Radius = {Radius} , Area (Math.PI * Math.Pow(Radius, 2)) = {Area}");
        }
    }
}
