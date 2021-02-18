using Laba_2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OOPT_and_DS_Tests
{
    public class IntegerExtensionTest
    {
        [Fact]
        public void IsEven()
        {
            var number = 2;
            var expected = true;

            var result = number.IsEven();

            Assert.Equal(expected, result);
        }
    }
}
