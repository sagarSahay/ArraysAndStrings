namespace Search2DMatrix.Tests
{
    using FluentAssertions;
    using Xunit;

    public class SolutionTests
    {
        [Fact]
        public void Search_WhenGivenTarget_ReturnTrueOrFalse()
        {
            // Arrange
            var sut = new Solution();
            var input = new[] {new[] {1}, new[] {3}};
            
            // Act
            var res = sut.SearchMatrix(input, 3);
            
            // Assert
            res.Should().Be(true);
        }
    }
}