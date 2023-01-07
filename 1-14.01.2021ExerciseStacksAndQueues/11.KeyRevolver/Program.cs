using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = int.Parse(Console.ReadLine());
            int gunBarrel = int.Parse(Console.ReadLine());
            string inputBullets = Console.ReadLine();
            string inputLocks = Console.ReadLine();
            int monеy = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>();
            Queue<int> locks = new Queue<int>();
            foreach (var item in inputBullets.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse))
            {
                bullets.Push(item);
            }
            foreach (var item in inputLocks.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse))
            {
                locks.Enqueue(item);
            }
            int count = 0;
            int index = 0;
            while (bullets.Count>0&&locks.Count>0)
            {
                index++;
                if (bullets.Peek()>locks.Peek())
                {
                    Console.WriteLine("Ping!");
                    bullets.Pop();
                    count++;
                }
                else
                {
                    Console.WriteLine("Bang!");
                    bullets.Pop();
                    locks.Dequeue();
                    count++;
                }                
                if (count==gunBarrel&&bullets.Count!=0)
                {
                    Console.WriteLine("Reloading!");
                    count = 0;
                }
            }
            if (bullets.Count>=0&&locks.Count==0)
            {
                monеy -= index * price;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${monеy}");
            }
            if (bullets.Count==0&&locks.Count>0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
