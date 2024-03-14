using CalculatorTest;

namespace Calculatorr.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2, 3, 5)]
        public void TestAdd(double a, double b, double expactedResult)
        {
            var result = Calculator.Add(a, b);
            Assert.Equal(expactedResult, result);
        }

        [Theory]
        [InlineData(2, 2, 0)]
        [InlineData(2, 3, -1)]
        public void TestSubtract(double a, double b, double expactedResult)
        {
            var result = Calculator.Subtract(a, b);
            Assert.Equal(expactedResult, result);
        }
        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(34, 2, 17)]
        public void TestDevide(double a, double b, double expactedResult)
        {
            var result = Calculator.Devide(a, b);
            Assert.Equal(expactedResult, result);
        }
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2, 3, 6)]
        public void TestMultiply(double a, double b, double expactedResult)
        {
            var result = Calculator.Multiply(a, b);
            Assert.Equal(expactedResult, result);
        }
    }
}