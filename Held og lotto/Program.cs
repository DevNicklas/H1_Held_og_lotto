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
            // Loops until another key than R is pressed when asked
            do
            {
                // Waits for an user to press any key
                Console.WriteLine("Press any key to draw a new lottery ticket.");
                Console.ReadKey(true);

                Console.Clear();
                Console.WriteLine("Your lottery ticket:");

                // Draws a new lottery ticket
                DrawTicket();

                // Gives the user a opportunity to draw a new lottery ticket
                Console.ResetColor();
                Console.Write("\nPress R to draw a new lottery ticket, or any other key for closing the program");
            } while (Console.ReadKey(true).Key == ConsoleKey.R);
        }

        /// <summary>
        /// Draws a new ticket
        /// </summary>
        static void DrawTicket()
        {
            // Instance of the Random class
            Random rand = new Random();

            // Gets 7 random numbers
            int[] test = new int[8];
            for (int i = 0; i < 8; i++)
                test[i] = rand.Next(1, 37);

            // Sort the 7 random numbers without a joker
            int joker = test[test.Length - 1];
            Array.Sort(test);

            // Writes the 7 random numbers with a delay of 2 seconds (2000ms)
            for (int i = 0; i < test.Length - 1; i++)
            {
                Console.Write(test[i] + "   ");
                System.Threading.Thread.Sleep(2000);
            }

            // Writes the joker number
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(joker);
        }
    }
}
