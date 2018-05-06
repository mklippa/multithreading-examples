using System;
using System.Threading;

namespace multithreading
{
    public class ThreadSample : IRunable
    {
        public void Run()
        {
            Thread t = new Thread(new ThreadStart(Utils.Count));
            t.Start();

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Main thread:");
                Console.WriteLine(i*i);
                Thread.Sleep(300);
            }
        }
    }
}
