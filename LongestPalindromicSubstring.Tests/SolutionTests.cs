namespace LongestPalindromicSubstring.Tests
{
    using FluentAssertions;
    using Xunit;

    public class SolutionTests
    {
        [Fact]
        public void LongestPalindrome_GivenInput_ReturnsLongestPalindrome()
        {
            // Arrange
            var str = "babad";
            var sut = new Solution();
            
            // Act
            var res = sut.LongestPalindrome(str);
            
            // Assert
            res.Should().Be("bab");
        }
    }
}