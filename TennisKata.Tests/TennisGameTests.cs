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
      var result = game.GiveScore(0,0);
      //assert
      Assert.Equal("Love-All", result);
    }
     [Fact]
    public void FifteenLoveResult()
    {
      //arrange
      var game = new TennisKata();
      //act
      var result = game.GiveScore(1,0);
      //assert
      Assert.Equal("Fifteen-Love", result);
    }
     [Fact]
    public void LoveFitfteenResult()
    {
      //arrange
      var game = new TennisKata();
      //acttest
      var result = game.GiveScore(0,1);
      //assert
      Assert.Equal("Love-Fifteen", result);
    }
    [Fact]
    public void FifteenFifteenResults()
  {
    //arrange
      var game = new TennisKata();
      //acttest
      var result = game.GiveScore(1,1);
      //assert
      Assert.Equal("Fifteen-Fifteen", result);
  }
  [Fact]
  public void ThirtyThirtyResults()
  {
    //arrange
      var game = new TennisKata();
      //acttest
      var result = game.GiveScore(1,1);
      //assert
      Assert.Equal("Thirty-Thirty", result);
  }
    
}
