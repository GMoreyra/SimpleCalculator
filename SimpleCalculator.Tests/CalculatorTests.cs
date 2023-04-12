using Xunit;
using FluentAssertions;

namespace SimpleCalculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, 2, 1)]
        [InlineData(-1, -1, -2)]
        [InlineData(0, 0, 0)]
        public void Add_ReturnsCorrectSum(double a, double b, double expected)
        {
            var result = _calculator.Add(a, b);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(1, -2, 3)]
        [InlineData(-1, -2, 1)]
        [InlineData(0, 0, 0)]
        public void Subtract_ReturnsCorrectDifference(double a, double b, double expected)
        {
            var result = _calculator.Subtract(a, b);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(-2, 3, -6)]
        [InlineData(0, 0, 0)]
        public void Multiply_ReturnsCorrectProduct(double a, double b, double expected)
        {
            var result = _calculator.Multiply(a, b);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(-6, 3, -2)]
        public void Divide_ReturnsCorrectQuotient(double a, double b, double expected)
        {
            var result = _calculator.Divide(a, b);
            result.Should().Be(expected);
        }

        [Fact]
        public void Divide_DivideByZero_ThrowsArgumentException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(1, 0));
        }
    }
}