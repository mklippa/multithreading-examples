using System;
using System.Threading;

namespace multithreading
{
    public class MutexSingleAppSample : IRunable
    {
        public void Run()
        {
            var mutex = new Mutex(true, "foo", out bool exists);

            if (exists)
            {
                Console.WriteLine("First instance");
            }
            else
            {
                Console.WriteLine("App has already been started");
                return;
            }
            Console.ReadLine();
        }
    }
}
