using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog { Name = "Собака" };
            Console.WriteLine(dog);
            dog.Run();
            dog.Jump();
            dog.Bite();
            dog.Bark();

            var puppy = new Puppy { Name = "Щенок" };
            Console.WriteLine($"\n{puppy}");
            puppy.Run();
            puppy.Jump();
            puppy.Bite();
            puppy.Bark();

            var husky = new HuskyPuppy();
            Console.WriteLine($"\n{husky}");
            husky.Run();
            husky.Jump();
            husky.Bite();
            husky.Bark();

            Console.WriteLine($"\nЗадание 2\n");
            var economy = new Economy(75, 3.5f, 50);
            var comfort = new Comfort(80, 4.5f, 70);
            var comfortPlus = new ComfortPlus(100, 6.5f, 70);
            var business = new Business(120, 7.5f, 80);

            var taxiPark = new List<ITaxi> { economy, comfort, comfortPlus, business };

            foreach (var taxi in taxiPark)
            {
                Console.WriteLine(taxi);
            }
            Console.WriteLine($"Сумма парка:\t{taxiPark.Sum(taxi => taxi.Price)}");

            var filtredPark = taxiPark.OrderByDescending(taxi => taxi.FuelVolume);

            Console.WriteLine($"Output\n{string.Join("\n", filtredPark)}\n");

            var rangedPark = taxiPark.Where(taxi => taxi.Speed >= 80 && taxi.Speed <=110);

            Console.WriteLine($"Output\n{string.Join("\n", rangedPark)}\n");
        }
    }
}
