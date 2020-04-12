using FluentAssertions;
using Xunit;

namespace RotateImage.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void RotateImage_WhenGivenInput_RotatesItBy90Degrees()
        {
            // Arrange
            var input = new[]
            {
                new[] {1, 2, 3},
                new[] {4, 5, 6},
                new[] {7, 8, 9}
            };

            var sut = new Solution();

            // Act
            sut.Rotate(input);

            // Assert
            input.Should().BeEquivalentTo(new[] {7, 4, 1}, new[] {8, 5, 2}, new[] {9, 6, 3});
        }
    }
}