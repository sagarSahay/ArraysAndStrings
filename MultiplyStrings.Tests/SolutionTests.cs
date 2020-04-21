using FluentAssertions;
using Xunit;

namespace MultiplyStrings.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void MultiplyString_GivenTwoString_ReturnsResultOfMultiplication()
        {
            // Arrange 
            var input = "123";
            var input2 = "456";
            
            var sut= new Solution();
            
            // Act
            var res = sut.Multiply(input, input2);
            
            // Assert
            res.Should().Be("56088");
        }
    }
}