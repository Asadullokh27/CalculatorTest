using CalculatorTest;

namespace Calculatorr.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(4, 5, 9)]
        [InlineData(1, 4, 5)]
        public void TestAdd(double a, double b, double expactedResult)
        {
            var result = Calculator.Add(a, b);
            Assert.Equal(expactedResult, result);
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(4, 4, 0)]
        public void TestSubtract(double a, double b, double expactedResult)
        {
            var result = Calculator.Subtract(a, b);
            Assert.Equal(expactedResult, result);
        }
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(100, 2, 50)]
        public void TestDevide(double a, double b, double expactedResult)
        {
            var result = Calculator.Devide(a, b);
            Assert.Equal(expactedResult, result);
        }
        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(4, 3, 12)]
        public void TestMultiply(double a, double b, double expactedResult)
        {
            var result = Calculator.Multiply(a, b);
            Assert.Equal(expactedResult, result);
        }
    }
}