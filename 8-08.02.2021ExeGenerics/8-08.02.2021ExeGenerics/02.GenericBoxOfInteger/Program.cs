using System;

namespace _2.GenericBoxOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineOfRead = int.Parse(Console.ReadLine());
            for (int i = 0; i < lineOfRead; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(input);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
