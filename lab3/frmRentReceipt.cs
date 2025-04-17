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
    public partial class frmRentReceipt : Form
    {
        int carId;
        Car car;
        int numberOfDays;
        public frmRentReceipt(int CarId, Car car, int numberOfDays)
        {
            InitializeComponent();
            carId = CarId;
            this.car = car;
            this.numberOfDays = numberOfDays;
        }

        private void frmRentReceipt_Load(object sender, EventArgs e)
        {
            RentalTransaction transaction = new RentalTransaction();
            transaction.CarRented=car;
            transaction.RentalLenght=numberOfDays;
            lblDateAndTime.Text = transaction.RentalDate.ToString();
            lblCarRentedID.Text = carId.ToString();
            lblSubtotal.Text =transaction.SubTotalCost.ToString();
            lblTotalCost.Text=transaction.CalculateTotalCost().ToString();
            lblTax.Text = transaction.Tax.ToString();


        }
    }
}
