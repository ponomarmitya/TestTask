using System;

namespace TestTask
{
    public class Triangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c) {

            if (a < 0 || b < 0 || c < 0)
                throw new TriangleException("Все стороны треугольника должны быть положительными");

            if ((a + b < c) || (a + c < b) || (b + c < a))
                throw new TriangleException("Треугольника с такими сторонами не существует");

            A = a;
            B = b;
            C = c;
        }

        private double GetHalfPerimeter()
        {
            return (A + B + C) / 2;
        }

        public override double GetArea()
        {
            var p = GetHalfPerimeter();

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRectangular()
        {
            if ((A * A == B * B + C * C) || (B * B == A * A + C * C) || (C * C == A * A + B * B))
                return true;

            return false;
        }
    }

    public class TriangleException : Exception
    {
        public TriangleException(string message) : base(message) { }
    }
}
