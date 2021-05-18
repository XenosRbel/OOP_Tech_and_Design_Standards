using System;

namespace Laba_6
{
	internal class Leaf : Component
    {
        public Leaf(string name)
            : base(name)
        { }

        public override void Display(string add)
        {
            Console.Write(add);
            Console.WriteLine(name);
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
