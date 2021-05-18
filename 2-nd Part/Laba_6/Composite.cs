using System;
using System.Collections.Generic;

namespace Laba_6
{
	internal class Composite : Component
    {
        List<Component> children = new List<Component>();

        public Composite(string name)
            : base(name)
        { }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void Display(string add)
        {
            Console.WriteLine(add + name);

            foreach (Component component in children)
            {
                Console.Write(add + "=");
                component.Display(add + "=");
            }
        }
    }
}
