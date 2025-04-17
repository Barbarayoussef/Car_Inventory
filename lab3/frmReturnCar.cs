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
    public partial class frmReturnCar : Form
    {
        CarInventory carInventory;
        public frmReturnCar(CarInventory carInventory)
        {
            InitializeComponent();
            this.carInventory = carInventory;
            carInventory.cars = carInventory.LoadCarInventory();
        }

        private void frmReturnCar_Load(object sender, EventArgs e)
        {
            PopulateRentedCarsComboBox();
        }

        private void btnReturnSuccess_Click(object sender, EventArgs e)
        {
            if (cmbReturnedCar.SelectedItem != null)
            {
                int selectedCarId = (int)cmbReturnedCar.SelectedItem;
                Car selectedCar = carInventory.GetCarById(selectedCarId);

                if (selectedCar != null)
                {
                    // Update availability and display a message
                    selectedCar.MarkAsAvailable();
                    MessageBox.Show($"Car {selectedCar.CarID} has been returned!");

                    // Refresh the ComboBox
                    PopulateRentedCarsComboBox();

                    // Optionally, you can reset the labels to blank
                    ClearCarDetails();

                }
            }
            else
            {
                MessageBox.Show("Please select a car to return.");
            }
        }
        private void PopulateRentedCarsComboBox()
        {
            cmbReturnedCar.Items.Clear(); // Clear in case of reloading
            foreach (Car car in carInventory.cars)
            {
                if (!car.CarAvailability) // Only show rented cars
                {
                    cmbReturnedCar.Items.Add(car.CarID);
                }
            }
        }

        private void ClearCarDetails() { 
            cmbReturnedCar.Items.Clear();
            txtDamages.Text= string.Empty;
            txtUpdatedMileage.Text= string.Empty;
        }


    }
    }

