using FluentAssertions;
using Xunit;

namespace MinimumWindowSubstring.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void MWS_GivenAString_ReturnsWindow()
        {
            // Arrange
            var input = "ADOBECODEBANC";
            var T = "ABC";
            // var input = "aa";
            // var T = "aa";
            var sut = new Solution();
            
            // Act
            var res = sut.MinWindow(input, T);
            
            // Assert
            res.Should().Be("BANC");
        }
        
    }
}