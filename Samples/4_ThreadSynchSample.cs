using System;
using System.Threading;

namespace multithreading
{
    public class ThreadSynchSample : IRunable
    {
        static int x;
        static object locker = new object();
        public void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                var t = new Thread(Count);
                t.Name = $"Thread {i}";
                t.Start();
            }
        }

        private void Count()
        {
            lock(locker)
            {
                x = 0;
                for (int i = 0; i < 9; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {x++}");
                    Thread.Sleep(300);
                }
            }
        }
    }
}
