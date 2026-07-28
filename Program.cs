using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //assignment 1 session 2
            //simple Calculator
            double num1, num2;
            Console.Write("enter first number:");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Invalid input");
            }
            Console.Write("enter second number:");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Invalid input");
            }
            Console.Write("enter operation:");
            char op = Convert.ToChar(Console.ReadLine());
            if (op == '+')
            {
                Console.WriteLine("result = " + (num1 + num2));
            }
            else if (op == '-')
            {
                Console.WriteLine("result = " + (num1 - num2));
            }
            else if (op == '*')
            {
                Console.WriteLine("result = " + (num1 * num2));
            }
            else if (op == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine("can't divide by zero");
                }
                else
                {
                    Console.WriteLine("division = " + (num1 / num2));
                }
            }
            else
            {
                Console.WriteLine("invalid operation.");
            }


            //even or odd 
            int num;
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("even");
            else
                Console.WriteLine("odd");

            //max
            int num3, num4;
            Console.WriteLine("enter first number:");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number:");
            num4 = int.Parse(Console.ReadLine());

            if (num3 > num4)
                Console.WriteLine("max = " + num3);
            else
                Console.WriteLine("max = " + num4);

            //isvalid
            int number;
            Console.WriteLine("enter a number between 1 and 10:");
            number = int.Parse(Console.ReadLine());
            if (number >= 1 && number <= 10)
                Console.WriteLine("valid");
            else
                Console.WriteLine("invalid");

            //switch
            Console.WriteLine("enter a number between 1 and 7: ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Invalid day number.");
                    break;
            }

               
            }
        }
    }
}
        


    
    

