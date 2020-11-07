using Laba_5;
using System;

namespace Laba_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseBus = new Bus("Электробус", "Желтый", "Электро", 240);
            Console.WriteLine(baseBus);
            baseBus.Beep();
            baseBus.EngineStart();
            baseBus.CloseDoor("Let's go\n");

            var belarussian = new BelarussianBus("Автобус", "Зеленый", "Бензин", 440);
            Console.WriteLine(belarussian);
            belarussian.Beep();
            belarussian.EngineHalt();
            belarussian.OpenDoor("Удачи!\n");

            var electroBus = new ElectroBelarussianBus(belarussian);
            electroBus.Name = "Белорусский электробус";
            electroBus.Type = "Энергия";
            Console.WriteLine(electroBus);
            electroBus.Beep();
        }
    }
}
