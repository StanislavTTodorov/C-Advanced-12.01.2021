using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> food = new Dictionary<string, int>()
            {
                { "Bread",0 },
                { "Cake" ,0},
                { "Fruit Pie" ,0},
                { "Pastry",0 }

            };



            Queue<int> liquid = new Queue<int>();
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            foreach (var item in input)
            {
                liquid.Enqueue(item);
            }
            Stack<int> ingredient = new Stack<int>();
            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            foreach (var item in input)
            {
                ingredient.Push(item);
            }
            while (liquid.Count != 0 && ingredient.Count != 0)
            {
                int sum = liquid.Peek() + ingredient.Peek();
                switch (sum)
                {
                    case 25:
                        food["Bread"]++;                       
                        Removing(liquid, ingredient);
                        break;
                    case 50:
                        food["Cake"]++;                        
                        Removing(liquid, ingredient);
                        break;
                    case 75:
                        food["Pastry"]++;                        
                        Removing(liquid, ingredient);
                        break;
                    case 100:
                        food["Fruit Pie"]++;                       
                        Removing(liquid, ingredient);
                        break;
                    default:
                        liquid.Dequeue();
                        int value = ingredient.Pop() + 3;
                        ingredient.Push(value);
                        break;
                }
            }
            if (food["Bread"]>0&& food["Cake"] > 0 && food["Pastry"] > 0 && food["Fruit Pie"] > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquid.Count==0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.Write("Liquids left: ");
                int count = liquid.Count();
                for (int i = 0; i < count; i++)            
                {
                    if (liquid.Count == 1)
                    {
                        Console.Write(liquid.Dequeue());
                    }
                    else
                    {
                        Console.Write(liquid.Dequeue() + ", ");
                    }
                }
                Console.WriteLine();
            }

            if (ingredient.Count==0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.Write("Ingredients left: ");
                int count = ingredient.Count();
                for (int i = 0; i < count; i++)
                {
                    if (ingredient.Count == 1)
                    {
                        Console.Write(ingredient.Pop());
                    }
                    else
                    {
                        Console.Write(ingredient.Pop() + ", ");
                    }
                }
                Console.WriteLine();
            }
            foreach (var item in food)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

       

        private static void Removing(Queue<int> liquid, Stack<int> ingredient)
        {
            liquid.Dequeue();
            ingredient.Pop();
        }
      
    }
}
