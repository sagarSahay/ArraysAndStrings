using FluentAssertions;
using Xunit;

namespace OneEditDistance.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void IsOneEditDistance_GivenTwoStrings_ReturnsIfEditApart()
        {
            // Arrange 
            var s = "ab";
            var t = "acb";
            var sut =new Solution();
            
            // Act
            var res = sut.IsOneEditDistance(s, t);
            
            // Assert
            res.Should().Be(true);
        }
    }
}