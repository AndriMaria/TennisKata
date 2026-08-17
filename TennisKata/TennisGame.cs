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

      if(player1points == 0 && player2points == 0)
    {
      return score[player1points] + "-All";
    }
     else if(player1points>=4 && player2points>= 4)
    {
      if(player1points == player2points)
      {
        return "deuce";
      }
      else if (player1points - player2points == 1)
      {
        return "Advance for player 1";
      }
      else if (player2points - player1points == 1)
      {
        return "Advance for player 2";
      }
      else return "0";
      
    }
      else if (player1points < 4 && player2points < 4)
    {
      return score[player1points] + "-" + score[player2points];
    }

     else if (player1points>=4 || player2points>= 4)
    { 
      if(player1points <=2 )
      return "Win for player 2";
      else 
      return "Win for player 1";
      
    }
     else if (player1points < 4 || player2points < 4)
    {
      if (player2points - player1points == 2)
      {
         return "Win for player 2";
      }
      else if (player1points - player2points == 1)
      {
        return "Win for player 1";
      }
      else return score[player1points] + "-" + score[player2points];
    }
    else
    {
      return "0";
    }
  }
  

} 
