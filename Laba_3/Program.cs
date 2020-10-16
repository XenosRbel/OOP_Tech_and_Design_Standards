using System;
using System.Collections.Generic;

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

            IRoadTransportEquipment bus = new Bus { Name = "Bus 1" };
            IRoadTransportEquipment tractor = new Tractor { Name = "Tractor 1" };
            List<IRoadTransportEquipment> roadTransports = new List<IRoadTransportEquipment> { bus, tractor };

            foreach (var item in roadTransports)
            {
                Console.WriteLine(item.Name);
            }

            var bus1 = new Bus { Name = "Bus 1" };
            var bus2 = new Bus { Name = "Bus 2" };

            Console.WriteLine(bus1==bus2);
        }
    }
}
