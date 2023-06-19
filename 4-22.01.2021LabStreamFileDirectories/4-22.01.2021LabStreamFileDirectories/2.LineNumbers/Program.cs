using System;
using System.IO;

namespace _2.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader readerInputText = new StreamReader("../../../Input.txt"))
            {
                int count = 1;
                string line = readerInputText.ReadLine();
                using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
                {
                    while (line != null)
                    {
                        writer.WriteLine($"{count++}. {line}");
                        line = readerInputText.ReadLine();
                    }
                }
            }
        }
    }
}
