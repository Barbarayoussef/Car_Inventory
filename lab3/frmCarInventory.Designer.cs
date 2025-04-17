namespace lab3
{
    partial class frmCarInventory
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
            this.listViewCars = new System.Windows.Forms.ListView();
            this.cmbCarCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchByCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCarId = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblRentalCost = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.btnRentCar = new System.Windows.Forms.Button();
            this.panelDetails = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.panelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewCars
            // 
            this.listViewCars.FullRowSelect = true;
            this.listViewCars.HideSelection = false;
            this.listViewCars.Location = new System.Drawing.Point(12, 82);
            this.listViewCars.Name = "listViewCars";
            this.listViewCars.Size = new System.Drawing.Size(634, 239);
            this.listViewCars.TabIndex = 0;
            this.listViewCars.UseCompatibleStateImageBehavior = false;
            this.listViewCars.View = System.Windows.Forms.View.Details;
            this.listViewCars.SelectedIndexChanged += new System.EventHandler(this.listViewCars_SelectedIndexChanged);
            // 
            // cmbCarCategory
            // 
            this.cmbCarCategory.FormattingEnabled = true;
            this.cmbCarCategory.Items.AddRange(new object[] {
            "Economy",
            "Luxury",
            "Luxury",
            "Sport",
            "SUV",
            "Van",
            "Pickup",
            "Convertible",
            "Compact",
            "Mid-size",
            "Full-size"});
            this.cmbCarCategory.Location = new System.Drawing.Point(142, 21);
            this.cmbCarCategory.Name = "cmbCarCategory";
            this.cmbCarCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCarCategory.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by category";
            // 
            // btnSearchByCategory
            // 
            this.btnSearchByCategory.Location = new System.Drawing.Point(330, 24);
            this.btnSearchByCategory.Name = "btnSearchByCategory";
            this.btnSearchByCategory.Size = new System.Drawing.Size(119, 21);
            this.btnSearchByCategory.TabIndex = 4;
            this.btnSearchByCategory.Text = "Search by category";
            this.btnSearchByCategory.UseVisualStyleBackColor = true;
            this.btnSearchByCategory.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Car ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Manufacturer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Rental cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Availability";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Location";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Image";
            // 
            // lblCarId
            // 
            this.lblCarId.AutoSize = true;
            this.lblCarId.Location = new System.Drawing.Point(138, 17);
            this.lblCarId.Name = "lblCarId";
            this.lblCarId.Size = new System.Drawing.Size(33, 13);
            this.lblCarId.TabIndex = 15;
            this.lblCarId.Text = "lblCar";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(138, 36);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 13);
            this.lblYear.TabIndex = 16;
            this.lblYear.Text = "lblYear";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(136, 58);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(80, 13);
            this.lblManufacturer.TabIndex = 17;
            this.lblManufacturer.Text = "lblManufacturer";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(138, 81);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 13);
            this.lblModel.TabIndex = 18;
            this.lblModel.Text = "lblModel";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(138, 111);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(59, 13);
            this.lblCategory.TabIndex = 19;
            this.lblCategory.Text = "lblCategory";
            // 
            // lblRentalCost
            // 
            this.lblRentalCost.AutoSize = true;
            this.lblRentalCost.Location = new System.Drawing.Point(138, 140);
            this.lblRentalCost.Name = "lblRentalCost";
            this.lblRentalCost.Size = new System.Drawing.Size(69, 13);
            this.lblRentalCost.TabIndex = 20;
            this.lblRentalCost.Text = "lblRenatlCost";
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Location = new System.Drawing.Point(141, 169);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(66, 13);
            this.lblAvailability.TabIndex = 21;
            this.lblAvailability.Text = "lblAvailability";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(136, 201);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 13);
            this.lblDescription.TabIndex = 22;
            this.lblDescription.Text = "lblDescription";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(139, 228);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(58, 13);
            this.lblLocation.TabIndex = 23;
            this.lblLocation.Text = "lblLocation";
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Location = new System.Drawing.Point(87, 255);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(292, 146);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar.TabIndex = 24;
            this.pictureBoxCar.TabStop = false;
            // 
            // btnRentCar
            // 
            this.btnRentCar.Location = new System.Drawing.Point(205, 364);
            this.btnRentCar.Name = "btnRentCar";
            this.btnRentCar.Size = new System.Drawing.Size(75, 23);
            this.btnRentCar.TabIndex = 25;
            this.btnRentCar.Text = "Rent Car";
            this.btnRentCar.UseVisualStyleBackColor = true;
            this.btnRentCar.Click += new System.EventHandler(this.btnRentCar_Click);
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.label2);
            this.panelDetails.Controls.Add(this.lblCarId);
            this.panelDetails.Controls.Add(this.label11);
            this.panelDetails.Controls.Add(this.pictureBoxCar);
            this.panelDetails.Controls.Add(this.label3);
            this.panelDetails.Controls.Add(this.lblLocation);
            this.panelDetails.Controls.Add(this.lblYear);
            this.panelDetails.Controls.Add(this.lblDescription);
            this.panelDetails.Controls.Add(this.label10);
            this.panelDetails.Controls.Add(this.label4);
            this.panelDetails.Controls.Add(this.lblAvailability);
            this.panelDetails.Controls.Add(this.lblManufacturer);
            this.panelDetails.Controls.Add(this.label9);
            this.panelDetails.Controls.Add(this.lblRentalCost);
            this.panelDetails.Controls.Add(this.label5);
            this.panelDetails.Controls.Add(this.lblCategory);
            this.panelDetails.Controls.Add(this.label8);
            this.panelDetails.Controls.Add(this.lblModel);
            this.panelDetails.Controls.Add(this.label6);
            this.panelDetails.Controls.Add(this.label7);
            this.panelDetails.Location = new System.Drawing.Point(669, 24);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(448, 404);
            this.panelDetails.TabIndex = 26;
            this.panelDetails.Visible = false;
            // 
            // frmCarInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 450);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.btnRentCar);
            this.Controls.Add(this.btnSearchByCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCarCategory);
            this.Controls.Add(this.listViewCars);
            this.Name = "frmCarInventory";
            this.Text = "Car Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCarInventory_FormClosing);
            this.Load += new System.EventHandler(this.frmCarInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCars;
        private System.Windows.Forms.ComboBox cmbCarCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchByCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCarId;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblRentalCost;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Button btnRentCar;
        private System.Windows.Forms.Panel panelDetails;
    }
}