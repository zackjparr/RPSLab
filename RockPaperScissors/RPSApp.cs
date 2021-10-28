using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class RPSApp
    {
        public UserPlayer Player { get; set; } = new UserPlayer();
        //we leave this property blank, since we want the user to select who they play again
        public Player Opponent { get; set; }

        public RPSApp()
        {
            //Later on once we have randa, replace this line with code that lets the play choose their opponent
            Console.WriteLine("CHOOSE YOUR FIGHTER:\n[1]ROCKY the no nonsense rock master!\n[2]RANDA the unpredictable!");
            string selection = Console.ReadLine().Trim();

            switch (selection)
            {
                case "1":
                    Opponent = new Rocky();
                    break;
                case "2":
                    Opponent = new Randa();
                    break;
                default:
                    Console.WriteLine("You haven't unlocked that fighter yet.\nPlease try again!");
                    break;
            }
        }

        public void Play()
        {
            RPSEnum player = Player.GetRPS();
            RPSEnum opponent = Opponent.GetRPS();
            int win = 0;
            int loss = 0;
            int draw = 0;
                switch (player)
                {
                    case RPSEnum.Rock:
                        if (opponent == RPSEnum.Rock)
                        {
                        Console.WriteLine("IT'S A DRAW.");
                        draw++;
                        }
                        else if (opponent == RPSEnum.Paper)
                        {
                        Console.WriteLine($"YOU LOSE! FATALITY! {opponent} beats {player}");
                        loss++;
                        }
                        else if (opponent == RPSEnum.Scissors)
                        {
                        Console.WriteLine($"YOU WIN! +100 XP GAINED. {player} beats {opponent}");
                        win++;
                        }
                        break;
                    case RPSEnum.Paper:
                        if (opponent == RPSEnum.Rock)
                        {
                        Console.WriteLine($"YOU WIN! +100 XP GAINED. {player} beats {opponent}");
                        win++;
                        }
                        else if (opponent == RPSEnum.Paper)
                        {
                        Console.WriteLine("IT'S A DRAW.");
                        draw++;
                        }
                        else if (opponent == RPSEnum.Scissors)
                        {
                        Console.WriteLine($"YOU LOSE! FATALITY! {opponent} beats {player}");
                        loss++;
                        }
                        break;
                    case RPSEnum.Scissors:
                        if (opponent == RPSEnum.Rock)
                        {
                        Console.WriteLine($"YOU LOSE! FATALITY! {opponent} beats {player}");
                        loss++;
                        }
                        else if (opponent == RPSEnum.Paper)
                        {
                        Console.WriteLine($"YOU WIN! +100 XP GAINED. {player} beats {opponent}");
                        win++;
                        }
                        else if (opponent == RPSEnum.Scissors)
                        {
                        Console.WriteLine("IT'S A DRAW.");
                        draw++;
                        }
                        break;
                }
            Continue();
            Console.WriteLine($"You record is: {win} wins, {loss} losses, and {draw} draws!");
            }

        public void Continue()
        {
            Console.WriteLine("Would you like to continue? y/n");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                Play();
            }
            else if (answer == "n")
            {
                Console.WriteLine("Have a nice day!");
            }
            else
            {
                Console.WriteLine("I'm sorry, I don't understand, please try again. Enter only y/n.");
                Continue();
            }

        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string output = Console.ReadLine();
            return output;
        }
    }
}
