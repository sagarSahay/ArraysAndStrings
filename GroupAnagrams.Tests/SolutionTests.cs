using FluentAssertions;
using Xunit;

namespace GroupAnagrams.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void GroupAnagrams_GivenStr_ReturnsAnagrams()
        {
            // Arrange
            var input = new[] {"eat", "tea", "tan", "ate", "nat", "bat"};
            var sut = new Solution();

            // Act
            var res = sut.GroupAnagrams(input);

            // Assert
            res.Should().BeEquivalentTo(new[] {"ate", "eat", "tea"}, new[] {"nat", "tan"}, new[] {"bat"});
        }
    }
}