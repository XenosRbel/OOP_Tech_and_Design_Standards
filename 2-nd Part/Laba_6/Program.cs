namespace Laba_6
{
	class Program
    {
        static void Main(string[] args)
        {
            Component root = new Car("Автомобиль");
            Component frame = new Composite("Каркас");
            Component leaf1 = new Leaf("Корпус");
            Composite subtree = new Composite("Салон");
            Component subtreeleaf1 = new Leaf("Кресла");
            Component subtsubtree = new Composite("Панель мультимедиа");
            Component subtsubtreeleaf1 = new Leaf("Видеорегистратор");
            Component subtsubtreeleaf2 = new Leaf("Руль");
            Component leaf2 = new Leaf("Колёса");

            root.Add(frame);
            frame.Add(leaf1);
            frame.Add(subtree);
            subtree.Add(subtreeleaf1);
            subtree.Add(subtsubtree);
            subtsubtree.Add(subtsubtreeleaf1);
            subtsubtree.Add(subtsubtreeleaf2);
            frame.Add(leaf2);
            root.Display("");
        }
    }
}
