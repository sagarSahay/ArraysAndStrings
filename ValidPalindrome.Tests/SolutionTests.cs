using FluentAssertions;
using Xunit;

namespace ValidPalindrome.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void IsPalindrome_GivenInput_ReturnsValidPalindrome()
        {
            // Arrange 
            var input = "A man, a plan, a canal: Panama";
            var sut = new Solution();
            
            // Act
            var res = sut.IsPalindrome(input);
            
            // Assert
            res.Should().BeTrue();
        }
    }
}