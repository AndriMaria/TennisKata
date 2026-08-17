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
  public void FortyThirtyResults()
  {
     //arrange
      var game = new TennisKata();
      //acttest
      var result = game.GiveScore(3,2);
      //assert
      Assert.Equal("Forty-Thirty", result);
  }
  [Fact]
  public void ThirtyFortyResults()
  {
     //arrange
      var game = new TennisKata();
      //acttest
      var result = game.GiveScore(2,3);
      //assert
      Assert.Equal("Thirty-Forty", result);
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
  [Fact]
  public void FourZeroWinResults()
  {
    //arrange
      var game = new TennisKata();
      //acttest
      var result = game.GiveScore(4,0);
      //assert
      Assert.Equal("Win for player 1", result);
  }
  [Fact]
  public void ZeroFourWinResults()
  {
    //arrange
      var game = new TennisKata();
      //act
      var result = game.GiveScore(0,4);
      //assert
      Assert.Equal("Win for player 2", result);
  }
  [Fact]
  public void deuceResults()
  {
    //arrange
      var game = new TennisKata();
      //act
      var result = game.GiveScore(3,3);
      //assert
      Assert.Equal("deuce", result);
  }
  [Fact]
  public void AdvanceforPlayerOneResults()
  {
    //arrange
      var game = new TennisKata();
      //acttest
      var result = game.GiveScore(6,5);
      //assert
      Assert.Equal("Advance for player 1", result);
  }
  [Fact]
  public void AdvanceforPlayerTwoResults()
  {
    //arrange
      var game = new TennisKata();
      //act
      var result = game.GiveScore(5,6);
      //assert
      Assert.Equal("Advance for player 2", result);
  }

[Fact]
public void AdvancePlayer1AtFourThreeResults()
{
    //arrange
    var game = new TennisKata();
    //act
    var result = game.GiveScore(4,3);
    //assert
    Assert.Equal("Advance for player 1", result);
}
[Fact]
public void Player1WinResults()
  {
    //arrange
      var game = new TennisKata();
      //acttest
      var result = game.GiveScore(6,4);
      //assert
      Assert.Equal("Win for player 1", result);
  }
  [Fact]
  public void Player2WinResults()
  {
    //arrange
      var game = new TennisKata();
      //act
      var result = game.GiveScore(3,5);
      //assert
      Assert.Equal("Win for player 2", result);
  }
  
}
