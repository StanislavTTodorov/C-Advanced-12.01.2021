using System;
using System.Collections.Generic;
using System.Text;

namespace _8CarSalesman
{
    public class Car
    {

        public Car(string model, string engine)

        {
            Model = model;
            Engine = engine;
            Weight = "n/a";
            Color = "n/a";
        }        

        public string Model { get; set; }
        public string Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }
    }
}
