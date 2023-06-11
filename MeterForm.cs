using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingAssistant_V._1
{
    public partial class MeterForm : Form
    {
        // class level references
        const string FILENAME = "Vehicles.csv";
        DateTime entryDay = DateTime.Today;
        public MeterForm()
        {
            InitializeComponent();
            EventLog.Writelog("Meter Form Started");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void MeterForm_Load(object sender, EventArgs e)
        {

        }

        private void VehiclelistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int itemNumber = VehiclelistBox.SelectedIndex;

            if (itemNumber > -1)
            {
                VehiclelistBox.Items.RemoveAt(itemNumber);
                WriteVehicsToFile();
            }
            else
            {
                MessageBox.Show("Please select vehicle to Remove.");
            }
                        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string plateNum = PlateNumTextBox.Text;
            string lastName = LastNameTextBox.Text;
            DateTime entryDay = DateTime.Today;
            string cardNum = cardNumTextBox.Text;

            ParkingMeter vehic = null;
            vehic = new ParkingMeter(plateNum, lastName, entryDay, cardNum); 

            VehiclelistBox.Items.Add(vehic);

            WriteVehicsToFile();
        }

        private void WriteVehicsToFile()
        {
            List<ParkingMeter> vehicList = new List<ParkingMeter>();

            foreach (ParkingMeter vehic in VehiclelistBox.Items)
            {
                vehicList.Add(vehic);
            }

            //open a pipe to the file and create a translator
            FileStream fs = new FileStream(FILENAME, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                //write the entire object to the file in one line
                formatter.Serialize(fs, vehicList);
            }

            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                    throw;
            }
            finally
            { 
                fs.Close();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            ReadVehicsFromFile();
        }

        private void ReadVehicsFromFile()
        {
            // clear the listbox
            VehiclelistBox.Items.Clear();

            //check to see if the file exists
            if (File.Exists(FILENAME) && new FileInfo(FILENAME).Length > 0)
            {
                FileStream fs = new FileStream(FILENAME, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();

                List<ParkingMeter> list = (List<ParkingMeter>)formatter.Deserialize(fs);

                fs.Close();

                //copy each vehicle object to the list box
                foreach (ParkingMeter vehic in list)
                {
                    VehiclelistBox.Items.Add(vehic);
                }
            }
        }
       
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            

            TimeSpan dateOut = DateTime.Today - entryDay ;


            //MessageBox.Show(dateOut.ToString("dd"));

            if (dateOut.TotalDays == 0)
            {
                MessageBox.Show("Your total is 30$");
            }
            else if (dateOut.TotalDays == 1) {
                MessageBox.Show("Your total is 45");

            }
            else if (dateOut.TotalDays > 2)
            {
                double price = 0;
                
                price = dateOut.TotalDays * 15;

                MessageBox.Show("Your total is: " + price);
            }
                
            
            

        }
    }
}
