using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _3.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordForSearch = new Dictionary<string, int>();
            byte[] buffer = new byte[1];
            using (FileStream wordText = new FileStream("../../../words.txt", FileMode.Open))
            {
                StringBuilder word = new StringBuilder();
                while (wordText.Read(buffer, 0, buffer.Length) > 0)
                {
                    if (char.IsLetter((char)buffer[0]))
                    {
                        word.Append((char)buffer[0]);
                    }
                    else if (word.Length > 0)
                    {
                        wordForSearch.Add(string.Join("", word), 0);
                        word = new StringBuilder();
                    }
                }
                if (word.Length > 0)
                {
                    wordForSearch.Add(string.Join("", word).ToLower(), 0);
                };
            }
            using (FileStream inputText = new FileStream("../../../text.txt", FileMode.Open))
            {
                StringBuilder word = new StringBuilder();
                string newWord = string.Empty;
                while (inputText.Read(buffer, 0, buffer.Length) > 0)
                {
                    if (char.IsLetter((char)buffer[0]))
                    {
                        word.Append((char)buffer[0]);
                    }
                    else if (word.Length > 0)
                    {
                        newWord = string.Join("", word).ToLower();
                        if (wordForSearch.ContainsKey(newWord))
                        {
                            wordForSearch[newWord] += 1;
                        }
                        word = new StringBuilder();
                    }
                }
                if (word.Length > 0)
                {
                    newWord = string.Join("", word);
                    if (wordForSearch.ContainsKey(newWord))
                    {
                        wordForSearch[newWord] += 1;
                    }
                }
            }
            using (FileStream writer = new FileStream("../../../Output.txt", FileMode.Create))
            {
            }
                using (StreamWriter writers = new StreamWriter("../../../Output.txt"))
                {
                    foreach (var item in wordForSearch.OrderByDescending(n => n.Value))
                    {
                        writers.WriteLine($"{item.Key}-{item.Value}");
                    }
                }
            
        }
    }
}
