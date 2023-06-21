using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;


namespace _1.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader readerText = new StreamReader("../../../text.txt"))
            {
                string pattern = @"[-,.!?]";
                string line = readerText.ReadLine();
                int counter = 1;
                using (StreamWriter writerOutput = new StreamWriter("../../../Output.txt"))
                {                
                    while (line!=null)
                    {
                        if (counter++%2==1)
                        {
                            string replacedLine = Regex.Replace(line, pattern, "@");
                            string[] words = replacedLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                            writerOutput.WriteLine(string.Join(" ", words.Reverse()));
                        }
                        line = readerText.ReadLine();
                    }                                      
                }
            }
        }
    }
}
