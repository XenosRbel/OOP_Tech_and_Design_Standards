using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_3
{
    public class IsoscelesTriangle : IIsosceles
    {
        public IsoscelesTriangle(double side, double angleAtTheBase)
        {
            Side = side;
            AngleAtTheBase = angleAtTheBase;
        }

        public double Side { get ; set ; }
        public double AngleAtTheBase { get ; set ; }

        public void CalcLengthBisector()
        {
            var bisector = FindBisector(this.Side, this.AngleAtTheBase);
            Console.WriteLine($"Длина биссектрисы равна:\t{bisector}, " +
                $"при угле равному:\t{this.AngleAtTheBase} (градусов)");
        }

        public void CalculatingLengthHeights()
        {
            var basisSide = FindBasisSide(Side, AngleAtTheBase);
            var length = Math.Sqrt(Math.Pow(Side, 2) - Math.Pow((basisSide / 2), 2));
            Console.WriteLine($"Длина высоты при сторонах равным {Side}&{basisSide} - равна:\t{length}");
        }

        public void DecreaseSize(double value)
        {
            this.Side /= value;
        }

        public void DefiningValuesSides()
        {
            var basisSize = FindBasisSide(this.Side, this.AngleAtTheBase);
            Console.WriteLine($"Две стороны равнобедренного треугольника равны:\t{this.Side}, основание:{basisSize}");
        }

        public void IncreaseSize(double value)
        {
            this.Side *= value;
        }

        private double FindBisector(double side, double angle)
        {
            return side * Math.Sin(angle);
        }

        private double FindBasisSide(double sideA, double angle)
        {
            return 2 * sideA * Math.Cos(angle);
        }
    }
}
