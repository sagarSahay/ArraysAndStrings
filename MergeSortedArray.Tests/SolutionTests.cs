using FluentAssertions;
using Xunit;

namespace MergeSortedArray.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void MergeSortedArrays_GivenInput_MergesArrays()
        {
            // Arrange
            var input = new[] {1, 2, 3, 0, 0, 0};
            var m = 3;
            var input2 = new[] {2, 5, 6};
            var n = 3;
            var sut = new Solution();

            // Act
            sut.Merge(input, m, input2, n);
            
            // Assert
            input.Should().BeEquivalentTo(new[] {1, 2, 2, 3, 5, 6});
        }
    }
}