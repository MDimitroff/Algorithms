using System;
using System.Diagnostics;

namespace Utils
{
    /// <summary>
    /// This class measures how much processor time took for a code to complete. 
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
