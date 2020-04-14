using FluentAssertions;
using Xunit;

namespace ValidParentheses.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void IsValid_WhenGivenInput_ReturnsTrueIfExpressionIsValid()
        {
            // Arrange 
            var input = "()";
            var sut = new Solution();
            
            // Act
            var res = sut.IsValid(input);
            
            // Assert
            res.Should().BeTrue();
        }
    }
}