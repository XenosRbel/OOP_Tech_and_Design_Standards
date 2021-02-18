namespace Laba_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseBus = new Bus("Электробус", "Желтый", "Электро", 240);
            System.Console.WriteLine(baseBus);
            baseBus.Beep();
            baseBus.EngineStart();
            baseBus.CloseDoor("Let's go\n");

            var belarussian = new BelarussianBus("Автобус", "Зеленый", "Бензин", 440);
            System.Console.WriteLine(belarussian);
            belarussian.Beep();
            belarussian.EngineHalt();
            belarussian.OpenDoor("Удачи!");
        }
    }
}
