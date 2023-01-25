using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shopDictionary = new Dictionary<string, Dictionary<string, double>>();
            string inputData = Console.ReadLine();
            while (inputData!="Revision")
            {
                string[] commands = inputData.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = commands[0];
                string product = commands[1];
                double price = double.Parse(commands[2]);
                if (shopDictionary.ContainsKey(shop))
                {
                    if (shopDictionary[shop].ContainsKey(product))
                    {
                        shopDictionary[shop][product] = price;
                    }
                    else
                    {
                        shopDictionary[shop].Add(product, price);    
                    }
                }
                else
                {
                    shopDictionary.Add(shop, new Dictionary<string, double> { { product, price } });
                }
                inputData = Console.ReadLine();
            }
            foreach (var shop in shopDictionary.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
                
        }
    }
}
