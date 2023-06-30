using System;
using System.Collections.Generic;
using System.Text;

namespace _8CarSalesman
{
   public class Engine
    {
        public Engine(string model, double power)
        {
            Model = model;
            Power = power;
            Displacement = "n/a";
            Efficiency = "n/a";

        }

        public string Model { get; set; }
        public double Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }
    }
}
