using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class frmRentalApp : Form
    {
        CarInventory inventory;
        public frmRentalApp()
        {
            InitializeComponent();
            inventory = new CarInventory();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            frmAddCar frmAddCar = new frmAddCar(inventory);
            frmAddCar.Show();

        }

        private void btnViewInventory_Click(object sender, EventArgs e)
        {
            frmCarInventory frmCarInventory = new frmCarInventory(inventory);
            frmCarInventory.Show();
        }

       

        private void btnReturnACar_Click(object sender, EventArgs e)
        {
            frmReturnCar frmReturnCar = new frmReturnCar(inventory);
            frmReturnCar.Show();
        }

        private void frmRentalApp_Load(object sender, EventArgs e)
        {
            
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
               
        }
    }
}
