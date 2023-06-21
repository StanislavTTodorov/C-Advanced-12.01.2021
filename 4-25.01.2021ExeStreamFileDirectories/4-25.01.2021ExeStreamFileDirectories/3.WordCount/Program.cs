using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsToSearch = File.ReadAllLines("../../../words.txt");
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            foreach (var word in wordsToSearch)
            {
                wordsCount.Add(word.ToLower(), 0);
            }
            using (StreamReader readerText = new StreamReader("../../../text.txt"))
            {
                string line = readerText.ReadLine();
                while (line != null)
                {
                    string[] words = line.ToLower().Split(new string[] { "-", "!", ".", "?", " ", "," }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in words)
                    {
                        if (wordsCount.ContainsKey(word))
                        {
                            wordsCount[word] += 1;
                        }
                    }
                    line = readerText.ReadLine();
                }
                using (StreamWriter actualResult = new StreamWriter("../../../actualResult.txt"))
                {
                    Print(actualResult, wordsCount);
                }
                Dictionary<string,int> sortWordsCount = wordsCount.OrderByDescending(n => n.Value)
                                                                 .ToDictionary(n=>n.Key,n=>n.Value);
                using (StreamWriter expectedResult = new StreamWriter("../../../expectedResult.txt"))
                {
                    Print(expectedResult, sortWordsCount);                  
                }
            }
        }

        private static void Print(StreamWriter result, Dictionary<string, int> wordsCount)
        {
            foreach (var item in wordsCount)
            {
               result.WriteLine($"{item.Key}-{item.Value}");
            };
        }
    }
}
