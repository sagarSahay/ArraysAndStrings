using FluentAssertions;
using Xunit;

namespace ProductOfArrayExceptSelf.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void ProductExceptSelf_WhenGivenInput_ReturnProductExceptSelf()
        {
            // Arrange
            var input = new[] { 1,2,3,4};
            var sut = new Solution();
            
            // Act
            var res = sut.ProductExceptSelf(input);
            
            // Assert
            res.Should().BeEquivalentTo(new[] {24, 12, 8, 6});
        }
    }
}