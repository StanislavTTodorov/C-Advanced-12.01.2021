using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCar = int.Parse(Console.ReadLine());
            List<Car> carsList = new List<Car>();
            for (int i = 0; i < numberOfCar; i++)
            {
                string[] inputInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = inputInfo[0];
                double fuelAmount = double.Parse(inputInfo[1]);
                double fuelConsumptionFor1km = double.Parse(inputInfo[2]);
                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);
                carsList.Add(car);
            }
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = commands[1];
                double amountOfKm = double.Parse(commands[2]);
                Car car = carsList.FirstOrDefault(n => n.Model == model);

                if (car.Drive(amountOfKm) == false)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                input = Console.ReadLine();
            }
            foreach (var car in carsList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
