using FluentAssertions;
using Xunit;

namespace IntegerToRoman.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void IntToRoman_GivenString_ReturnsRomanRepresentation()
        {
            // Arrange 
            var input = 3;
            var sut =new Solution();
            
            // Act
            var res = sut.IntToRoman(input);
            
            // Assert
            res.Should().Be("III");
        }
    }
}