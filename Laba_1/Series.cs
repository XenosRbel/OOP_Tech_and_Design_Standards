using System;
using System.Linq;

namespace Laba_1
{
    public class Series : ISeries
    {
        public Series() { }

        public Series(int maxValue )
        {
            _value = maxValue;
        }

        public int GetSumByFormula()
        {
            return (_value * (_value + 1) / 2);
        }

        public int GetSumByLoop()
        {
            return Enumerable.Range(0, _value + 1).Sum();
        }

        public double GetSumByAccuracy()
        {
            var sum = 0d;
            var i = 1d;
            double ai;
            do
            {
                ai = Formula(i);
                sum += ai;
                i++;
                Console.WriteLine(sum);
     
            } while (ai > _default_accuracy);

            Console.WriteLine($"SUM:{sum};\t Iteration count:{i}");
            return sum;
        }

        private int _value;
        private double _default_accuracy = 0.0001d;

        private double Formula(double value)
        {
            return Math.Pow(-1, value + 1) * (1 / value);
        }
    }
}
