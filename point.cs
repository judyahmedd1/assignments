using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPS3ass1;

namespace OOPS3ass1
{
    class point { 
        //fields
        private int _x;
        private int _y;
        //properties
        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }
        //constructor
        public point(int x, int y)
        {
            X=x; 
            Y=y;
        }

        //+ operator overloading
        public static point operator +(point A, point B)
        {
            return new point(A.X + B.X, A.Y + B.Y);
        }

        //< , > operators overloading
        public static bool operator >(point A, point B)
        {
            return (A.X * A.X + A.Y * A.Y) >
                   (B.X * B.X + B.Y * B.Y);
        }
        public static bool operator <(point A, point B)
        {
            return (A.X * A.X + A.Y * A.Y) <
                   (B.X * B.X + B.Y * B.Y);
        }

        //<= , >= operators overloading
        public static bool operator <=(point A, point B)
        {
            return (A.X * A.X + A.Y * A.Y) <=
                   (B.X * B.X + B.Y * B.Y);
        }
        public static bool operator >=(point A, point B)
        {
            return (A.X * A.X + A.Y * A.Y) >=
                   (B.X * B.X + B.Y * B.Y);
        }

        public void displaypoints()
        {
            Console.WriteLine($"point is: ({X}, {Y})");
        }
    }
}


    internal class Program
    {
        static void Main(string[] args)
        {
        point a = new point(1, 2);
        point b = new point(3, 4);
        point c= a + b;

        Console.Write("a + b = ");
        c.displaypoints();

        bool d = a > b;
        bool e = a <= b;
        Console.WriteLine($"is a>b: {d}");
        Console.WriteLine($"is a<=b: {e}");

    }
    }

