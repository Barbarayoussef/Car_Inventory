using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class CarInventory
    {
        public List<Car> cars { get; set; }
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Car_Inventory.txt");

        public CarInventory()
        {
            cars = new List<Car>();
        }
        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        public List<Car> FindCarsByCategory(string category)
        {
            List<Car> matchingCars = new List<Car>();

            foreach (Car car in cars)
            {
                if (car.CarCategory == category && car.CarAvailability)
                {
                    matchingCars.Add(car);
                }
            }

            return matchingCars;
        }
        public Car GetCarById(int carId)
        {
            Car selectedCar = null;
            foreach (var car in cars)
            {
                if (car.CarID == carId)
                {
                    selectedCar = car;
                    break;
                }
            }
            return selectedCar;
        }

        public void WriteOnFile(List<Car> cars)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var car in cars)
                {
                    writer.WriteLine(car.CarToCsv(car));

                }

            }



        }
        public List<Car> LoadCarInventory()
{
    List<Car> carCollection = new List<Car>();

    if (File.Exists(filePath))
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Car car = Car.CsvToCar(line);
                carCollection.Add(car);
            }
        }
    }

    return carCollection;
}

    }
}
