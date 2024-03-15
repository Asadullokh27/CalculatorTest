using CalculatorTest;
using Xunit;

namespace Calculatorr.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(4, 5, 9)]
        [InlineData(1, 4, 5)]
        public void TestAdd(double a, double b, double expectedResult)
        {
            var result = Calculator.Add(a, b);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(4, 4, 0)]
        public void TestSubtract(double a, double b, double expectedResult)
        {
            var result = Calculator.Subtract(a, b);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(100, 2, 50)]
        public void TestDivide(double a, double b, double expectedResult)
        {
            var result = Calculator.Divide(a, b);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(4, 3, 12)]
        public void TestMultiply(double a, double b, double expectedResult)
        {
            var result = Calculator.Multiply(a, b);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 3, 8)]
        [InlineData(4, 2, 16)]
        public void TestPower(double a, double b, double expectedResult)
        {
            var result = Calculator.Power(a, b);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(16, 4)]
        [InlineData(25, 5)]
        public void TestSquareRoot(double a, double expectedResult)
        {
            var result = Calculator.SquareRoot(a);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(10, 3, 1)]
        [InlineData(20, 7, 6)]
        public void TestModulus(double a, double b, double expectedResult)
        {
            var result = Calculator.Modulus(a, b);
            Assert.Equal(expectedResult, result);
        }
    }
}
