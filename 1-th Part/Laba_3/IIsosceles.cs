namespace Laba_3
{
    public interface IIsosceles
    {
        double Side { get; set; }
        double AngleAtTheBase { get;set; }

        void IncreaseSize(double value);
        void DecreaseSize(double value);

        void CalcLengthBisector();
        void CalculatingLengthHeights();
        void DefiningValuesSides();
    }
}
