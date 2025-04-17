namespace lab3
{
    partial class frmReturnCar
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
            this.cmbReturnedCar = new System.Windows.Forms.ComboBox();
            this.txtDamages = new System.Windows.Forms.TextBox();
            this.txtUpdatedMileage = new System.Windows.Forms.TextBox();
            this.btnReturnSuccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Report damage (optional)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Updated mileage";
            // 
            // cmbReturnedCar
            // 
            this.cmbReturnedCar.FormattingEnabled = true;
            this.cmbReturnedCar.Location = new System.Drawing.Point(95, 23);
            this.cmbReturnedCar.Name = "cmbReturnedCar";
            this.cmbReturnedCar.Size = new System.Drawing.Size(121, 21);
            this.cmbReturnedCar.TabIndex = 1;
            // 
            // txtDamages
            // 
            this.txtDamages.Location = new System.Drawing.Point(144, 50);
            this.txtDamages.Name = "txtDamages";
            this.txtDamages.Size = new System.Drawing.Size(379, 20);
            this.txtDamages.TabIndex = 2;
            // 
            // txtUpdatedMileage
            // 
            this.txtUpdatedMileage.Location = new System.Drawing.Point(127, 87);
            this.txtUpdatedMileage.Name = "txtUpdatedMileage";
            this.txtUpdatedMileage.Size = new System.Drawing.Size(163, 20);
            this.txtUpdatedMileage.TabIndex = 3;
            // 
            // btnReturnSuccess
            // 
            this.btnReturnSuccess.Location = new System.Drawing.Point(144, 163);
            this.btnReturnSuccess.Name = "btnReturnSuccess";
            this.btnReturnSuccess.Size = new System.Drawing.Size(100, 23);
            this.btnReturnSuccess.TabIndex = 4;
            this.btnReturnSuccess.Text = "Return the car";
            this.btnReturnSuccess.UseVisualStyleBackColor = true;
            this.btnReturnSuccess.Click += new System.EventHandler(this.btnReturnSuccess_Click);
            // 
            // frmReturnCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturnSuccess);
            this.Controls.Add(this.txtUpdatedMileage);
            this.Controls.Add(this.txtDamages);
            this.Controls.Add(this.cmbReturnedCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReturnCar";
            this.Text = "Return the car";
            this.Load += new System.EventHandler(this.frmReturnCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbReturnedCar;
        private System.Windows.Forms.TextBox txtDamages;
        private System.Windows.Forms.TextBox txtUpdatedMileage;
        private System.Windows.Forms.Button btnReturnSuccess;
    }
}