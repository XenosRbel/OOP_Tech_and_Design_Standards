using System;
using System.Collections.Generic;

namespace Laba_6
{
	internal class Car : Component
	{
        List<Component> children = new List<Component>();

        public Car(string name) : base(name) { }

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
