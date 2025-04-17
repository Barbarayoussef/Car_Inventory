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
    public partial class frmRentACar : Form
    {
        private CarInventory carInventory;
        private CustomerInfo customerInfo= new CustomerInfo();
        private RentalTransaction transaction = new RentalTransaction();
        private Car selectedCar;
        private int NumberOfDays;
        Car CarSelsctedInInventory;

        public frmRentACar(CarInventory carInventory,Car car)
        {
            InitializeComponent();
            this.carInventory = carInventory;
            CarSelsctedInInventory = car;
            LoadAvailableCars();
        }

        private void LoadAvailableCars()
        {
            
            if (carInventory != null)
            {
                foreach (var car in carInventory.cars)
                {
                    if (car.CarAvailability == true)
                    {
                        cmbRentCar.Items.Add(car.CarID);
                    }
                }
            }
            cmbRentCar.SelectedItem = CarSelsctedInInventory.CarID;
            
        }
        private void btnRentReceipt_Click(object sender, EventArgs e)
        {
            if(cmbRentCar.SelectedItem!= null)
            {
                int selectedCarId = int.Parse(cmbRentCar.SelectedItem.ToString());
                foreach (var car in carInventory.cars)
                {
                    if (selectedCarId == car.CarID){
                        selectedCar = car;
                    }
                }
                if (selectedCar != null)
                {
                    customerInfo.Name = txtName.Text;
                    customerInfo.InsuranceInfo = txtInsuranceInfo.Text;
                    customerInfo.LicenseInfo = txtDriverLicense.Text;
                    customerInfo.ContactInfo = txtContactInfo.Text;
                    NumberOfDays = int.Parse(txtNumberOfDays.Text);
                }
                selectedCar.MarkAsRented();
                frmRentReceipt frmRentReceipt = new frmRentReceipt(selectedCarId, selectedCar,NumberOfDays);
                frmRentReceipt.Show();
            }
            
           
            



        }

       
    }
}
