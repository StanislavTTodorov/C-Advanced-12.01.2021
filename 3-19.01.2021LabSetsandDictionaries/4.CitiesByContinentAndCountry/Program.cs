using System;
using System.Collections.Generic;

namespace _4.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLinesOfData = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> dicionary = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < inputLinesOfData; i++)
            {
                string[] inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continents = inputData[0];
                string countries = inputData[1];
                string cities = inputData[2];
                if (dicionary.ContainsKey(continents))
                {
                    if (dicionary[continents].ContainsKey(countries))
                    {
                        dicionary[continents][countries].Add(cities);
                    }
                    else
                    {
                        dicionary[continents].Add(countries, new List<string> { cities });
                    }
                    
                }
                else
                {
                    dicionary.Add(continents, new Dictionary<string, List<string>> { { countries, new List<string> { cities } } });
                }
            }
            foreach (var continents in dicionary)
            {
                Console.WriteLine(continents.Key+":");
                foreach (var countties in continents.Value)
                {
                    Console.WriteLine($"  {countties.Key} -> {string.Join(", ",countties.Value)}");
                }
            }
        }

    }
}
