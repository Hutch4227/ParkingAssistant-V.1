using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingAssistant_V._1
{
    [Serializable]
    internal class Customer
    {
        //Attributes

        protected string plateNumber;
        protected string cardNumber;
        protected string firstName;
        protected string lastName;
        protected DateTime timeIn;
        protected DateTime timeOut;

        public Customer()
        {
            plateNumber = "unknown";
            cardNumber = "unknown";
            firstName = "unknown";
            lastName = "unknown";
            timeIn = DateTime.MinValue;
            timeOut = DateTime.MinValue;

        }
        //constructors
        public Customer (string plateNumber, string cardNumber, string firstName, string lastName, DateTime timeIn, DateTime timeOut)
        {
            this.plateNumber = plateNumber;
            this.cardNumber = cardNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.timeIn = timeIn;
            this.timeOut = timeOut;
        }
    }


}
