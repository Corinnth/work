using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pa4_2
{
  class Program
  {
    static void Main(string[] args)
    {
      int userSelection = 0,
          computerSelection = 0,
          userWins = 0,
          computerWins = 0,
          tieCount = 0,
          winner = 0;
      while (true)
      {
        userSelection = ReadInput("\nWelcome to the RPS Game!!" +
                                  "\nTo play the game, enter your selection : " +
                                  "\n1 for Rock, 2 for Paper, 3 for Scissors: ");
        
        GetWinner(userSelection, computerSelection);
        if(ReadInput("\nDo you want to continue? (1 for yes, -1 for no)?: ") == -1)
        {
          Stats(userWins, computerWins, tieCount);
          break;
        }//end if
        switch (winner)
        {
          case 0:
            tieCount++;
            break;
          case 1:
            computerWins++;
            break;
          case 2:
            userWins++;
            break;
        }
      }//end while
     Console.ReadLine();
    }//end main
    public static int ReadInput(string question)
    {
      Console.Write(question);
      return int.Parse(Console.ReadLine());
    }//end ReadInput


    public static int GenerateRandomNumber(int min, int max)
    {
      Random r = new Random();
      return r.Next(min, max);
    }//end ComputerSelection

    public static int GetWinner(int userSelection, int computerSelection)
    {
     int winner = 0,// determines who wins the game
         tieCount = 0,// stores the number of ties
         userWins = 0,// stores the number of user wins
         computerWins = 0;// stores the number of computer wins
     
      computerSelection = GenerateRandomNumber(1,4);
      switch(userSelection)
      {
        case 1:
          Console.Write("\nUser Selection is Rock");
          break;

        case 2:
          Console.Write("\nUser Selection is Paper");
          break;

        case 3:
          Console.Write("\nUser Selection is Scissors");
          break;
      }//end switch
        switch(computerSelection)
        {
          case 1:
            Console.Write("\nComputer Selection is Rock");
            break;

          case 2:
            Console.Write("\nComputer Selection is Paper");
            break;

          case 3:
            Console.Write("\nComputer Selection is Scissors");
            break;
        }//end switch
       if(userSelection == computerSelection)
       {
        winner = 0;
        Console.Write("\nIt's a tie");
       }//end if
       else if(userSelection ==1 && computerSelection == 2)
       {
        winner = 1;
        Console.Write("\nThe computer wins!");
       }//end else if

       else if (userSelection == 2 && computerSelection == 3)
       {
         winner = 1;
         Console.Write("\nThe computer wins!");
       }//end else if

       else if (userSelection == 3 && computerSelection == 1)
       {
         winner = 1;
         Console.Write("\nThe computer wins!");
       }//end else if

       else if(userSelection == 1 && computerSelection == 3)
       {
        winner = 2;
        Console.Write("\nYou win!");
       }//end else if

       else if (userSelection == 2 && computerSelection == 1)
       {
         winner = 2;
         Console.Write("\nYou win!");
       }//end else if

       else if (userSelection == 3 && computerSelection == 2)
       {
         winner = 2;
         Console.Write("\nYou win!");
       }//end else if
     return winner;
    }// GetWinner

    public static void Stats(int userWins, int computerWins, int tieCount)
    {
      string output = "\nFinal Results :" +
                "\nNumber of user wins: " + userWins.ToString() +
                "\nNumber of computer wins: " + computerWins.ToString() +
                "\nNumber of ties: " + tieCount.ToString();
      Console.WriteLine(output);
    }//end Stats
  }//end class
}//end namespace