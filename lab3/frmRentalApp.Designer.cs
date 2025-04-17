namespace lab3
{
    partial class frmRentalApp
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
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnViewInventory = new System.Windows.Forms.Button();
            this.btnReturnACar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(46, 113);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(102, 23);
            this.btnAddCar.TabIndex = 0;
            this.btnAddCar.Text = "Add New Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnViewInventory
            // 
            this.btnViewInventory.Location = new System.Drawing.Point(185, 113);
            this.btnViewInventory.Name = "btnViewInventory";
            this.btnViewInventory.Size = new System.Drawing.Size(116, 23);
            this.btnViewInventory.TabIndex = 1;
            this.btnViewInventory.Text = "View Inventory";
            this.btnViewInventory.UseVisualStyleBackColor = true;
            this.btnViewInventory.Click += new System.EventHandler(this.btnViewInventory_Click);
            // 
            // btnReturnACar
            // 
            this.btnReturnACar.Location = new System.Drawing.Point(335, 113);
            this.btnReturnACar.Name = "btnReturnACar";
            this.btnReturnACar.Size = new System.Drawing.Size(84, 23);
            this.btnReturnACar.TabIndex = 3;
            this.btnReturnACar.Text = "Return a Car";
            this.btnReturnACar.UseVisualStyleBackColor = true;
            this.btnReturnACar.Click += new System.EventHandler(this.btnReturnACar_Click);
            // 
            // frmRentalApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 231);
            this.Controls.Add(this.btnReturnACar);
            this.Controls.Add(this.btnViewInventory);
            this.Controls.Add(this.btnAddCar);
            this.Name = "frmRentalApp";
            this.Text = "Rental Car Application";
            this.Load += new System.EventHandler(this.frmRentalApp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnViewInventory;
        private System.Windows.Forms.Button btnReturnACar;
    }
}

