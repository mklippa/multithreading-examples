using System;
using System.Threading;

namespace multithreading
{
    public static class Utils
    {
        public static void Count()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Second thread:");
                Console.WriteLine(i * i);
                Thread.Sleep(400);
            }
        }

        public static void Count(object x)
        {
            var n = (int)x;

            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Second thread:");
                Console.WriteLine(i * n);
                Thread.Sleep(400);
            }
        }
    }
}
