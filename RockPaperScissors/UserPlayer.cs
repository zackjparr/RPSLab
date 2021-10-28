using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class UserPlayer : Player
    {
        public UserPlayer()
        {
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
        }

        //we want our user to select rock, paper, or scissors
        //and if we get anything else, ask for an RPS value again
        public override RPSEnum GetRPS()
        {
            Console.WriteLine("Please select ROCK, PAPER, or SCISSORS! (or R, P, or S)");
            string selection = Console.ReadLine().ToLower();

            switch (selection)
            {
                case "rock":
                    return RPSEnum.Rock;
                case "r":
                    return RPSEnum.Rock;
                case "paper":
                    return RPSEnum.Paper;
                case "p":
                    return RPSEnum.Paper;
                case "scissors":
                    return RPSEnum.Scissors;
                case "s":
                    return RPSEnum.Scissors;
                default:
                    Console.WriteLine("I'm sorry, I don't understand. \nPlease enter ROCK PAPER or SCISSORS.\n");
                    return GetRPS();
            }
        }
    }
}
