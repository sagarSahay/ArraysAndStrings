using FluentAssertions;
using Xunit;

namespace RomanToInteger.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void RomanToInt_GivenRomanNumber_ReturnsInt()
        {
            // Arrange
            var input = "III";
            var sut = new Solution();
            
            // Act
            var res = sut.RomanToInt(input);
            
            // Assert
            res.Should().Be(3);
        }
    }
}