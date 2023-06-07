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
            this.textBoxPlateNum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlatenum
            // 
            this.lblPlatenum.AutoSize = true;
            this.lblPlatenum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlatenum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlatenum.Location = new System.Drawing.Point(26, 116);
            this.lblPlatenum.Name = "lblPlatenum";
            this.lblPlatenum.Size = new System.Drawing.Size(152, 16);
            this.lblPlatenum.TabIndex = 0;
            this.lblPlatenum.Text = "Liscense Plate Number: ";
            // 
            // textBoxPlateNum
            // 
            this.textBoxPlateNum.Location = new System.Drawing.Point(184, 113);
            this.textBoxPlateNum.Name = "textBoxPlateNum";
            this.textBoxPlateNum.Size = new System.Drawing.Size(114, 22);
            this.textBoxPlateNum.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(184, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(401, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // MeterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxPlateNum);
            this.Controls.Add(this.lblPlatenum);
            this.Name = "MeterForm";
            this.Text = "Meter Form";
            this.Load += new System.EventHandler(this.MeterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlatenum;
        private System.Windows.Forms.TextBox textBoxPlateNum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}