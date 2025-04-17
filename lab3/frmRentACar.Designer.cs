namespace lab3
{
    partial class frmRentACar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDriverLicense = new System.Windows.Forms.TextBox();
            this.txtNumberOfDays = new System.Windows.Forms.TextBox();
            this.txtInsuranceInfo = new System.Windows.Forms.TextBox();
            this.txtContactInfo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbRentCar = new System.Windows.Forms.ComboBox();
            this.btnRentReceipt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Insurance information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of days";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Car to rent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Driver license";
            // 
            // txtDriverLicense
            // 
            this.txtDriverLicense.Location = new System.Drawing.Point(129, 155);
            this.txtDriverLicense.Name = "txtDriverLicense";
            this.txtDriverLicense.Size = new System.Drawing.Size(190, 20);
            this.txtDriverLicense.TabIndex = 5;
            // 
            // txtNumberOfDays
            // 
            this.txtNumberOfDays.Location = new System.Drawing.Point(129, 124);
            this.txtNumberOfDays.Name = "txtNumberOfDays";
            this.txtNumberOfDays.Size = new System.Drawing.Size(190, 20);
            this.txtNumberOfDays.TabIndex = 4;
            // 
            // txtInsuranceInfo
            // 
            this.txtInsuranceInfo.Location = new System.Drawing.Point(129, 90);
            this.txtInsuranceInfo.Name = "txtInsuranceInfo";
            this.txtInsuranceInfo.Size = new System.Drawing.Size(190, 20);
            this.txtInsuranceInfo.TabIndex = 3;
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.Location = new System.Drawing.Point(129, 61);
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.Size = new System.Drawing.Size(190, 20);
            this.txtContactInfo.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 20);
            this.txtName.TabIndex = 1;
            // 
            // cmbRentCar
            // 
            this.cmbRentCar.FormattingEnabled = true;
            this.cmbRentCar.Location = new System.Drawing.Point(129, 182);
            this.cmbRentCar.Name = "cmbRentCar";
            this.cmbRentCar.Size = new System.Drawing.Size(151, 21);
            this.cmbRentCar.TabIndex = 6;
            // 
            // btnRentReceipt
            // 
            this.btnRentReceipt.Location = new System.Drawing.Point(139, 233);
            this.btnRentReceipt.Name = "btnRentReceipt";
            this.btnRentReceipt.Size = new System.Drawing.Size(117, 25);
            this.btnRentReceipt.TabIndex = 7;
            this.btnRentReceipt.Text = "Rental receipt";
            this.btnRentReceipt.UseVisualStyleBackColor = true;
            this.btnRentReceipt.Click += new System.EventHandler(this.btnRentReceipt_Click);
            // 
            // frmRentACar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRentReceipt);
            this.Controls.Add(this.cmbRentCar);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtContactInfo);
            this.Controls.Add(this.txtInsuranceInfo);
            this.Controls.Add(this.txtNumberOfDays);
            this.Controls.Add(this.txtDriverLicense);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRentACar";
            this.Text = "Rent a car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDriverLicense;
        private System.Windows.Forms.TextBox txtNumberOfDays;
        private System.Windows.Forms.TextBox txtInsuranceInfo;
        private System.Windows.Forms.TextBox txtContactInfo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbRentCar;
        private System.Windows.Forms.Button btnRentReceipt;
    }
}