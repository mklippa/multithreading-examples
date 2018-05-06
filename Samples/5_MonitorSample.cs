using System;
using System.Threading;

namespace multithreading
{
    public class MonitorSample : IRunable
    {
        // Monitor.Enter
        // Monitor.Exit
        // Monitor.Wait - ожидает Pulse или PulseAll
        // Monitor.Pulse - уведомляет первый в очереди Wait
        // Monitor.PulseAll - уведомляет все Wait из очереди
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
            try
            {
                Monitor.Enter(locker);x = 0;
                for (int i = 0; i < 9; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {x++}");
                    Thread.Sleep(300);
                }
            }
            finally
            {
                Monitor.Exit(locker);
            }            
        }
    } 
}
