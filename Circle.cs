using System;

namespace TestTask
{
    public class Circle : Shape
    {
        const double pi = 3.14;
        public double Radius { get; set; }

        public Circle (double radius)
        {
            if (radius <= 0)
                throw new CircleException("Укажите положительный радиус");

            Radius = radius;
        }

        public override double GetArea() {
           return Radius * Radius * pi; 
        } 
    }

    public class CircleException : Exception
    {
        public CircleException(string message) : base(message) { }
    }
}
