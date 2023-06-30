using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string[] inputCar)
        {
            Tires = new Tire[4];
            int count = 0;
            for (int i = 5; i < inputCar.Length; i = i+2)
            {
                double pressure = double.Parse(inputCar[i]);
                double age = double.Parse(inputCar[i + 1]);
                Tire = new Tire(pressure,age);
                Tires[count++] = Tire;
            }
        }

        public Car(string model, double engineSpeed, double enginePower, double cargoWeight, string cargoType, string[] inputCar)
            :this(inputCar)
        {
            Model = model;
            Engine = new Engine(engineSpeed, enginePower);
            Cargo = new Cargo(cargoWeight, cargoType);
        }
      

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Tire Tire { get; set; }

        public Tire[] Tires { get; set; }


    }
}
