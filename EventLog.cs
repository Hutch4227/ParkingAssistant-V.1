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

       
        public static void CirCretor()
        {
            string V = ConfigurationManager.AppSettings["EventLogPath"];

            if (Directory.Exists(V) == false)
            {
                Directory.CreateDirectory(V);
                MessageBox.Show("Dir has been created");
            }
            else
            {
                MessageBox.Show("The Path is already there.......");
            }

        }

        public static void Writelog(string message)
        {
            //Setting the path to save to file to

            string logPath = ConfigurationManager.AppSettings["EventLogPath"];

            using (StreamWriter sw = new StreamWriter(logPath, true))
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

