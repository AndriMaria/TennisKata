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
    public void LoveThirtyResult()
    {
      //arrange
      var game = new TennisKata();
      //acttest
      var result = game.GiveScore(0,2);
      //assert
      Assert.Equal("Love-Thirty", result);
    }
    [Fact]
    public void ThirtyLoveResult()
    {
      //arrange
      var game = new TennisKata();
      //acttest
      var result = game.GiveScore(2,0);
      //assert
      Assert.Equal("Thirty-Love", result);
    }
    [Fact]
    public void FortyLoveResult()
    {
      //arrange
      var game = new TennisKata();
      //acttest
      var result = game.GiveScore(3,0);
      //assert
      Assert.Equal("Forty-Love", result);
    }
    [Fact]
    public void LoveFortyResult()
    {
      //arrange
      var game = new TennisKata();
      //acttest
      var result = game.GiveScore(0,3);
      //assert
      Assert.Equal("Love-Forty", result);
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
    public void FifteenThirtyResults()
  {
    //arrange
      var game = new TennisKata();
      //acttest
      var result = game.GiveScore(1,2);
      //assert
      Assert.Equal("Fifteen-Thirty", result);
  }
  [Fact]
    public void ThirtyFifteenResults()
  {
    //arrange
      var game = new TennisKata();
      //acttest
      var result = game.GiveScore(2,1);
      //assert
      Assert.Equal("Thirty-Fifteen", result);
  }
  [Fact]
  public void ThirtyThirtyResults()
  {
    //arrange
      var game = new TennisKata();
      //acttest
      var result = game.GiveScore(2,2);
      //assert
      Assert.Equal("Thirty-Thirty", result);
  }
    
}
