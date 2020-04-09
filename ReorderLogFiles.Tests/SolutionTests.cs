using FluentAssertions;
using Xunit;

namespace ReorderLogFiles.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void ReorderLogFiles_WhenGivenInput_ReordersLogFiles()
        {
            // Arrange 
            var input = new[] {"dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero"};
            var sut= new Solution();
            
            // Act
            var res = sut.ReorderLogFiles(input);
            
            // Assert
            res.Should().BeEquivalentTo(new[]
                {"let1 art can", "let3 art zero", "let2 own kit dig", "dig1 8 1 5 1", "dig2 3 6"});
        }
    }
}