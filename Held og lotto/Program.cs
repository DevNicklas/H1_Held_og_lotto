using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Held_og_lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Waits for an user to press any key
            Console.WriteLine("Press any key to draw a new lottery ticket.");
            Console.ReadKey(true);

            // Loops until another key than R is pressed when asked
            do
            {
                Console.Clear();
                Console.WriteLine("Your lottery ticket:");

                // Instance of the Random class
                Random rand = new Random();

                // Array with a 8 elements.
                // All 8 elements will be set to a random number from 1 to 36
                int[] lotteryArr = new int[8];

                // Counter for while loop
                int counter = 0;

                // Sets the index of the array to the random number if
                // the array doesn't contain the number already
                while (lotteryArr[7] == 0)
                {
                    int randomNum = rand.Next(1, 37);
                    if (!lotteryArr.Contains(randomNum))
                    {
                        lotteryArr[counter] = randomNum;
                        counter++;
                    }
                }

                // Sets the joker number to the last index of the lottery array
                int joker = lotteryArr[lotteryArr.Length - 1];

                // Sorts the lottery array from low to hight (ascending)
                Array.Sort(lotteryArr);

                // Writes the lottery numbers without the joker with 2 seconds delay between each number
                for (int i = 0; i < 7; i++)
                {
                    Console.Write(lotteryArr[i] + "   ");
                    System.Threading.Thread.Sleep(2000);
                }

                // Writes the joker number
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(joker);

                // Gives the user a opportunity to draw a new lottery ticket
                Console.ResetColor();
                Console.Write("\nPress R to draw a new lottery ticket, or any other key for closing the program");
            } while (Console.ReadKey(true).Key == ConsoleKey.R);
        }
    }
}
