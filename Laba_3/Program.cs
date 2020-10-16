using System;

namespace Laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var trieangle = new IsoscelesTriangle(15, 35);
            System.Console.WriteLine(trieangle);
            trieangle.CalcLengthBisector();
            trieangle.CalculatingLengthHeights();
            trieangle.DefiningValuesSides();
            trieangle.DecreaseSize(2);
            System.Console.WriteLine(trieangle);
            trieangle.IncreaseSize(3);
            System.Console.WriteLine(trieangle);
        }
    }
}
