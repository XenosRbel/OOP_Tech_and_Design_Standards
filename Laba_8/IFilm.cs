namespace Laba_8
{
    public interface IFilm
    {
        string Name { get; set; }
        string Duration { get; set; }
        string Language { get; set; }
        void Play();
        void Stop();
        void Pause();
    }
}
