using System;
using Xunit;

namespace StringCalculatorKata.Tests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Add_Returns_0For_Empty_String()
        {
            var undertest = new StringCalculator();

            var result = undertest.Add("");

            Assert.Equal(0, result);
        }
    }
}
