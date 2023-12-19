using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Rectengular :Shape1
    {

        public double width = 0;
        public double height = 0;

        public double CalculateArea()
        {
            return 2.3;
        }

        public void CalculatePerimetr()
        {
            Console.WriteLine("CalculateRegtengular");
        }

        public void Rectengular1(double width, double height,double x , double y)
        {
            Console.WriteLine("Regtengular");

        }

    }
}
