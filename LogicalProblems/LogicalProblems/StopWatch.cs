using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class StopWatch
    {
        DateTime dateTime = DateTime.Now;
        //TimeSpan timeSpan = TimeSpan.Zero;
        public void Start()
        {
            int startHr = dateTime.Hour;
            int startMin = dateTime.Minute;
            int startSec = dateTime.Second;
            int startMilliSec = dateTime.Millisecond;
            Console.WriteLine("Wait and press s to start");
            string data = Console.ReadLine().ToLower();
            if(data.Equals("s"))
            {
                Console.WriteLine(startMilliSec);
                Console.WriteLine("press x for exit");
                string stop = Console.ReadLine().ToLower();
                if (stop.Equals("x"))
                {
                    int stopHr = dateTime.Hour;
                    int stopMin = dateTime.Minute;
                    int stopSec = dateTime.Second;
                    int stopMilliSec = dateTime.Millisecond;
                    Console.WriteLine("Stopwatch details:-Hours: " + (stopHr - startHr) + "Minutes:"
                        + (stopMin - startMin) + "Seconds:" + (stopSec - startSec) + "MilliSeconds"
                        + (stopMilliSec - startMilliSec));
                }
            }
        }
    }
}
