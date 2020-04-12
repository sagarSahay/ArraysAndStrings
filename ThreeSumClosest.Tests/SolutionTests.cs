namespace ThreeSumClosest.Tests
{
    using FluentAssertions;
    using Xunit;

    public class SolutionTests
    {
        [Fact]
        public void ThreeSumCloses_WhenGivenInput_ReturnsClosestSum()
        {
            // Arrange
            var input = new[] {-1, 2, 1, -4};
            var sut = new Solution();
            
            // Act
            var res = sut.ThreeSumClosest(input ,1);
            
            // Assert
            res.Should().Be(2);
        }
    }
}