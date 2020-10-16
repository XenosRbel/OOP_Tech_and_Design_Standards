using Laba_3;
using System;
using System.Collections.Generic;

namespace Laba_4
{
    public class Bus : IRoadTransportEquipment, IEquatable<Bus>
    {
        public Bus()
        {

        }

        public Bus(string name, string color, string type, int power)
        {
            Name = name;
            Color = color;
            Type = type;
            Power = power;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public int Power { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Bus);
        }

        public bool Equals(Bus other)
        {
            return other != null &&
                   Name == other.Name &&
                   Color == other.Color &&
                   Type == other.Type &&
                   Power == other.Power;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Color, Type, Power);
        }

        public override string ToString()
        {
            return $"{Name}\t{Color}\t{Type}\t{Power}";
        }

        public static bool operator ==(Bus left, Bus right)
        {
            return EqualityComparer<Bus>.Default.Equals(left, right);
        }

        public static bool operator !=(Bus left, Bus right)
        {
            return !(left == right);
        }
    }
}
