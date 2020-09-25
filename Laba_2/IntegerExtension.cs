namespace Laba_2
{
    public static class IntegerExtension
    {
        public static bool IsEven(this int number)
        {
            return (number % 2 == 0);
        }
    }
}
