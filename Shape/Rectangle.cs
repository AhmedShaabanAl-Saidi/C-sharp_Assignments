using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_.Shape
{
    internal class Rectangle : IRectangle
    {
        public double Area { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double _width, double _hight)
        {
            Width = _width;
            Height = _hight;
            Area = Width * Height;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle Info => Width = {Width} , Hight = {Height} , Area (Width * Height) = {Area}");
        }
    }
}
