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
    public partial class frmCarInventory : Form
    {
        CarInventory inventory;
        Car selctedCar;
        public frmCarInventory(CarInventory carInventory)
        {
            InitializeComponent();
            inventory = carInventory;


        }

        private void frmCarInventory_Load(object sender, EventArgs e)
        {
            listViewCars.View = View.Details;
            listViewCars.Columns.Add("Car", 100);
            listViewCars.Columns.Add("Model", 100);
            listViewCars.Columns.Add("Manufacturer", 100);
            listViewCars.Columns.Add("Category", 100);
            listViewCars.Columns.Add("Rental Cost", 100);
            listViewCars.Columns.Add("Availability", 100);


            PopulateListView();
            
            
        }
        private void PopulateListView()
        {
            listViewCars.Items.Clear(); // Clear the existing items in the ListView

            // Make sure we're not resetting the entire car list from the file here
            // We only want to add to the existing list, not overwrite it
            List<Car> loadedCars = inventory.LoadCarInventory();

            // Ensure we don't duplicate cars already in the list
            foreach (var loadedCar in loadedCars)
            {
                if (!inventory.cars.Any(c => c.CarID == loadedCar.CarID))
                {
                    inventory.AddCar(loadedCar); // Add cars from the file if not already present
                }
            }

            // Now add all the cars in the inventory to the ListView
            foreach (Car car in inventory.cars)
            {
                ListViewItem item = new ListViewItem(car.CarID.ToString());
                item.SubItems.Add(car.CarModel);
                item.SubItems.Add(car.CarManufactor);
                item.SubItems.Add(car.CarCategory);
                item.SubItems.Add(car.CarRentalCost.ToString("C"));
                item.SubItems.Add(car.CarAvailability ? "Available" : "Rented");

                listViewCars.Items.Add(item);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedCategory = cmbCarCategory.SelectedItem.ToString();

            listViewCars.Items.Clear();


            foreach (Car car in inventory.cars)
            {
                if (selectedCategory.Equals(car.CarCategory.ToString()) && car.CarAvailability==true)
                {
                    ListViewItem item = new ListViewItem(car.CarID.ToString());
                    item.SubItems.Add(car.CarModel);
                    item.SubItems.Add(car.CarManufactor);
                    item.SubItems.Add(car.CarCategory);
                    item.SubItems.Add(car.CarRentalCost.ToString("C"));
                    item.SubItems.Add(car.CarAvailability ? "Available" : "Rented");

                    listViewCars.Items.Add(item);
                }
            }
        }

        private void listViewCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCars.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCars.SelectedItems[0];
                 selctedCar = inventory.GetCarById(int.Parse(selectedItem.SubItems[0].Text));

                DisplayCarDetails(selctedCar);

            }
        }
        private void DisplayCarDetails(Car car)
        {
            lblCarId.Text = car.CarID.ToString();
            lblYear.Text=car.CarYear.ToString();
            lblManufacturer.Text = car.CarManufactor;
            lblModel.Text = car.CarModel.ToString();
            lblCategory.Text = car.CarCategory.ToString();
            lblRentalCost.Text = car.CarRentalCost.ToString();
            lblAvailability.Text = car.CarAvailability? "Available" : "Rented";
            lblDescription.Text = car.CarDescription.ToString();
            lblLocation.Text = car.CarLocation.ToString();
            pictureBoxCar.Load(car.CarImageURL.ToString());
            panelDetails.Visible = true;
        }

        private void btnRentCar_Click(object sender, EventArgs e)
        {
            frmRentACar frmRentACar = new frmRentACar(inventory,selctedCar);
            frmRentACar.Show();
        }

        private void frmCarInventory_FormClosing(object sender, FormClosingEventArgs e)

        {
            inventory.WriteOnFile(inventory.cars);
        }
    }
}
