using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            string inputOrders = Console.ReadLine();
            Queue<int> orders = new Queue<int>();
            foreach (var item in inputOrders.Split(" ",StringSplitOptions.RemoveEmptyEntries))
            {
                orders.Enqueue(int.Parse(item));
            }
            Console.WriteLine(orders.Max());
            while (orders.Count>0 && quantityFood>=orders.Peek())
            {
                quantityFood -= orders.Dequeue();
            }
            if (orders.Count>0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ",orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
