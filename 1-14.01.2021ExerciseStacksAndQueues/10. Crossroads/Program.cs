using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            int cound = 0;
            Queue<string> cars = new Queue<string>();
            string inputCar = Console.ReadLine();
            bool isCrash = true;
            while (inputCar!="END")
            {
                if (inputCar == "green")
                {
                    int greenLightNew = greenLight;
                    string lastCar=string.Empty;
                    int characterHit = 0;
                    while (greenLightNew > 0 && cars.Count > 0)
                    {
                        cound++;
                        lastCar = cars.Peek();
                        if (greenLightNew < cars.Peek().Length)
                        {
                            
                            characterHit += greenLightNew;
                        }                        
                            greenLightNew -= cars.Dequeue().Length;                       
                    }
                    if (greenLightNew < 0)
                    {
                        greenLightNew += freeWindow;
                        if (greenLightNew < 0)
                        {                                                                           
                            Console.WriteLine($"A crash happened!");
                            isCrash = false;
                            characterHit += freeWindow;                           
                            Console.WriteLine($"{lastCar} was hit at {lastCar[characterHit]}.");
                            break;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(inputCar);
                }               
                inputCar = Console.ReadLine();
            }
            if (isCrash)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{cound} total cars passed the crossroads.");
            }
            
        }
    }
}
