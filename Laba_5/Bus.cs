using Laba_3;
using System;

namespace Laba_5
{
    class Bus : IRoadTransportEquipment
    {
        public Bus(string name, string color, string type, int power)
        {
            Name = name;
            Color = color;
            Type = type;
            Power = power;
        }

        public Bus()
        {
        }

        public string Name { get ; set ; }
        public string Color { get ; set ; }
        public string Type { get ; set ; }
        public int Power { get ; set ; }

        public virtual void OpenDoor()
        {
            Console.WriteLine("The door opened");
        }

        public virtual void OpenDoor(string additionalMessage)
        {
            Console.WriteLine($"The door opened.{additionalMessage}");
        }

        public virtual void CloseDoor()
        {
            Console.WriteLine("The door closed");
        }

        public virtual void CloseDoor(string additionalMessage)
        {
            Console.WriteLine($"The door closed.{additionalMessage}");
        }

        public virtual void Beep()
        {
            Console.WriteLine("Beeeeeeeep!");
        }

        public virtual void Beep(string additionalMessage)
        {
            Console.WriteLine($"Beeeeeeeep!\t{additionalMessage}");
        }

        public virtual void EngineStart()
        {
            Console.WriteLine("Engine started");
        }

        public virtual void EngineHalt()
        {
            Console.WriteLine("Engine halted");
        }

        public override string ToString()
        {
            return $"{Name}\t{Color}\t{Type}\t{Power}";
        }
    }
}
