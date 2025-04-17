using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace lab3
{
    public class Car
    {

        private string carCategory;
        private string carManufactor;
        private string carModel;
        private int carYear;
        private string carMileage;
        private decimal carRentalCost;
        private bool carAvailability = true;
        private string carDescription;
        private string carLocation;
        private string carImageURL;
        public int CarID { get; private set; }
        private static int nextId = 1;

        public Car()
        {
            CarID = nextId++;
        }
        public string CarCategory { get { return carCategory; } set { carCategory = value; } }
        public string CarManufactor { get { return carManufactor; } set { carManufactor = value; } }
        public string CarModel { get { return carModel; } set { carModel = value; } }
        public int CarYear { get { return carYear; } set { carYear = value; } }
        public string CarMileage { get { return carMileage; } set { carMileage = value; } }
        public decimal CarRentalCost { get { return carRentalCost; } set { carRentalCost = value; } }
        public bool CarAvailability { get { return carAvailability; } set { carAvailability = value; } }
        public string CarDescription { get { return carDescription; } set { carDescription = value; } }
        public string CarLocation { get { return carLocation; } set { carLocation = value; } }
        public string CarImageURL { get { return carImageURL; } set { carImageURL = value; } }

        public void MarkAsRented()
        {
            carAvailability = false;
        }

        public void MarkAsAvailable()
        {
            carAvailability = true;
        }
    
    public string CarToCsv(Car car)
    {

        return $"{car.CarID},{car.carManufactor},{car.carModel},{car.carYear.ToString()},{car.carMileage},{car.carRentalCost.ToString()},{car.carAvailability},{car.carCategory},{car.carDescription},{car.carLocation},{car.carImageURL}";
    }
        public static Car CsvToCar(string csvLine)
        {
            string[] values = csvLine.Split(',');

            Car car = new Car();

            car.CarID = int.Parse(values[0]);
            car.carManufactor = values[1];
            car.carModel = values[2];
            car.carYear = int.Parse(values[3]);
            car.carMileage = values[4];
            car.carRentalCost = decimal.Parse(values[5]);
            car.carAvailability = bool.Parse(values[6]);
            car.carCategory = values[7];
            car.carDescription = values[8];
            car.carLocation = values[9];
            car.carImageURL = values[10];
            

            return car;
        }

    }

}



