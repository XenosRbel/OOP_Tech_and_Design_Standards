using Laba_5;
using System;

namespace Laba_7
{
    internal class ElectroBelarussianBus : Bus
    {
        public ElectroBelarussianBus(Bus bus)
        {
            this.Color = bus.Color;
            this.Name = bus.Name;
            this.Power = bus.Power;
            this.Type = bus.Type;
        }

        public override void Beep()
        {
            Console.WriteLine($"Ту-туууууууу");
        }
    }
}
