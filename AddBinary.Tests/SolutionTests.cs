using FluentAssertions;
using Xunit;

namespace AddBinary.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void AddBinary_GivenInput_ReturnsBinaryAdditionResult()
        {
            // Arrange
            var input1 = "11";
            var input2 = "1";
            var sut = new Solution();
            
            // Act
            var res = sut.AddBinary(input1, input2);
            
            // Assert
            res.Should().Be("100");
        }
    }
}