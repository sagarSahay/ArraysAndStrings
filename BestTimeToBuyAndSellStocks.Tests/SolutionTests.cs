using FluentAssertions;
using Xunit;

namespace BestTimeToBuyAndSellStocks.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void MaxProfit_WhenGivenStockPrices_GivesMaximumProfit()
        {
            // Arange
            var input = new[] {7, 1, 5, 3, 6, 4};
            var sut = new Solution();
            
            // Act
            var res = sut.MaxProfit(input);
            
            // Assert
            res.Should().Be(5);
        }
    }
}