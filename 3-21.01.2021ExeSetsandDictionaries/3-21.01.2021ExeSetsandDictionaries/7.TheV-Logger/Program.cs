using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.TheV_Logger
{
    class Program
    {
        public static object Dicionary { get; private set; }

        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            Dictionary<string, List<int>> vLogger = new Dictionary<string, List<int>>();
            Dictionary<string, List<string>> followList = new Dictionary<string, List<string>>();

            while (inputData != "Statistics")
            {
                string[] info = inputData.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (inputData.Contains("joined") && !vLogger.ContainsKey(info[0]))
                {
                    vLogger.Add(info[0], new List<int>() { 0, 0 });
                }
                if (inputData.Contains("followed") &&
                    vLogger.ContainsKey(info[0]) &&
                    vLogger.ContainsKey(info[2]) &&
                    info[0] != info[2])
                {
                    if (followList.ContainsKey(info[2]))
                    {
                        if (!followList[info[2]].Contains(info[0]))                   
                        {
                            followList[info[2]].Add(info[0]);
                            vLogger[info[0]][1] += 1;
                            vLogger[info[2]][0] += 1;
                        }
                    }
                    else
                    {
                        followList.Add(info[2], new List<string> { info[0] });
                        vLogger[info[0]][1] += 1;
                        vLogger[info[2]][0] += 1;
                    }
                }
                inputData = Console.ReadLine();
            }
            int number = 0;
            Console.WriteLine($"The V-Logger has a total of {vLogger.Count} vloggers in its logs.");
            foreach (var item in vLogger.OrderByDescending(n=>n.Value[0]).ThenBy(n=>n.Value[1]))
            {
                if (number == 0)
                {
                    Console.WriteLine($"{++number}. {item.Key} : {item.Value[0]} followers, {item.Value[1]} following");
                    foreach (var name in followList[item.Key].OrderBy(n=>n))
                    {
                        Console.WriteLine($"*  {name}");
                    }
                }
                else
                {
                    Console.WriteLine($"{++number}. {item.Key} : {item.Value[0]} followers, {item.Value[1]} following");
                }
            }
        }
    }
}