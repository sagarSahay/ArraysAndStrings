using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace ThreeSum.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void ThreeSum_GivenInput_ReturnsAllCombinations()
        {
            // Arrange 
            var input = new[] {-1, 0, 1, 2, -1, -4};
            var sut = new Solution();

            // Act
            var res = sut.ThreeSum(input);

            // Assert
            res.Should().BeEquivalentTo(new List<IList<int>>()
            {
                new List<int>() {-1, 0, 1},
                new List<int>() {-1, -1, 2}
            });
        }
    }
}