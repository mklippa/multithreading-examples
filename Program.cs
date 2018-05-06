using System.Runtime.InteropServices;

namespace multithreading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IRunable item = 
            // new IntroSample();
            // new ThreadSample();
            // new ParametrizedThreadStartSample();
            // new ThreadSynchSample();
            // new MonitorSample();
            // new AutoResetEventSample();
            // new MutexSample();
            // new MutexSingleAppSample();
            // new SemaphoreSample();
            new TimerSample();

            item.Run();
        }
    }
}
