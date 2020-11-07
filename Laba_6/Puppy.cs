namespace Laba_6
{
    internal class Puppy : Dog
    {
        public Puppy()
        {
        }

        public Puppy(string name)
        {
            Name = name;
        }

        public override void Bark()
        {
            System.Console.WriteLine("Гав-гав");
        }

        public override void Bite()
        {
            System.Console.WriteLine("Кусь за ногу");
        }

        public override void Jump()
        {
            System.Console.WriteLine("Прыгаю на двух лапах");
        }

        public override void Run()
        {
            System.Console.WriteLine("Бегу за кошкой");
        }
    }
}
