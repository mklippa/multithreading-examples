namespace multithreading
{
    partial class Program
    {
        static void Main(string[] args)
        {
            IRunable item = 
            // new IntroSample();
            // new ThreadSample();
            // new ParametrizedThreadStartSample();
            // new ThreadSynchSample();
            // new MonitorSample();
            new AutoResetEventSample();

            item.Run();
        }
    }
}
