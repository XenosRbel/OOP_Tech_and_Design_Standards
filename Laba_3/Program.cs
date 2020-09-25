using System;

namespace Laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface IRoadTransportEquipment
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public int Power { get; set; }
    }
}
