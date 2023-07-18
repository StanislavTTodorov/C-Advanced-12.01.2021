using System;
using System.Collections.Generic;

namespace _5GenericCountMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            double lineOfRead = double.Parse(Console.ReadLine());
            Box<double> boxs = new Box<double>();
            for (int i = 0; i < lineOfRead; i++)
            {
                double input = double.Parse(Console.ReadLine());
                boxs.Add(input);
            }
            Console.WriteLine(boxs.GetCount(double.Parse(Console.ReadLine())));
        }              
    }
}
