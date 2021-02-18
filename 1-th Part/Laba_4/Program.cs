using System;

namespace Laba_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var e_bus = new Bus("Электробус", "Желтый", "Электро", 240);
            var bus = new Bus("Автобус", "Зеленый", "Бензин", 440);

            Console.WriteLine($"Eql? {e_bus == bus}");
            Console.WriteLine($"Print\t{e_bus}");
            Console.WriteLine($"Print\t{bus}");
            Console.WriteLine($"Print GetHashCode for {bus}\t{bus.GetHashCode()}");
        }
    }
}
