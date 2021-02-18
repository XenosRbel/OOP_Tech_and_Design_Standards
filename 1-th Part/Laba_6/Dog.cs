using System;

namespace Laba_6
{
    internal class Dog : IAnimal
    {
        public string Name { get; set; }

        public virtual void Bark()
        {
            Console.WriteLine("Вуф-вуф");
        }

        public virtual void Bite()
        {
            Console.WriteLine("Кусь");
        }

        public virtual void Jump()
        {
            Console.WriteLine("Прыг");
        }

        public virtual void Run()
        {
            Console.WriteLine("Побежал за зайцем");
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
