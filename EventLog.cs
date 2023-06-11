using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Windows.Forms;

namespace ParkingAssistant_V._1
{
    public static class EventLog
    {
        // Capture events for the parking system.
        // Display dates and times of each parking event.

       // This class creates the directory if its not there, and let you know where th read the information.
        public static void CirCretor()
        {
            string V = @"C:/temp/EventLog/";

            if (Directory.Exists(V) == false)
            {
                Directory.CreateDirectory(V);
                MessageBox.Show("Dir has been created");
            }
            else 
            {
                MessageBox.Show("Your action are being logged to C:\\Temp\\Eventlog\\log.txt");
            }

        }

        public static void Writelog(string message)
        {
            //Setting the path to save to file to
            CirCretor();
            string EventLogPath = ConfigurationManager.AppSettings["EventLogPath"];

            using (StreamWriter sw = new StreamWriter(EventLogPath, true))
            {
                sw.WriteLine($"*************************************************************");
                sw.WriteLine($"{DateTime.Now} : {message}");
            }
        }

       
    }
}

