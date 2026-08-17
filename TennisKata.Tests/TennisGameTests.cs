using Newtonsoft.Json.Linq;
using Xunit;

namespace TennisKata.Tests;

public class TennisTests
{ //Love-All Test
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
    //1-0 test
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
    //0-1 test
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
    //Comment: 0-2 test
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
    //Comment: 2-0 test
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
    //Comment: 3-0 test
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
    //Comment: 0-3 test
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
    //Comment: 1-1 test
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
  //Comment: 1-2 test
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
  //Comment: 2-1 test
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
  //Comment: 3-2 test
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
  //Comment: 2-3 test
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
  //Comment: 2-2 test
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
  //Comment: 4-0 test
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
  //Comment: 0-4 test
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
  //Comment: deuce test
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
  //Comment: advantage for player 1 test
  [Fact]
  public void AdvanceforPlayerOneResults()
  {
    //arrange
      var game = new TennisKata();
      //acttest
      var result = game.GiveScore(6,5);
      //assert
      Assert.Equal("advantage for player 1", result);
  }
  //Comment: advantage for player 2 test
  [Fact]
  public void AdvanceforPlayerTwoResults()
  {
    //arrange
      var game = new TennisKata();
      //act
      var result = game.GiveScore(5,6);
      //assert
      Assert.Equal("advantage for player 2", result);
  }
  //Comment: win for player 1 test
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
   //Comment: win for player 2 test
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
