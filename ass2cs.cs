using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2_session_3
{
    internal class ass2
    {
        static void Main(string[] args)
        {
            //factorial 
            Console.WriteLine("enter a number:");
            int numberr = int.Parse(Console.ReadLine());
            double factorial = 1;

            for (int i = 1; i <= numberr; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"{numberr}! = {factorial}");


            //movie theatre
            int[,] seats = new int[4, 4];
            int bookedseats = 0;
            int totalseats = 16;

            while (bookedseats < totalseats)
            {
                Console.WriteLine("enter row number: ");
                int row = int.Parse(Console.ReadLine());
                Console.WriteLine("enter column number: ");
                int col = int.Parse(Console.ReadLine());

                if (row < 0 || row > 3 || col < 0 || col > 3)
                {
                    Console.WriteLine("invalid seat, row and column must be between 0 and 3");
                    continue;
                }

                if (seats[row, col] == 0)
                {
                    seats[row, col] = 1;
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
