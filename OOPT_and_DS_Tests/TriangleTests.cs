using Laba_1;
using Xunit;

namespace OOPT_and_DS_Tests
{
    public class TriangleTests
    {
        [Fact]
        public void IsRightTriangleWithValidData()
        {
            ITriangle triangle = new Triangle(3, 1, 3);
            var result = triangle.IsRightTriangle();
            Assert.True(result);
        }

        [Fact]
        public void IsRightTriangleWithInvalidData()
        {
            ITriangle triangle = new Triangle(3, 2, 1);
            var result = triangle.IsRightTriangle();
            Assert.False(result);
        }
    }
}
