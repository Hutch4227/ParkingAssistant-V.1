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
        public override string ToString()
        {
            // Plate number, card number, first name lastname, timeIn, timeOut
            return plateNumber + " " + cardNumber + "Card number: " + firstName  + lastName + ", Time In:" + 
            timeIn.ToShortDateString() + ", Time Out: " + timeOut.ToShortDateString();


        }
        public virtual double CalculateCost()
        {
            return 0.0;
        }
        public string PlateNumer
        {
            get
            {
                return plateNumber;              
            }
            set
            {
                if (value.Length > 0)
                    plateNumber = value;

                else
                    plateNumber = "unknown";
            }
        }
        public string CardNumber
        {
            get
            {
                return cardNumber;               
            }
            set
            {
                if (value.Length > 0)
                    cardNumber = value;

                else
                    cardNumber = "unknown";
            }
        }
        public string PlateNumber
        {
            get
            {
                return plateNumber;              
            }
            set
            {
                if (value.Length > 0)
                    plateNumber = value;

                else
                    plateNumber = "unknown";
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;              
            }
            set
            {
                if (value.Length > 0)
                    firstName = value;

                else
                    firstName = "unknown";
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
                if (value.Length > 0)
                    lastName = value;

                else
                    lastName = "unknown";
            }
        }
        public DateTime TimeIn
        {
            get
            {
                return timeIn;
            }

            set
            {
                if (value.Year >= 1950 && value.Year <= DateTime.Now.Year + 5) //I had to make modifications hear to accept a wider range of dates, I also had the operator reversed
                    timeIn = value;
                else
                    timeIn = DateTime.MinValue; //01/01/0001
            }
        }

        public DateTime TimeOut
        {
            get
            {
                return timeOut;
            }

            set
            {
                if (value.Year >= 1950 && value.Year <= DateTime.Now.Year + 5) //I had to make modifications hear to accept a wider range of dates, I also had the operator reversed
                    timeOut = value;
                else
                    timeOut = DateTime.MinValue; //01/01/0001
            }

           
        }
       
    }
   

}
