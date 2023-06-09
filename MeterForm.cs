using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingAssistant_V._1
{
    public partial class MeterForm : Form
    {
        // class level references
        private const string FILENAME = "Vehicles.csv";
        public MeterForm()
        {
            InitializeComponent();
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
            //DateTime exitDay = DateTime.Today;
            int itemNumber = VehiclelistBox.SelectedIndex;

            if (itemNumber > -1)
            {
                VehiclelistBox.Items.RemoveAt(itemNumber);
                WriteVehicsToFile();
            }
            else
            {
                MessageBox.Show("Please select vehicle to Checkout.");
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

            //write the entire object to the file in one line
            formatter.Serialize(fs, vehicList);

            //close the pipe
            fs.Close();
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
            if (File.Exists(FILENAME) && new FileInfo(FILENAME).Length < 0)
            {
                FileStream fs = new FileStream(FILENAME, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();

                List<ParkingMeter> list = (List<ParkingMeter>)formatter.Deserialize(fs);

                fs.Close();

                //copy weach vehicle object to the list box
                foreach (ParkingMeter vehic in list)
                {
                    VehiclelistBox.Items.Add(vehic);
                }
            }
        }
    }

}
