using FluentAssertions;
using Xunit;

namespace ContainerWithMostWater.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void MaxArea_GivenInput_ReturnsMaxArea()
        {
            // Arrange 
            var input = new[] {1, 8, 6, 2, 5, 4, 8, 3, 7};
            var sut = new Solution();
            
            // Act
            var res = sut.MaxArea(input);
            
            // Assert
            res.Should().Be(49);
        }
    }
}