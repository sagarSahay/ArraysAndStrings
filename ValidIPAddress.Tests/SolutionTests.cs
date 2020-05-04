namespace ValidIPAddress.Tests
{
    using FluentAssertions;
    using Xunit;

    public class SolutionTests
    {
        [Fact]
        public void ValidIpAddress_GivenInput_ValidateIpV4orIPv6()
        {
            // Arrange 
            var input = "15.16.-0.1";
            var sut = new Solution();
            
            // Act
            var res = sut.ValidIPAddress(input);
            
            // Assert
            res.Should().Be("Neither");
        }
    }
}