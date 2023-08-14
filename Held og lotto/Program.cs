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

                // Draws a new lottery ticket
                DrawTicket();

                // Gives the user a opportunity to draw a new lottery ticket
                Console.ResetColor();
                Console.Write("\nPress Enter to draw a new lottery ticket, or any other key for closing the program");
            } while (Console.ReadKey(true).Key == ConsoleKey.Enter);
        }

        /// <summary>
        /// Draws a new ticket
        /// </summary>
        static void DrawTicket()
        {
            // Instance of the Random class
            Random rand = new Random();

            // Array with length of 8 which the lottery numbers will be put in
            int[] ticketNumbers = new int[8];

            // Counter for while loop
            int counter = 0;

            // Sets the index of the array to the random number if
            // the array doesn't contain the number already
            while (ticketNumbers[7] == 0)
            {
                int randomNum = rand.Next(1, 37);
                if(!ticketNumbers.Contains(randomNum))
                {
                    ticketNumbers[counter] = randomNum; 
                }
                counter++;
            }

            // Sort the 7 random numbers without a joker
            int joker = ticketNumbers[ticketNumbers.Length - 1];
            Array.Sort(ticketNumbers);

            // Writes the 7 random numbers with a delay of 2 seconds (2000ms)
            for (int i = 0; i < ticketNumbers.Length - 1; i++)
            {
                Console.Write(ticketNumbers[i] + "   ");
                System.Threading.Thread.Sleep(2000);
            }

            // Writes the joker number
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(joker);
        }
    }
}
