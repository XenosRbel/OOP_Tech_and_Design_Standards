using System;

namespace Laba_8
{
    internal class Comedy : DomesticFilm
    {
        public string Name { get; set; }
        public string Duration { get; set; }
        public string Language { get; set; }

        public void Pause() => Console.WriteLine($"Фильм:\t{Name} - Приостановлен");

        public void Play() => Console.WriteLine($"Приятного просмотра");

        public void Stop() => Console.WriteLine($"Фильм:\t{Name} - Остановлен");

        public override string ToString()
        {
            return $"Название фильма:\t{Name};\tПродолжительность:\t{Duration};\tЯзык озвучки:\t{Language}";
        }
    }
}
