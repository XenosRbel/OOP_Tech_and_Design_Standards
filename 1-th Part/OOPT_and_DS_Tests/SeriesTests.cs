using Laba_1;
using Xunit;

namespace OOPT_and_DS_Tests
{
    public class SeriesTests
    {
        [Fact]
        public void GetSumByFormulaAndGetSumByLoop()
        {
            var maxValue = 10;

            ISeries series = new Series(maxValue);
            var expected = series.GetSumByFormula();
            var actual = series.GetSumByLoop();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSumByFormula()
        {
            var maxValue = 10;
            var expected = 55;

            ISeries series = new Series(maxValue);
            var actual = series.GetSumByFormula ();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSumByLoop()
        {
            var maxValue = 10;
            var expected = 55;

            ISeries series = new Series(maxValue);
            var actual = series.GetSumByLoop();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSumByAccuracy()
        {
            var expected = 0.5d;

            ISeries series = new Series();
            var actual = series.GetSumByAccuracy();

            Assert.Equal(expected, actual);
        }
    }
}
