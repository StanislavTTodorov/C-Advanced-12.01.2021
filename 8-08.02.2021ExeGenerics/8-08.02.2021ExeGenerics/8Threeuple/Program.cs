using System;
using System.Text;

namespace _8Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(" ");
            string first = $"{input1[0]} {input1[1]}";
            string third;

            StringBuilder text = new StringBuilder();
            for (int i = 3; i < input1.Length; i++)
            {
                if (input1.Length - 1 == i)
                {
                    text.Append(input1[i]);
                }
                else
                {                  
                    text.Append($"{input1[i]} ");
                }
            }
            third = string.Join(" ", text);

            Tuple<string, string, string> tuple1 = new Tuple<string, string, string>(first, input1[2], third);

            string[] input2 = Console.ReadLine().Split(" ");
            Tuple<string, int, string> tuple2 = new Tuple<string, int, string>(input2[0], int.Parse(input2[1]),GetBool(input2[2]));

            string[] input3 = Console.ReadLine().Split(" ");
            Tuple<string, double, string> tuple3 = new Tuple<string, double, string>(input3[0], double.Parse(input3[1]),input3[2]);

            Console.WriteLine(Print(tuple1));
            Console.WriteLine(Print(tuple2));
            Console.WriteLine(Print(tuple3));
        }

        private static string Print<T,K,B>(Tuple<T, K, B> tuple)
        {
            return $"{tuple.Item1} -> {tuple.Item2} -> {tuple.Item3}";
        }

        private static string GetBool(string word)
        {
            bool isDrunk = (word == "drunk") ? true : false;
            return isDrunk.ToString();
        }
    }
}
