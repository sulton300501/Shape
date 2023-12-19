using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape1 shape1 = new Shape1();
            shape1.CalculatePerimetr();
            Circle circle = new Circle();
            Rectengular rectengular = new Rectengular();
            Triangle triangle = new Triangle();
        }
    }
}