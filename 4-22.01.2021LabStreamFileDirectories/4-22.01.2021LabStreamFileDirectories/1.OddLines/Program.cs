using System;
using System.IO;

namespace _1.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader readerInputText = new StreamReader("../../../Input.txt"))
            {
                int counter = 1;
                string line = readerInputText.ReadLine();
                using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
                {
                    while (line!=null)
                    {
                        if (counter%2==0)
                        {
                            writer.WriteLine(line);
                        }
                        counter++;
                        line = readerInputText.ReadLine();
                    }
                }
            }
        }
    }
}
