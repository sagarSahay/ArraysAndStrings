namespace LengthOfLongestSubstringKDistinct.Tests
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
    using Xunit;

    public class SolutionTests
    {
        [Fact]
        public void LengthOFLongestSubstring_GivenInput_ReturnsLength()
        {
            // Arrange
            var input = "bacc";
            var k = 2;
            var sut = new Solution();
            
            // Act
            var res = sut.LengthOfLongestSubstringKDistinct(input, 2);
            
            // Assert
            res.Should().Be(3);

        }
    }
}