using System;
using System.Collections.Generic;

namespace Laba_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var comedy = new Comedy { Duration = "1 час 20 мин.", Language = "Русский", Name = "Комедия. Как украсть соседа" };
            var domestic = new DomesticFilm { Duration = "2 час 20 мин.", Language = "Русский", Name = "День танкиста" };

            var films = new List<IFilm> { comedy, domestic };
            foreach (var film in films)
            {
                Console.WriteLine(film);
            }

            Console.WriteLine("\nЗадание 2\n");
            var belarussian = new Laba_5.BelarussianBus("Автобус", "Зеленый", "Бензин", 440);
            Console.WriteLine(belarussian);
            belarussian.Beep();
            belarussian.EngineHalt();
            belarussian.OpenDoor("Удачи!\n");

            var electroBus = new ElectroBelarussianBus(belarussian);
            electroBus.Name = "Белорусский электробус";
            electroBus.Type = "Энергия";
            Console.WriteLine(electroBus);
            electroBus.Beep();
        }
    }
}
