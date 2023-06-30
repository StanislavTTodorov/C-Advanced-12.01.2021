using System;
using System.Collections.Generic;
using System.Linq;

namespace _8CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();

            int numberOfEnginesLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfEnginesLines; i++)
            {               
                string[] inputData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = inputData[0];
                double power = double.Parse(inputData[1]);
                Engine engine = new Engine(model, power);
                if (inputData.Length==3)
                {
                    int displacement;
                    if (int.TryParse(inputData[2], out displacement))
                    {
                        engine.Displacement = displacement.ToString(); 
                    }
                    else
                    {
                        engine.Efficiency = inputData[2];
                    }
                }
                else if (inputData.Length==4)
                {
                    engine.Displacement = inputData[2];
                    engine.Efficiency = inputData[3];
                }
                engines.Add(engine);
            }
            int numberOfCarsLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCarsLines; i++)
            {
                string[] inputData = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = inputData[0];
                string engine = inputData[1];
                Car car = new Car(model, engine);
                if (inputData.Length == 3)
                {
                    int weight;
                    if (int.TryParse(inputData[2], out weight))
                    {
                        car.Weight = weight.ToString();
                    }
                    else
                    {
                        car.Color = inputData[2];
                    }
                }
                else if (inputData.Length == 4)
                {
                    car.Weight = inputData[2];
                    car.Color = inputData[3];
                }
                cars.Add(car);
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine}:");
                foreach (var engin in engines.Where(n=>n.Model==car.Engine))
                {
                    Console.WriteLine($"    Power: {engin.Power}");
                    Console.WriteLine($"    Displacement: {engin.Displacement}");
                    Console.WriteLine($"    Efficiency: {engin.Efficiency}");
                }
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
