namespace ImplementStrStr.Tests
{
    using FluentAssertions;
    using ImplemenStrStr;
    using Xunit;

    public class SolutionTests
    {
        [Fact]
        public void StrStr_GivenNeedle_FindsItInHaystack()
        {
            // Arrange 
            var haystack = "hello";
            var needle = "ll";
            var sut = new Solution();
            
            // Act
            var res = sut.StrStr(haystack, needle);
            
            // Assert
            res.Should().Be(2);

        }
    }
}