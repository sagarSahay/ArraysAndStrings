using FluentAssertions;
using Xunit;

namespace NumberToWords.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void NumberToWords_GivenInput_ReturnsStringRepresentation()
        {
            // Arrange
            var input = 1234567891;
            var sut = new Solution();
            
            // Act
            var res = sut.NumberToWords(input);
            
            // Assert
            res.Should().Be("One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety One");
        }
    }
}