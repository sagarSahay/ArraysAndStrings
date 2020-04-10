using FluentAssertions;
using Xunit;

namespace TwoSum.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void TwoSum_GivenInput_ReturnIndexOfItemsWhichResultInSum()
        {
            // Arrange
            var input = new[] {3, 2, 4};
            var sut = new Solution();
            var sum = 6;

            // Act
            var res = sut.TwoSum(input, sum);

            // Assert
            res.Should().BeEquivalentTo(new[] {1,2});
        }
    }
}