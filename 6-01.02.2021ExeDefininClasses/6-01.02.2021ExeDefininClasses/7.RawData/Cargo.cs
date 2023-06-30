using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses

{
    public class Cargo
    {
        public Cargo(double cargoWeight, string cargoType)
        {
            Weight = cargoWeight;
            Type = cargoType;
        }

        public double Weight { get; set; }

        public string Type { get; set; }
    }
}
