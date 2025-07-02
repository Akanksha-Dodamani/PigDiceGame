using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame
{
    internal class PigDiceClass
    {
        public static int turnScore, totalScore;
        public static void PigDice()
        {
            int diceNumber, targetValue, turn = 1;
            string operation;

            Console.WriteLine("Enter your target value:");
            targetValue = int.Parse(Console.ReadLine());

            for (turn = 1; turn <= 3; turn++)
            {
                Console.WriteLine($"Turn {turn}");

                Console.WriteLine("Want to roll or hold (r/h):");          // to initial operation at start of turn
                operation = Console.ReadLine();

                if (operation == "h")
                {
                    Console.WriteLine($"Turn Score: {turnScore}");
                    continue;                                       // here "continue" to increment the turn
                }
                while (operation == "r")
                {
                    Random random = new Random();
                    diceNumber = random.Next(1, 10);

                    if (diceNumber == 1)
                    {
                        turnScore = 0;
                        Console.WriteLine("Ohh no....You rolled 1. You get 0 points in this turn!!");
                        //Console.WriteLine($"Turn Score: {turnScore}");
                        break;                                            // here "break" to end the turn
                    }
                    else
                    {
                        Console.WriteLine($"Die: {diceNumber}");
                        turnScore += diceNumber;
                        Console.WriteLine("Want to Roll or hold (r/h):");    // to check the operation after every roll
                        operation = Console.ReadLine();
                    }
                }
                Console.WriteLine($"Your Turn {turn} ended!!");
                Console.WriteLine($"Turn Score: {turnScore}");
                totalScore += turnScore;
                turnScore = 0;
            }
            Console.WriteLine($"Total Score: {totalScore}");
            if (totalScore == targetValue)
            {
                Console.WriteLine("Congrats!! You won the game!");
            }
            else
            {
                Console.WriteLine("You lose the game!! Better luck next time");
            }
        }
    }
}
