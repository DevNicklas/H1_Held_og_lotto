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
            do
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
                Console.Write(joker + "\nPress R to draw new lottery ticket, or any other key for closing the program");
            } while (Console.ReadKey(true).Key == ConsoleKey.R);
        }
    }
}
