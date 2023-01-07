using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPetrol = int.Parse(Console.ReadLine());
            Queue<int> queuePetrol = new Queue<int>();
            for (int i = 0; i < nPetrol; i++)
            {
                int[] information = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                int petrol = information[0] - information[1];
                queuePetrol.Enqueue(petrol);
            }
            bool isSuccessfull = false;
            for (int i = 0; i < nPetrol; i++)           
            {
                Queue<int> queuePetrolCoppy = new Queue<int>(queuePetrol);
                int sumPetrol = 0;
                for (int j = 0; j < nPetrol; j++)
                {
                    sumPetrol += queuePetrolCoppy.Peek();
                    if (sumPetrol < 0)
                    {                     
                        queuePetrol.Enqueue(queuePetrol.Dequeue());                                           
                        break;
                    }
                    else
                    {
                        queuePetrolCoppy.Dequeue();
                    }
                    if (j==nPetrol-1)
                    {
                        isSuccessfull = true;
                    }
                }
                if (isSuccessfull)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
