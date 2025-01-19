using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_.Shape
{
    public interface IShape
    {
        double Area { get; set; }
        void DisplayShapeInfo();
    }
}
