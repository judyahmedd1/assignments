using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_1_2
{
    internal class Program
    {
        //how to generate a random number
        double NextDouble(Random rng, double min, double max)
        {
            return min + (rng.NextDouble() * (max - min));
        } 
        static void Main(string[] args)
        {
            //How to take input from user take number, chars
            Console.WriteLine("enter a number and a character");
            int num = int.Parse(Console.ReadLine());
            char ch = Console.ReadLine()[0];




            //assignment 2
            //string.Substring() is used to extract part of a string.
            //string.Substring(startIndex)
            string text = "judy ahmed";
            Console.WriteLine(text.Substring(6));

            //string.Compare() is used to compares two strings alphabetically
            /* Negative → first string comes before second.
               Zero → equal.
               Positive → first string comes after second.*/
            Console.WriteLine(string.Compare("judy", "ahmed"));

            /*stack stores items using LIFO (Last In, First Out).
             Queue stores items using FIFO (First In, First Out).*/

            //factorial 
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            double factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"{number}! = {factorial}");



            //movie theatre
            int[,] seats = new int[4, 4];
            int bookedseats = 0;
            int totalseats = 16;

            while (bookedseats < totalseats)
            {
                Console.WriteLine("Enter row number: ");
                int row = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter column number: ");
                int col = int.Parse(Console.ReadLine());

                if (row < 0 || row > 3 || col < 0 || col > 3)
                {
                    Console.WriteLine("Invalid seat, row and column must be between 0 and 3");
                    continue;
                }

                if (seats[row, col] == 1)
                {
                    seats[row, col] = 0;
                    bookedseats++;

                    Console.WriteLine("Seat booked");
                }
                else
                {
                    Console.WriteLine("This seat is booked");
                }
            }
            }
        
        }
}
