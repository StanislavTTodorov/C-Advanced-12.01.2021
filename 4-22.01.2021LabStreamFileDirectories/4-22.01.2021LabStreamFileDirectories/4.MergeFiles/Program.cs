using System;
using System.IO;

namespace _4.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream output = new FileStream("../../../Output.txt",FileMode.Create,FileAccess.ReadWrite))
            {
            }
            using (StreamReader inputOne = new StreamReader("../../../FileOne.txt"))
            {
                string lineOne = inputOne.ReadLine();
                using (StreamReader inputTwo = new StreamReader ("../../../FileTwo.txt"))
                {
                    string lineTwo = inputTwo.ReadLine();
                    int counter = 0;
                    using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
                    {
                        while (lineOne != null || lineTwo != null)
                        {
                            if (counter % 2 == 1)
                            {
                                writer.WriteLine(lineTwo);
                                lineTwo = inputTwo.ReadLine();
                            }
                            else
                            {
                                writer.WriteLine(lineOne);
                                lineOne = inputOne.ReadLine();
                            }
                            counter++;
                        }
                    }
                }
            }
        }
    }
}
