using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class frmAddCar : Form
    {
        private CarInventory carInventory;
        
        public frmAddCar(CarInventory inventory)
        {
            InitializeComponent();
            carInventory = inventory;
        }

        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.CarCategory=cmbCarCategory.SelectedItem.ToString();
            car.CarModel= txtCarModel.Text;
            car.CarManufactor=txtCarManufacturer.Text;
            car.CarDescription=txtCarDescription.Text;
            car.CarRentalCost = Decimal.Parse(txtRenalCost.Text);
            car.CarYear= int.Parse(txtCarYear.Text);
            car.CarMileage=txtCarMileage.Text;
            car.CarLocation= txtCarLocation.Text;

            try
            {
                car.CarImageURL = txtCarImageURL.Text;
                pictureBoxCar.Load(txtCarImageURL.Text.ToString());
            }
            catch(Exception)
            {
                MessageBox.Show("The URL is not valid. Please enter a valid URL.");
            }
            carInventory.AddCar(car);
           



        }

        private void btnSaveInentory_Click(object sender, EventArgs e)
        {
            frmCarInventory inventory = new frmCarInventory(carInventory);
            inventory.Show();
        }

      
    }
}
