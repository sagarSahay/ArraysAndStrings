using FluentAssertions;
using Xunit;

namespace NextPermutation.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void NextPermuation_GivenInput_ReturnsNextPermutation()
        {
            // Arrange
            var input = new[] {1, 2, 3};
            var sut = new Solution();

            // Act
            sut.NextPermutation(input);

            // Assert
            input.Should().BeEquivalentTo(new[] {1, 3, 2});
        }
    }
}