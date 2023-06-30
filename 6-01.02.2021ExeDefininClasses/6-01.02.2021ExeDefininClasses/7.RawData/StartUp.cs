using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> carsList = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] inputCar = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = inputCar[0];
                double engineSpeed = double.Parse(inputCar[1]);
                double enginePower = double.Parse(inputCar[2]);
                double cargoWeight = double.Parse(inputCar[3]);
                string cargoType = inputCar[4];
                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType,inputCar);
                carsList.Add(car);
            }
            string inputCommand = Console.ReadLine();
            List<Car> filterCar = new List<Car>();
           
            if (inputCommand == "fragile")
            {
                filterCar = carsList.Where(n => n.Cargo.Type == inputCommand)
                    .Where(n => n.Tires.Any(v => v.Pressure<1))
                    .ToList();
            }
            else if (inputCommand == "flamable")
            {
                filterCar = carsList.Where(n => n.Cargo.Type == inputCommand)
                    .Where(n => n.Engine.Power > 250)
                    .ToList();
            }
            if (filterCar.Count > 0)
            {
                foreach (var car in filterCar)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
