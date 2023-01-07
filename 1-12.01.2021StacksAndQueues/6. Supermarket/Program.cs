using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> queues = new Queue<string>();
            while (input!="End")
            {
                if (input=="Paid")
                {
                    for (int i = queues.Count; i >0;  i--)
                    {
                        Console.WriteLine(queues.Dequeue());
                    }                                     
                }
                else
                {
                    queues.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{queues.Count} people remaining.");
        }
    }
}
