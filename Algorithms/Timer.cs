using System;
using System.Diagnostics;

namespace Algorithms
{
    /// <summary>
    /// This class is used for misurements. It counts the elapsed time between the calls of the two methods Start() and Stop()
    /// If you want, you can go with StopWatch which does the same.
    /// </summary>
    public class Timer
    {
        private TimeSpan _startingTime;
        private TimeSpan _duration;

        public Timer()
        {
            _startingTime = new TimeSpan(0);
            _duration = new TimeSpan(0);
        }

        public void Start()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            _startingTime = Process.GetCurrentProcess()
                .Threads[0]
                .UserProcessorTime;
        }

        public void Stop()
        {
            _duration = Process.GetCurrentProcess()
                .Threads[0]
                .UserProcessorTime.Subtract(_startingTime);
        }

        public TimeSpan GetDuration()
        {
            return _duration;
        }
    }
}
