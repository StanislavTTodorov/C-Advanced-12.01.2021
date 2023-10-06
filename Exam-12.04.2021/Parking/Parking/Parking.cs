using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> cars;
        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            cars = new List<Car>();
        }

        public string Type { get; set; }

        public int Capacity { get; set; }
        public int Count => cars.Count;

        public void Add(Car car)
        {
            if (cars.Count<Capacity)
            {
                cars.Add(car);
            }
          
        }

        public bool Remove(string manufacturer, string model)
        {
            Car car1 = cars.Where(car => car.Manufacturer == manufacturer && car.Model == model).FirstOrDefault();
            if (car1!=null)
            {
                cars.Remove(car1);
                return true;
            }
            return false;
        }

        public Car GetLatestCar()
        {
            if (cars.Count > 0)
            {
                int lates = cars.Count - 1;
                return cars[lates];
            }
            return null;
        }

        public Car GetCar(string manufacturer, string model)
        {
            Car getCar = null;
            foreach (var car in cars)
            {
                if (car.Manufacturer == manufacturer && car.Model == model)
                {
                    getCar = car;
                }
            }
            return getCar;
        }

        public string GetStatistics()
        {
            string text = $"The cars are parked in {Type}:" + Environment.NewLine;
            foreach (var car in cars)
            {
                text += car.ToString()+Environment.NewLine;
            }
            return text;
        }
    }
}
