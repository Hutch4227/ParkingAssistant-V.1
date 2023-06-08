using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingAssistant_V._1
{
    [Serializable]
    class ParkingMeter
    {
        // attributes
        private string plateNum;
        private string lastName;
        private DateTime entryDay;
        private DateTime exitDay;

        // constructors 
        public ParkingMeter()
        {
            plateNum = "unknown";
            lastName = "unknown";
            entryDay = DateTime.MinValue;
            exitDay = DateTime.MinValue;
        }

        public ParkingMeter(string plateNum, string lastName, DateTime entryDay, DateTime exitDay)
        {
            this.plateNum = plateNum;
            this.lastName = lastName;
            this.entryDay = entryDay;
            this.exitDay = exitDay;
        }

        public override string ToString()
        {
            return "plateNumber=" + plateNum + ", lastName=" + lastName +
                ", entryDate=" + entryDay.ToShortDateString() + ", exitDate=" + exitDay.ToShortDateString();
        }

        public string platenum
        {
            get
            {
                return plateNum;
            }

            set
            {
                plateNum = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }
    }
}
