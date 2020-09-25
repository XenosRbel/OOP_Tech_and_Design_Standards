namespace Laba_1
{
    public interface ITriangle
    {
        double A { get; set; }
        double B { get; set; }
        double C { get; set; }

        bool IsRightTriangle();
    }
}
