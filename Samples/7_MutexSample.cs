using System;
using System.Threading;

namespace multithreading
{
    public class MutexSample : IRunable
    {
        static int x;
        static Mutex mutex = new Mutex();
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
            mutex.WaitOne();
            x = 0;
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}: {x++}");
                Thread.Sleep(300);
            }
            mutex.ReleaseMutex();
        }
    }
}
