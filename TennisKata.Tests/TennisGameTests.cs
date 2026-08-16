using Xunit;

namespace TennisKata.Tests;

public class TennisTests
{
    [Fact]
    public void BothZeroLoveAllResult()
    {
      //arrange
      var game = new TennisKata();
      //act
      var result = game.GiveScore();
      //assert
      Assert.Equal("Love-All", result);
    }
}
