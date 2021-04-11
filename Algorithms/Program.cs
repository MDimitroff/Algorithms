using System;
using System.Diagnostics;
using System.Threading;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //var timer = new Utils.Timer();
            var sw = new Stopwatch();
            sw.Start();
            //timer.Start();
            
            Console.WriteLine("Hello World!");
            Thread.Sleep(1000);
            
            //timer.Stop();
            sw.Stop();
            //var duration = timer.GetDuration();
            
            //Console.WriteLine($"[Timer] Hello world took {duration} to execute");
            Console.WriteLine($"[StopWatch] Hello world took {sw.Elapsed} to execute");
            Console.ReadLine();
        }
    }
}
