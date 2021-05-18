namespace Laba_6
{
	internal abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Display(string add);
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
    }
}
