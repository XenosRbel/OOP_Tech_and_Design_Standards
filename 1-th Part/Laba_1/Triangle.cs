using System;

namespace Laba_1
{
    public class Triangle : ITriangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool IsRightTriangle()
        {
            return (PythagoreanTheorem(A, B, C) ||
              PythagoreanTheorem(A, C, B) ||
              PythagoreanTheorem(C, B, A));
        }

        private bool PythagoreanTheorem(double a, double b, double c)
        {
            return (Math.Pow(a, 2) * Math.Pow(b, 2) == Math.Pow(c, 2));
        }
    }
}
