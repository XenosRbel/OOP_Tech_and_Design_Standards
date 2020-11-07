using Laba_3;
using System;

namespace Laba_8
{
    internal class ElectroBelarussianBus : Bus
    {
        public ElectroBelarussianBus(IRoadTransportEquipment bus)
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
