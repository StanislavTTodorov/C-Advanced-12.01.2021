using System;
using System.Collections.Generic;

namespace _8.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carPassDuringAGreenLight = int.Parse(Console.ReadLine());
            string inputCar = Console.ReadLine();
            int passCar = 0;
            Queue<string> cars = new Queue<string>();
            while (inputCar!="end")
            {
                if (inputCar == "green")
                {
                    if (cars.Count>carPassDuringAGreenLight)
                    {
                        for (int i = 0; i < carPassDuringAGreenLight; i++)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passCar++;
                        }
                    }
                    else if(cars.Count < carPassDuringAGreenLight)
                    {
                        for (int i = cars.Count; i >0 ; i--)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passCar++;
                        }
                    }
                    
                }
                else
                {
                    cars.Enqueue(inputCar);
                }
                inputCar = Console.ReadLine();
            }
            Console.WriteLine($"{passCar} cars passed the crossroads.");
        }
    }
}
