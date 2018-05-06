using System;
using System.Threading;

namespace multithreading
{
    public class ParametrizedThreadStartSample : IRunable
    {
        public void Run()
        {
            var t = new Thread(new ParameterizedThreadStart(Utils.Count));
            t.Start(4);

            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Main thread:");
                Console.WriteLine(i * i);
                Thread.Sleep(300);
            }
        }
    }
}
