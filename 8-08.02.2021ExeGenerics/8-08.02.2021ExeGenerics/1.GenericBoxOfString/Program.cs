using System;

namespace _1.GenericBoxOfString
{
   public class Program
    {
        static void Main(string[] args)
        {
            int lineToRead = int.Parse(Console.ReadLine());
            for (int i = 0; i < lineToRead; i++)
            {
                string input = Console.ReadLine();
                Box<string> box = new Box<string>(input);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
