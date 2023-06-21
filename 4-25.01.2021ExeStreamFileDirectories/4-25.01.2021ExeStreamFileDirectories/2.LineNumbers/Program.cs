using System;
using System.Collections.Generic;
using System.IO;

namespace _2.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rezult = new List<string>();
            using (StreamReader readerInputText = new StreamReader("../../../text.txt"))
            {
                string line = readerInputText.ReadLine();
                int count = 1;
                while (line!=null)
                {
                    int letters = 0;
                    int symbols = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (char.IsLetter(line[i]))
                        {
                            letters++;
                        }
                        else if (line[i]!=' ')
                        {
                            symbols++;
                        }
                    }
                    rezult.Add($"Line {count++}:{line}({letters})({symbols})");
                    line = readerInputText.ReadLine();
                }
                File.WriteAllLines("../../../Output.txt", rezult);
            }
        }
    }
}
