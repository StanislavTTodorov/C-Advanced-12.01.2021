using System;
using System.Collections.Generic;

namespace _6.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputSong = Console.ReadLine();
            Queue<string> queueSong = new Queue<string>();
            foreach (var item in inputSong.Split(", ", StringSplitOptions.RemoveEmptyEntries))
            {
                queueSong.Enqueue(item);
            }
            while (queueSong.Count > 0)
            {
                inputSong = Console.ReadLine();
                if (inputSong == "Play")
                {
                    queueSong.Dequeue();
                }
                else if (inputSong.Contains("Add"))
                {
                    inputSong = inputSong.Remove(0, 4);
                    if (queueSong.Contains(inputSong))
                    {
                        Console.WriteLine($"{inputSong} is already contained!");
                    }
                    else
                    {
                        queueSong.Enqueue(inputSong);
                    }
                }
                else if (inputSong == "Show")
                {
                    Console.WriteLine(string.Join(", ", queueSong));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
