using System;
using System.Threading;

namespace multithreading
{
    public class SemaphoreSample : IRunable
    {
        public void Run()
        {
            for (int i = 0; i < 6; i++)
            {
                var reader = new Reader(i);
            }

            Console.ReadLine();
        }
    }

    public class Reader
    {
        static Semaphore semaphore = new Semaphore(3, 3);
        Thread thread;
        int count = 3;

        public Reader(int i)
        {
            thread = new Thread(Read);
            thread.Name = $"Reader {i}";
            thread.Start();
        }

        public void Read()
        {
            while(count > 0)
            {
                semaphore.WaitOne();

                Console.WriteLine($"{Thread.CurrentThread.Name} comes in");
                Console.WriteLine($"{Thread.CurrentThread.Name} reads");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} comes out");

                semaphore.Release();

                count--;

                Thread.Sleep(1000);
            }
        }
    }
}
