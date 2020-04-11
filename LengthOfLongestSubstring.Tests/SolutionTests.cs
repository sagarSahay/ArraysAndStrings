namespace LengthOfLongestSubstring.Tests
{
    using FluentAssertions;
    using Xunit;

    public class SolutionTests
    {
        [Fact]
        public void LengthOfLongestSubstring_WhenGivenInput_ReturnsLengthOfLongestSubstring()
        {
            // Arrange 
            var input = "abcabcbb";
            var sut = new Solution();
            
            // Act
            var res = sut.LengthOfLongestSubstring(input);
            
            // Assert
            res.Should().Be(3);
        }
    }
}