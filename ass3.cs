using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3session4
{
    internal class ass3
    {

        struct Point
        {
            public double x;
            public double y;
        }
        enum Days
        {
            sunday = 1,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday
        }
        static void Main()
        {

            //struct
            Point A;
            Point B;

            Console.WriteLine("enter x1: ");
            A.x = double.Parse(Console.ReadLine());

            Console.WriteLine("enter y1: ");
            A.y = double.Parse(Console.ReadLine());

            Console.WriteLine("enter x2: ");
            B.x = double.Parse(Console.ReadLine());

            Console.WriteLine("enter y2: ");
            B.y = double.Parse(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(B.x - A.x, 2) + Math.Pow(B.y - A.y, 2) );

            Console.WriteLine($"distance is: {distance}");



            //switch with enums
            Console.WriteLine("enter a number between 1 and 7: ");
            int num = int.Parse(Console.ReadLine());

            Days day = (Days)num;

            switch (day)
            {
                case Days.sunday:
                    Console.WriteLine("sunday");
                    break;

                case Days.monday:
                    Console.WriteLine("monday");
                    break;

                case Days.tuesday:
                    Console.WriteLine("tuesday");
                    break;

                case Days.wednesday:
                    Console.WriteLine("wednesday");
                    break;

                case Days.thursday:
                    Console.WriteLine("thursday");
                    break;

                case Days.friday:
                    Console.WriteLine("friday");
                    break;

                case Days.saturday:
                    Console.WriteLine("saturday");
                    break;

                default:
                    Console.WriteLine("invalid number");
                    break;
            }

        }
    }
}
   
