using System;
using System.Threading;

namespace multithreading
{
    public class TimerSample : IRunable
    {
        public void Run()
        {
            var timer = new Timer(Print,null,0,1000);

            Console.ReadLine();
        }

        public void Print(object state)
        {
            Console.WriteLine("Hello, world!");
        }
    }
}
