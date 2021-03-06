﻿using System;
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
            var bisector = FindBisector();
            Console.WriteLine($"Длина биссектрисы равна:\t{bisector}, " +
                $"при угле равному:\t{this.AngleAtTheBase} (градусов)");
        }

        public void CalculatingLengthHeights()
        {
            var basisSide = FindBasisSide();
            var length = Math.Sqrt(Math.Pow(Side, 2) - Math.Pow((basisSide / 2), 2));
            Console.WriteLine($"Длина высоты при сторонах равным {Side}\t&\t{basisSide} -> равна:\t{length}");
        }

        public void DecreaseSize(double value)
        {
            this.Side /= value;
        }

        public void DefiningValuesSides()
        {
            var basisSize = FindBasisSide();
            Console.WriteLine($"Две стороны равнобедренного треугольника равны:\t{this.Side}, основание:{basisSize}");
        }

        public void IncreaseSize(double value)
        {
            this.Side *= value;
        }

        private double FindBisector()
        {
            double angle = Math.PI * this.AngleAtTheBase / 180.0;
            return this.Side * Math.Sin(angle);
        }

        private double FindBasisSide()
        {
            double angle = Math.PI * this.AngleAtTheBase / 180.0;
            return 2 * this.Side * Math.Cos(angle);
        }

         public override string ToString()
        {
            return $"{this.Side}\t{this.AngleAtTheBase}";
        }
    }
}
