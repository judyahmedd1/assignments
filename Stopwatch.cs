using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOPs2ass
{
    internal class Stopwatch
    {
        private DateTime _starttime;
        private TimeSpan _durationtime;
        private bool isrunning;

        public TimeSpan Durationtime
        {
            get { return _durationtime; }
        }

        public void start() {
            if (isrunning)
            {
                throw new InvalidOperationException("stopwatch is already running");
            }
            else
            {
                _starttime = DateTime.Now;
                isrunning = true;
            }
        
        }
        public void stop() {
            if (!isrunning)
            {
                throw new InvalidOperationException("stopwatch hasn't started yet");
            }

            _durationtime = DateTime.Now - _starttime;
            isrunning = false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();

            Console.WriteLine("To Start press 0");
            Console.WriteLine("To end press 1");
            Console.WriteLine("To Show interval press 2");
            Console.WriteLine("To exit press 3");
            while (true)
            {
                string choose = Console.ReadLine();
                int x = Convert.ToInt32(choose);

                if (x == 0)
                {
                    watch.start();
                }

                if (x == 1)
                {
                    watch.stop();
                }

                if (x == 2)
                {
                    Console.WriteLine(watch.Durationtime);
                }

                if (x == 3)
                {
                    return;
                }
            }
        }
    }
}
    
