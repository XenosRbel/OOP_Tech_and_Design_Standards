using System;
using System.Collections.Generic;

namespace Laba_3
{
    public class Car : IRoadTransportEquipment, IEquatable<Car>
    {
        public Car()
        {

        }

        public Car(string name, string color, string type, int power)
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
            return Equals(obj as Car);
        }

        public bool Equals(Car other)
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

        public static bool operator ==(Car left, Car right)
        {
            return EqualityComparer<Car>.Default.Equals(left, right);
        }

        public static bool operator !=(Car left, Car right)
        {
            return !(left == right);
        }
    }
}
