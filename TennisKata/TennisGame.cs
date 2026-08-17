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
      return score[0] + "-All";
    }
     else if ((player1points > player2points)||(player2points> player1points))
    {
      return score[player1points] + "-" + score[player2points];
    }
    else
    {
      return "0";
    }
    }
  

} 
