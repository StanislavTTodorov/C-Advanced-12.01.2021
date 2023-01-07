using System;
using System.Collections.Generic;

namespace _7.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNames = Console.ReadLine();
            int hotPotatoNumber = int.Parse(Console.ReadLine());
            int number =0;
            Queue<string> names = new Queue<string>();
            foreach (var item in inputNames.Split(" ",StringSplitOptions.RemoveEmptyEntries))
            {
                names.Enqueue(item);
            }
            while (names.Count>1)
            {
                number++;
                if (number==hotPotatoNumber)
                {
                    Console.WriteLine("Removed "+ names.Dequeue());
                    number = 0;
                }
                else
                {
                    names.Enqueue(names.Dequeue());
                }
            }
            Console.WriteLine("Last is " + names.Dequeue()) ;
        }
    }
}
