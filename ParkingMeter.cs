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
        private string cardNum;

        // constructors 
        public ParkingMeter()
        {
            plateNum = "unknown";
            lastName = "unknown";
            entryDay = DateTime.Today;          
            cardNum = "unknown";
        }

        public ParkingMeter(string plateNum, string lastName, DateTime entryDay, string cardNum)
        {
            this.plateNum = plateNum;
            this.lastName = lastName;
            this.entryDay = entryDay;
            this.cardNum = cardNum;
        }

        public override string ToString()
        {
            return "plateNumber=" + plateNum + ", lastName=" + lastName + ", cardNumber=" + cardNum +
                ", entryDate=" + entryDay.ToShortDateString();
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
