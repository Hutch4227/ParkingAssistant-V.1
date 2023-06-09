namespace ParkingAssistant_V._1
{
    partial class MeterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlatenum = new System.Windows.Forms.Label();
            this.PlateNumTextBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.VehiclelistBox = new System.Windows.Forms.ListBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblEntry = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.ExitTextBox = new System.Windows.Forms.TextBox();
            this.EntryTextBox = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblcardNum = new System.Windows.Forms.Label();
            this.cardNumTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPlatenum
            // 
            this.lblPlatenum.AutoSize = true;
            this.lblPlatenum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlatenum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlatenum.Location = new System.Drawing.Point(26, 113);
            this.lblPlatenum.Name = "lblPlatenum";
            this.lblPlatenum.Size = new System.Drawing.Size(152, 16);
            this.lblPlatenum.TabIndex = 0;
            this.lblPlatenum.Text = "Liscense Plate Number: ";
            // 
            // PlateNumTextBox
            // 
            this.PlateNumTextBox.Location = new System.Drawing.Point(184, 113);
            this.PlateNumTextBox.Name = "PlateNumTextBox";
            this.PlateNumTextBox.Size = new System.Drawing.Size(114, 22);
            this.PlateNumTextBox.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(83, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(203, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // VehiclelistBox
            // 
            this.VehiclelistBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.VehiclelistBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VehiclelistBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.VehiclelistBox.FormattingEnabled = true;
            this.VehiclelistBox.HorizontalScrollbar = true;
            this.VehiclelistBox.ItemHeight = 16;
            this.VehiclelistBox.Location = new System.Drawing.Point(467, 48);
            this.VehiclelistBox.Name = "VehiclelistBox";
            this.VehiclelistBox.ScrollAlwaysVisible = true;
            this.VehiclelistBox.Size = new System.Drawing.Size(727, 434);
            this.VehiclelistBox.TabIndex = 4;
            this.VehiclelistBox.SelectedIndexChanged += new System.EventHandler(this.VehiclelistBox_SelectedIndexChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLastName.Location = new System.Drawing.Point(26, 198);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(78, 16);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name: ";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(184, 198);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(187, 22);
            this.LastNameTextBox.TabIndex = 6;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(114, 419);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 60);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Checkout";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEntry.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEntry.Location = new System.Drawing.Point(26, 240);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(75, 16);
            this.lblEntry.TabIndex = 8;
            this.lblEntry.Text = "Entry Date: ";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblExit.Location = new System.Drawing.Point(26, 285);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(66, 16);
            this.lblExit.TabIndex = 9;
            this.lblExit.Text = "Exit Date: ";
            // 
            // ExitTextBox
            // 
            this.ExitTextBox.Location = new System.Drawing.Point(184, 285);
            this.ExitTextBox.Name = "ExitTextBox";
            this.ExitTextBox.Size = new System.Drawing.Size(114, 22);
            this.ExitTextBox.TabIndex = 10;
            // 
            // EntryTextBox
            // 
            this.EntryTextBox.Location = new System.Drawing.Point(184, 240);
            this.EntryTextBox.Name = "EntryTextBox";
            this.EntryTextBox.Size = new System.Drawing.Size(114, 22);
            this.EntryTextBox.TabIndex = 11;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(756, 524);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(159, 66);
            this.btnDisplay.TabIndex = 12;
            this.btnDisplay.Text = "Show Current Vehicles";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblcardNum
            // 
            this.lblcardNum.AutoSize = true;
            this.lblcardNum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcardNum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcardNum.Location = new System.Drawing.Point(26, 155);
            this.lblcardNum.Name = "lblcardNum";
            this.lblcardNum.Size = new System.Drawing.Size(131, 16);
            this.lblcardNum.TabIndex = 13;
            this.lblcardNum.Text = "Credit Card Number: ";
            // 
            // cardNumTextBox
            // 
            this.cardNumTextBox.Location = new System.Drawing.Point(184, 155);
            this.cardNumTextBox.Name = "cardNumTextBox";
            this.cardNumTextBox.Size = new System.Drawing.Size(187, 22);
            this.cardNumTextBox.TabIndex = 14;
            // 
            // MeterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1206, 685);
            this.Controls.Add(this.cardNumTextBox);
            this.Controls.Add(this.lblcardNum);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.EntryTextBox);
            this.Controls.Add(this.ExitTextBox);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblEntry);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.VehiclelistBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.PlateNumTextBox);
            this.Controls.Add(this.lblPlatenum);
            this.Name = "MeterForm";
            this.Text = "Meter Form";
            this.Load += new System.EventHandler(this.MeterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlatenum;
        private System.Windows.Forms.TextBox PlateNumTextBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox VehiclelistBox;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.TextBox ExitTextBox;
        private System.Windows.Forms.TextBox EntryTextBox;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblcardNum;
        private System.Windows.Forms.TextBox cardNumTextBox;
    }
}