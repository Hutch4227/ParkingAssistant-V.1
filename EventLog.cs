using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace ParkingAssistant_V._1
{
    public static class EventLog
    {
        // Capture events for the parking system.
        // Display dates and times of each parking event.

        public static void Writelog(string message)
        {
            //Setting the path to save to file to
            string EventlogPath = ConfigurationManager.AppSettings["EventLogPath"];

            using (StreamWriter sw = new StreamWriter(EventlogPath, true))
            {
                sw.WriteLine($"*************************************************************");
                sw.WriteLine($"{DateTime.Now} : {message}");
            }
        }

        //internal static void Writelog(string v)
        //{
        //    throw new NotImplementedException();
       // }
    }
}

