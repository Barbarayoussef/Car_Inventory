using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class RentalTransaction
    {
        private Car carRented;
        private CustomerInfo customer;
        private DateTime rentalDate = DateTime.Now;
        private int rentalLenght;
        private decimal subTotalCost;
        private decimal tax = 0.70m;
        public Car CarRented { get { return carRented; } set { carRented = value; } }
        public CustomerInfo Customer { get { return customer; } set { customer = value; } }
        public int RentalLenght { get { return rentalLenght; } set { rentalLenght = value; } }

        public decimal SubTotalCost { get { return subTotalCost = rentalLenght * carRented.CarRentalCost; } }
        public decimal Tax { get { return tax; } }
        public DateTime RentalDate { get { return rentalDate; } }
      
        public decimal CalculateTotalCost() {
            decimal total = subTotalCost * tax;
            total += subTotalCost; 
            return total;
        }
       
    }
}
