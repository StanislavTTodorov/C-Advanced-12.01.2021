using System;
using System.Collections.Generic;

namespace _6.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobes = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                string[] inputClothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
                if (wardrobes.ContainsKey(color))
                {
                    InputClothesInWardrobes(inputClothes, color, wardrobes);
                    
                }
                else
                {
                    wardrobes.Add(color, new Dictionary<string, int>());
                    InputClothesInWardrobes(inputClothes, color, wardrobes);
                }
            }
            string[] lookingFor = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in wardrobes)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var clothes in item.Value)
                {
                    if (item.Key==lookingFor[0]&&clothes.Key==lookingFor[1])
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value}");
                    }
                }
            }
        }

        private static void InputClothesInWardrobes(string[] inputClothes, string color, Dictionary<string, Dictionary<string, int>> wardrobes)
        {
            for (int j = 0; j < inputClothes.Length; j++)
            {
                if (wardrobes[color].ContainsKey(inputClothes[j]))
                {
                    wardrobes[color][inputClothes[j]] += 1;
                }
                else
                {
                    wardrobes[color].Add(inputClothes[j], 1);
                }
            }
        }
    }
}
