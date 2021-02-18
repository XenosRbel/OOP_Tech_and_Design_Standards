using System;

namespace Laba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ITriangle triangle = new Triangle(3, 4, 4);
            Console.WriteLine($"Это прямоугольный треугольник ? {triangle.IsRightTriangle()}");
        }
    }
}
