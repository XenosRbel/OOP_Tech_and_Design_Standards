using System;

namespace Laba_5
{
    class BelarussianBus : Bus
    {
        public BelarussianBus(string name, string color, string type, int power) : base(name, color, type, power)
        {
        }

        public override void Beep()
        {
            Console.WriteLine($"Пииииии Биииииип");
        }

        public override void Beep(string additionalMessage)
        {
            Console.WriteLine($"Биииииииип\t{additionalMessage}");
        }

        public override void CloseDoor()
        {
            Console.WriteLine($"Дверь закрыта");
        }

        public override void CloseDoor(string additionalMessage)
        {
            Console.WriteLine($"Дверь закрыта\t{additionalMessage}");
        }

        public override void EngineHalt()
        {
            Console.WriteLine($"Двигатель остановлен");
        }

        public override void EngineStart()
        {
            Console.WriteLine($"Двигатель запущен");
        }

        public override void OpenDoor()
        {
            Console.WriteLine($"Дверь открыта");
        }

        public override void OpenDoor(string additionalMessage)
        {
            Console.WriteLine($"Дверь открыта\t{additionalMessage}");
        }
    }
}
