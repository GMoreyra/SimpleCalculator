using Xunit;
using FluentAssertions;

namespace SimpleCalculator.Tests
{
    public class HelperTests
    {
        [Theory]
        [InlineData("1 0")]
        [InlineData("0 0")]
        [InlineData("100 100")]
        [InlineData("11.11 1.1")]
        public void regexValidatorReturnsTrue(string input)
        {
            var result = Helper.regexValidator(input);
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(" 100")]
        [InlineData("0 ")]
        [InlineData("0")]
        public void regexValidatorReturnsFalse(string input)
        {
            var result = Helper.regexValidator(input);
            result.Should().BeFalse();
        }
    }
}