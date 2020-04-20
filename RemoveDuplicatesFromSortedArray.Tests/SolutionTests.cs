namespace RemoveDuplicatesFromSortedArray.Tests
{
    using FluentAssertions;
    using Xunit;

    public class SolutionTests
    {
        [Fact]
        public void RemoveDuplicates_GivenInput_ReturnsUniqueArrayLength()
        {
            // Arrange
            var input = new[] {1, 1, 2};
            var sut = new Solution();

            // Act
            var res = sut.RemoveDuplicates(input);

            // Assert
            res.Should().Be(2);
        }
    }
}