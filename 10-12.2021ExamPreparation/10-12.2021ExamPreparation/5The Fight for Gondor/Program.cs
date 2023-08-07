using System;

using System.Collections.Generic;
using System.Linq;

namespace _5The_Fight_for_Gondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> plate = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> orc = new Stack<int>();
            for (int i = 1; i <= n; i++)
            {
                int[] orcInt = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                foreach (var item in orcInt)
                {
                    orc.Push(item);
                }
                bool onOff = true;
                while (orc.Count > 0&&plate.Count>0)
                {
                    if (i % 3 == 0 && i != 0&&onOff)
                    {
                        onOff = false;
                        int[] newPlate = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                        foreach (var item in newPlate)
                        {
                            plate.Enqueue(item);
                        }
                    }
                    if (plate.Count > 0)
                    {
                        if (plate.Peek() >= orc.Peek())
                        {
                            int plateCopy = plate.Dequeue();
                            while (plateCopy >= 0 && orc.Count > 0 && plateCopy >= orc.Peek())
                            {
                                plateCopy -= orc.Pop();
                            }
                            if (orc.Count == 0 && plateCopy > 0)
                            {
                                plate.Enqueue(plateCopy);
                            }

                            if (orc.Count > 0)
                            {
                                int orcCopy = orc.Pop();
                                orcCopy -= plateCopy;
                                orc.Push(orcCopy);
                            }
                        }
                        else
                        {
                            int orcCopy = orc.Pop();
                            orcCopy -= plate.Dequeue();
                            orc.Push(orcCopy);
                        }
                    }
                }
                if (plate.Count==0)
                {
                    break;
                }
            }
            if (plate.Count==0)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
            }

            if (plate.Count==0&&orc.Count>0)
            {
                Console.WriteLine($"Orcs left: {string.Join(", ",orc)}");
            }
            else if (plate.Count>0)
            {
                Console.WriteLine($"Plates left: {string.Join(", ", plate)}");

            }

        }
    }
}
