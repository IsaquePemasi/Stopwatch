using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Start(5);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("StopWatch finalizado.");
            Thread.Sleep(0500);
        }
    }
}