using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalScore = 0;
            int turnScore = 0;
            int turn = 1;

            while (totalScore < 20)
            {
                Console.WriteLine("TURN {0}:", turn);
                Console.Write("Enter 'r' to roll again, 'h' to hold: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "r")
                {
                    int roll = RollDice();
                    Console.WriteLine("You rolled: {0}", roll);

                    if (roll == 1)
                    {
                        Console.WriteLine("Turn over. No Score");
                        turnScore = 0;
                        turn++;
                    }
                    else
                    {
                        turnScore += roll;
                        Console.WriteLine("Your turn score is {0} and your total score is {1}", turnScore, totalScore);
                    }
                }
                else if (input.ToLower() == "h")
                {
                    totalScore += turnScore;
                    Console.WriteLine("Your turn score is {0} and your total score is {1}", totalScore, totalScore);
                    turnScore = 0;
                    turn++;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'r' or 'h'.");
                }
            }

            Console.WriteLine("You Win!");
            Console.WriteLine("You finished in turns! - "+turn);
        }

        static int RollDice()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }
    }
}
