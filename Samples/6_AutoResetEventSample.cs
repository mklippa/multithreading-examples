using System;
using System.Threading;

namespace multithreading
{
    public class AutoResetEventSample : IRunable
    {
        // если есть несколько объектов AutoResetEvent
        // AutoResetEvent.WaitAll - ожидает пока все перейдут в сигнальное состояние
        // AutoResetEvent.WaitAny - хотя бы один перейдет в сигнальное состоияние
        // AutoResetEvent.WaitAll(new WaitHandle[] {waitHandler});
        static int x;
        // true - сигнальное состояние
        // false - состояние ожидания
        static AutoResetEvent waitHandler = new AutoResetEvent(true);
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
                // переход в состояние ожидания
                waitHandler.WaitOne();
                x = 0;
                for (int i = 0; i < 9; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {x++}");
                    Thread.Sleep(300);
                }
            }
            finally
            {
                // переход в сигнальное состояние
                waitHandler.Set();
            }            
        }
    }
}
