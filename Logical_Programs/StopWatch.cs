using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class StopWatch
    {
        public static double starttime, stoptime,elapsedtime;
        public static void start()
        {
            DateTime start = DateTime.Now;
            starttime = start.Second;
            Console.WriteLine("Start time(in seconds):" + starttime );
        }
        public static void stop()
        {
            DateTime stop = DateTime.Now;
            stoptime = stop.Second;
            Console.WriteLine("Stop time(in seconds):" + stoptime);
        }
        public static void timespan()
        {
            elapsedtime = stoptime - starttime;
            Console.WriteLine("Elapsed time(in seconds):" + elapsedtime);

        }
    }
}
