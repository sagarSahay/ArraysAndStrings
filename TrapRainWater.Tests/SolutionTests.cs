using FluentAssertions;
using Xunit;

namespace TrapRainWater.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void Trap_WhenGivenHeights_ReturnsWaterTrapped()
        {
            // Arrange 
            var input = new int[] {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1};
            var sut = new Solution();
            
            // Act
            var res = sut.Trap(input);
            
            // Assert
            res.Should().Be(6);
        }
    }
}