using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Triangle : Shape1
    {
        public double firstSide = 0;
        public double secondSide = 0;
        public double third = 0;

        public double CalculateArea()
        {
            return 2.3;
        }

        public void CalculatePerimetr()
        {
            Console.WriteLine("CalculatePerimetr");
        }

        public void Triangle1(double firstSide, double seconSide , double thirdSide, double x, double y)
        {
            Console.WriteLine("ShapeShakl");

        }
    }
}
