using System;
using System.Collections.Generic;

namespace _5.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputClothes = Console.ReadLine();
            int rackCapacity = int.Parse(Console.ReadLine());
            int coppyRackCapacity = rackCapacity;
            int printRacks = 1;
            Stack<int> boxClothes = new Stack<int>();
            foreach (var item in inputClothes.Split(" ",StringSplitOptions.RemoveEmptyEntries))
            {
                boxClothes.Push(int.Parse(item));
            }
            while (boxClothes.Count>0)
            {
                if (coppyRackCapacity>=boxClothes.Peek())
                {
                    coppyRackCapacity -=boxClothes.Pop();
                }
                else
                {
                    coppyRackCapacity = rackCapacity;
                    printRacks++;
                }
            }
            Console.WriteLine(printRacks);
        }
    }
}
