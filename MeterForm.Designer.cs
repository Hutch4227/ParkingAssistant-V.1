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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblcardNum = new System.Windows.Forms.Label();
            this.cardNumTextBox = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
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
            this.btnAdd.Location = new System.Drawing.Point(67, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(184, 336);
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
            this.btnRemove.Location = new System.Drawing.Point(965, 524);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(148, 66);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(719, 524);
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
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(480, 529);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(141, 57);
            this.btnCheckout.TabIndex = 15;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // MeterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1206, 685);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.cardNumTextBox);
            this.Controls.Add(this.lblcardNum);
            this.Controls.Add(this.btnDisplay);
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
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblcardNum;
        private System.Windows.Forms.TextBox cardNumTextBox;
        private System.Windows.Forms.Button btnCheckout;
    }
}