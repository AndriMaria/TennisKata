using System;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

namespace TennisKata;

public class TennisKata
{

  public string GiveScore(int player1points,int player2points)
  {
    
    string[] score = {"Love","Fifteen","Thirty","Forty"};
    //case 0-0
      if(player1points == 0 && player2points == 0)
    {
      return score[player1points] + "-All";
    }
    // case 3-3,3-4,4-4,-3-5 ect
     else if(player1points>=3 && player2points>= 3)
    {
      if(player1points == player2points)
      {
        return "deuce";
      }
      else if (player1points - player2points == 1)
      {
        return "advantage for player 1";
      }
      else if (player2points - player1points == 1)
      {
        return "advantage for player 2";
      }
      else if (player1points - player2points >= 2)
      {
        return "Win for player 1";
      }
      else if (player2points - player1points >= 2)
      {
        return "Win for player 2";
      }
      else return "0";
      
    }
    // case 3-0,3-2,3-1,1-3 etc from zero to three for both players
      else if (player1points < 4 && player2points < 4)
    {
      return score[player1points] + "-" + score[player2points];
    }
//case for 4-0,0-4,4-1 etc
     else if (player1points>=4 || player2points>= 4)
    { 
      if (player1points <=2 )
      return "Win for player 2";
      else 
      return "Win for player 1";
      
    }
    else
    {
      return "0";
    }
  }
  

} 
