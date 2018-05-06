using System;

namespace multithreading
{
    public class IntroSample : IRunable
    {
        public void Run()
        {
            var t = System.Threading.Thread.CurrentThread;

            Console.WriteLine($"Thread name: {t.Name}");
            t.Name = "Test thread";
            Console.WriteLine($"Thread name: {t.Name}");

            Console.WriteLine($"Thread is alive: {t.IsAlive}");
            Console.WriteLine($"Thread priority: {t.Priority}");
            Console.WriteLine($"Thread state: {t.ThreadState}");
            Console.WriteLine($"App domain: {System.Threading.Thread.GetDomain().FriendlyName}");

            Console.ReadLine();
        }
    }
}
