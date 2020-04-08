namespace MostCommonWords.Tests
{
    using FluentAssertions;
    using Xunit;

    public class SolutionTests
    {
        [Fact]
        public void MostCommonWord_ReturnsMostCommonWord()
        {
            // Arrange
            //var paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";

           // var banned = new[] {"hit"};
           var paragraph = "Bob. hIt, baLl";

           var banned = new string[] {"bob", "hit"};
            
            var sut = new Solution();
            
            // Act
             var res = sut.MostCommonWord(paragraph, banned);
            
            // Assert
            res.Should().Be("ball");
        }
    }
}