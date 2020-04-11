using FluentAssertions;
using Xunit;

namespace StringToInteger.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void Myatoi_GivenAString_ReturnsIntEquivalent()
        {
            // Arrange
            var input = "2147483648";
            var sut = new Solution();
            
            // Act
            var res = sut.MyAtoi(input);
            
            // Assert
            res.Should().Equals(2147483648);
        }
    }
}